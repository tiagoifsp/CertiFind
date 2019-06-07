using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Diagnostics;
using System.Configuration;
using System.IO;

namespace Controller
{
    public static class CBackup
    {
        public static void Restaurar(String caminho)
        {
            DBackup.Restaurar(caminho);
        }

        public static bool GeraBackup()
        {
            string caminhoBackup = ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString;

            bool resposta = false;

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            Process process = Process.Start(startInfo);

            process.StandardInput.WriteLine(@"IF EXIST " + caminhoBackup + @"\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2% ( rmdir " + caminhoBackup + @"\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2% /S /Q )");
            process.StandardInput.WriteLine(@"mkdir " + caminhoBackup + @"\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2%");
            process.StandardInput.WriteLine(@"xcopy " + ConfigurationManager.ConnectionStrings["CaminhoArquivos"].ConnectionString + @"*.* E:\Backup\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2%\ /s /e");
            process.StandardInput.WriteLine("sqlcmd -S .\\SQLSERVER2014EPE -Q \"BACKUP DATABASE DBCertiFind TO disk = '" + caminhoBackup.Replace(@"\", @"\\") + "Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2%\\backup.bak' WITH FORMAT\"");
            process.StandardInput.WriteLine(@"exit");

            process.WaitForExit();
            
            if (File.Exists(caminhoBackup + @"Backup_Manual_" + DateTime.Now.ToString("yyyy-MM-dd") + @"\backup.bak"))
            {                
                resposta = true;
            }

            return resposta;
        }
    }
}

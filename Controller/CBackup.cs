using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;
using System.Diagnostics;
using System.Configuration;

namespace Controller
{
    public static class CBackup
    {
        public static void Restaurar(String caminho)
        {
            /*if(caminho == "")
            {

            }*/

            DBackup.Restaurar(caminho);
        }

        public static void GeraBackup()
        {
            string caminhoBackup = ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString;

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            Process process = Process.Start(startInfo);

            process.StandardInput.WriteLine(@"IF EXIST " + caminhoBackup + @"\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2% ( rmdir " + caminhoBackup + @"\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2% /S /Q )");
            process.StandardInput.WriteLine(@"mkdir " + caminhoBackup + @"\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2%");
            process.StandardInput.WriteLine(@"xcopy " + ConfigurationManager.ConnectionStrings["CaminhoArquivos"].ConnectionString + @"*.* E:\Backup\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2%\ /s /e");
            process.StandardInput.WriteLine("sqlcmd -S .\\SQLSERVER2014EPE -Q \"BACKUP DATABASE DBCertiFind TO disk = '" + caminhoBackup.Replace(@"\", @"\\") + "Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2%\\backup.bak' WITH FORMAT\"");
            process.StandardInput.WriteLine(@"exit");
        }
    }
}

using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertiFind
{
    public partial class frmGerarRestaurarBackup : Form
    {
        public frmGerarRestaurarBackup()
        {
            InitializeComponent();
        }

        private void ListarBackup()
        {
            DirectoryInfo Dir = new DirectoryInfo(ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString);
            DirectoryInfo[] Files = Dir.GetDirectories("*", SearchOption.TopDirectoryOnly);
            foreach (DirectoryInfo File in Files)
            {
                dgvGerarRestaurarBackup.Rows.Add(File.FullName,null);
            }

              
        }

        private void GeraBackup()
        {
            string caminhoBackup = ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString;

            ProcessStartInfo startInfo = new ProcessStartInfo("cmd.exe");
            startInfo.RedirectStandardInput = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.UseShellExecute = false;
            Process process = Process.Start(startInfo);

            process.StandardInput.WriteLine(@"IF EXIST " + caminhoBackup + @"\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2% ( rmdir " + caminhoBackup + @"\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2% /S /Q )");
            process.StandardInput.WriteLine(@"mkdir "+ caminhoBackup + @"\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2%");
            process.StandardInput.WriteLine(@"xcopy " + ConfigurationManager.ConnectionStrings["CaminhoArquivos"].ConnectionString + @"*.* E:\Backup\Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2%\ /s /e");
            process.StandardInput.WriteLine("sqlcmd -S .\\SQLSERVER2014EPE -Q \"BACKUP DATABASE DBCertiFind TO disk = '" + caminhoBackup.Replace(@"\",@"\\") + "Backup_Manual_%date:~6,4%-%date:~3,2%-%date:~0,2%\\backup.bak' WITH FORMAT\"");
            process.StandardInput.WriteLine(@"exit");
        }

        private void frmGerarRestaurarBackup_Load(object sender, EventArgs e)
        {
            ListarBackup();
        }

        private void dgvGerarRestaurarBackup_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                string caminho = ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString + @"Backup_Manual_" + DateTime.Now.ToString("yyyy-MM-dd");
                String caminhoNovo = ConfigurationManager.ConnectionStrings["CaminhoArquivos"].ConnectionString;

                CriarPasta(caminho, caminhoNovo,true);

                CBackup.Restaurar(dgvGerarRestaurarBackup.Rows[e.RowIndex].Cells[0].Value.ToString());


                /*SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["ConexaoLocal"].ConnectionString;
                
                try
                {
                    conexao.Open();                    
                }
                catch
                {
                    throw new Exception("Erro de Conexão");
                }
                               

                SqlCommand comando = new SqlCommand();
                comando.Connection = conexao;

                string[] arquivos = Directory.GetFiles(dgvGerarRestaurarBackup.Rows[e.RowIndex].Cells[0].Value.ToString(), "*.bak", SearchOption.AllDirectories);

                comando.CommandText = "RESTORE DATABASE DBCertiFind FROM DISK = '" + arquivos[0] + "' with replace; ";
                
                try
                {
                    comando.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    throw new Exception(ex.ToString());
                }
                finally
                {
                    conexao.Close();
                }*/
            }
        }

        private void SubPastas(string caminho)
        {
            var dir = new DirectoryInfo(caminho);

            foreach (var file in dir.GetFiles())
            {
                // Copy the file.
                file.CopyTo(ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString + @"Backup_" + DateTime.Now.ToString("yyyy-MM-dd") + @"_Manual\" + file.Name, true);
            }

            foreach (var file in dir.GetDirectories())
            {
                // Copy the file.
                //file.c(ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString + @"Backup_" + DateTime.Now.ToString("yyyy-MM-dd") + @"_Manual\" + file.Name, true);
                //SubPastas();
            }
        }

        private void CriarPasta(String caminho, String caminhoNovo, bool delete)
        {
            if(delete)
                System.IO.Directory.Delete(caminhoNovo, true);

            System.IO.Directory.CreateDirectory(caminhoNovo);

            if (System.IO.Directory.Exists(caminho))
            {
                string[] files = System.IO.Directory.GetFiles(caminho);
                
                foreach (string s in files)
                {
                    string fileName = System.IO.Path.GetFileName(s);
                    string destFile = System.IO.Path.Combine(caminhoNovo, fileName);
                    System.IO.File.Copy(s, destFile, true);
                }

                string[] directory = System.IO.Directory.GetDirectories(caminho);
                foreach (string s in directory)
                {
                    DirectoryInfo infoArquivo = new DirectoryInfo(s);
                    string destFile = System.IO.Path.Combine(caminhoNovo, infoArquivo.Name);
                    System.IO.Directory.CreateDirectory(caminhoNovo);
                    CriarPasta(System.IO.Path.Combine(caminho, infoArquivo.Name), destFile,false);
                }

            }
            else
            {
                MessageBox.Show("Teste");
                //Console.WriteLine("Source path does not exist!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GeraBackup();
        }
    }
}

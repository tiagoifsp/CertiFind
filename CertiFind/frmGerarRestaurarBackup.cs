using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
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

        private void Listar()
        {
            DirectoryInfo Dir = new DirectoryInfo(ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString);
            DirectoryInfo[] Files = Dir.GetDirectories("*", SearchOption.AllDirectories);
            foreach (DirectoryInfo File in Files)
            {
                dgvGerarRestaurarBackup.Rows.Add(File.FullName, null);
            }
        }

        private void frmGerarRestaurarBackup_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvGerarRestaurarBackup_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                SqlConnection conexao = new SqlConnection();
                conexao.ConnectionString = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;

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
                MessageBox.Show(comando.CommandText);       
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
                }
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
                file.c(ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString + @"Backup_" + DateTime.Now.ToString("yyyy-MM-dd") + @"_Manual\" + file.Name, true);
                SubPastas();
            }
        }

        private void CriarPasta()
        {
            Directory.CreateDirectory(ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString + @"Backup_" + DateTime.Now.ToString("yyyy-MM-dd") + @"_Manual");

            var dir = new DirectoryInfo(ConfigurationManager.ConnectionStrings["CaminhoArquivos"].ConnectionString);

            foreach (var file in dir.GetFiles())
            {
                // Copy the file.
                file.CopyTo(ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString + @"Backup_" + DateTime.Now.ToString("yyyy-MM-dd") + @"_Manual\" + file.Name, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conexao = new SqlConnection();
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

            comando.CommandText = "BACKUP DATABASE DBCertiFind TO disk = '" + ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString + @"Backup_"+ DateTime.Now.ToString("yyyy-MM-dd") +@"_Manual\backup_manual.bak' WITH FORMAT;";
            MessageBox.Show(comando.CommandText);

            try
            {
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.ToString());
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}

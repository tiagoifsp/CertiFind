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
    public partial class VGerarRestaurarBackup : Form
    {
        public VGerarRestaurarBackup()
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

                bool teste = false;

                if (Directory.Exists(caminhoNovo))
                    teste = true;

                CriarPasta(caminho, caminhoNovo,teste);

                CBackup.Restaurar(dgvGerarRestaurarBackup.Rows[e.RowIndex].Cells[0].Value.ToString());
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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CBackup.GeraBackup();
        }
    }
}

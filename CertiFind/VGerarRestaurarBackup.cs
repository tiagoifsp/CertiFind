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
            dgvGerarRestaurarBackup.Rows.Clear();

            DirectoryInfo Dir = new DirectoryInfo(ConfigurationManager.ConnectionStrings["CaminhoBackup"].ConnectionString);
            DirectoryInfo[] Diretorios = Dir.GetDirectories("*", SearchOption.TopDirectoryOnly);
            foreach (DirectoryInfo Pasta in Diretorios)
            {
                dgvGerarRestaurarBackup.Rows.Add(Pasta.FullName,null);
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
                string caminho = dgvGerarRestaurarBackup.Rows[e.RowIndex].Cells[0].Value.ToString(); ;
                String caminhoNovo = ConfigurationManager.ConnectionStrings["CaminhoArquivos"].ConnectionString;

                bool Existe = false;

                if (Directory.Exists(caminhoNovo))
                    Existe = true;

                CriarPasta(caminho, caminhoNovo, Existe);

                CBackup.Restaurar(dgvGerarRestaurarBackup.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void CriarPasta(String caminho, String caminhoNovo, bool delete)
        {
            try
            {
                if (delete)
                    System.IO.Directory.Delete(caminhoNovo, true);

                System.IO.Directory.CreateDirectory(caminhoNovo);

                if (System.IO.Directory.Exists(caminho))
                {
                    string[] files = System.IO.Directory.GetFiles(caminho);

                    foreach (string s in files)
                    {
                        string fileName = System.IO.Path.GetFileName(s);
                        string destFile = System.IO.Path.Combine(caminhoNovo, fileName);
                        if(fileName != "backup.bak")
                            System.IO.File.Copy(s, destFile, true);
                    }

                    string[] directory = System.IO.Directory.GetDirectories(caminho);
                    foreach (string s in directory)
                    {
                        DirectoryInfo infoArquivo = new DirectoryInfo(s);
                        string destFile = System.IO.Path.Combine(caminhoNovo, infoArquivo.Name);
                        System.IO.Directory.CreateDirectory(caminhoNovo);
                        CriarPasta(System.IO.Path.Combine(caminho, infoArquivo.Name), destFile, false);
                    }
                }
                else
                {
                    MessageBox.Show("O local do Backup não existe!");
                }
            }
            catch(Exception ex)
            {
                CLogs.Log(ex);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CBackup.GeraBackup();
            ListarBackup();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Controller;

namespace CertiFind
{
    public partial class VPesquisaUsuario : Form
    {
        public VPesquisaUsuario()
        {
            InitializeComponent();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            MUsuario item = new MUsuario();
            if (cmbTipo.Text != "")
            {
                String nome = cmbTipo.Text.Substring(0, 1);

                item.Nome = txtNome.Text;
                item.Situacao = nome;
            }
            else
            {
                item.Nome = txtNome.Text;
                item.Situacao = cmbTipo.Text;
            }
            dgvPesquisa.DataSource = CUsuario.Pesquisar(item);
        }
        //precisa arrumar
        private void Excluir()
        {
            if (dgvPesquisa.SelectedRows != null &&
                dgvPesquisa.SelectedRows.Count > 0)
            {
                DialogResult r = MessageBox.Show("Deseja excluir esta pessoa?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (r == DialogResult.Yes)
                {
                    //forma 1
                    //MPessoa item = new MPessoa();
                    //item.CPF = dataGridView1.SelectedRows[0].
                    //    Cells["cPFDataGridViewTextBoxColumn"].Value.ToString();

                    //forma 2
                    MUsuario item = (MUsuario)dgvPesquisa.SelectedRows[0].
                       DataBoundItem;

                    bool sucesso = false;
                    try
                    {
                        CUsuario.Excluir(item);
                        sucesso = true;
                    }
                    catch
                    {
                        MessageBox.Show("Erro ao excluir a pessoa selecionada",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    if (sucesso)
                    {
                        MessageBox.Show("Pessoa excluída com sucesso", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Forma 1
                        //btnPesquisar_Click(null, null);

                        //Forma 2
                        List<MUsuario> lista = (List<MUsuario>)dgvPesquisa.DataSource;
                        lista.Remove(item);

                        dgvPesquisa.DataSource = null;
                        dgvPesquisa.DataSource = lista;
                    }
                }
            }
        }

        private void ExcluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir();
        }
        //precisa arrumar
         private void Editar()
          {
              if (dgvPesquisa.SelectedRows != null &&
                 dgvPesquisa.SelectedRows.Count > 0)
              {
                  MUsuario item = new MUsuario();
                  item.ID = (int)dgvPesquisa.SelectedRows[0].Cells["ID"].Value;

                  VEdicaoUsuario v = new VEdicaoUsuario(item);
                  v.ShowDialog();

                  if (v.Atualizou)
                  {
                      //atualiza o grid
                      //forma 1
                      //atualiza a lista sem ir no banco

                      //forma 2
                      BtnPesquisar_Click(null, null);
                  }
              }
          }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Editar();
        }
    }
}

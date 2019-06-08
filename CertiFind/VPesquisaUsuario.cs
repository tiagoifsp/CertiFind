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
            if (dataGridView1.SelectedRows != null &&
                dataGridView1.SelectedRows.Count > 0)
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
                    MPessoa item = (MPessoa)dataGridView1.SelectedRows[0].
                       DataBoundItem;

                    bool sucesso = false;
                    try
                    {
                        CPessoa.Excluir(item);
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
                        List<MPessoa> lista = (List<MPessoa>)dataGridView1.DataSource;
                        lista.Remove(item);

                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = lista;
                    }
                }
            }
        }
        //precisa arrumar
        private void Editar()
        {
            if (dataGridView1.SelectedRows != null &&
               dataGridView1.SelectedRows.Count > 0)
            {
                MPessoa item = new MPessoa();
                item.CPF = dataGridView1.SelectedRows[0].
                    Cells["cPFDataGridViewTextBoxColumn"].Value.ToString();

                VPessoaEditar v = new VPessoaEditar(item);
                v.ShowDialog();

                if (v.Atualizou)
                {
                    //atualiza o grid
                    //forma 1
                    //atualiza a lista sem ir no banco

                    //forma 2
                    btnPesquisar_Click(null, null);
                }
            }
        }

    }
}

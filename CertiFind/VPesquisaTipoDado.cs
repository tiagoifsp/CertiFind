using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertiFind
{
    public partial class VPesquisaTipoDado : Form
    {
        public VPesquisaTipoDado()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new VCadastroTipoDado(null);
            form.ShowDialog();

            btnPesquisar_Click(null, null);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MTipoDado item = new MTipoDado();
            item.Nome = txtNome.Text.Trim();

            dgvResultado.DataSource = null;

            try
            {
                dgvResultado.DataSource = CTipoDado.Pesquisar(item);
            }
            catch (ExcecaoPadrao ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show(Erros.ErroGeral);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows != null && dgvResultado.SelectedRows.Count > 0)
            {
                MTipoDado item = new MTipoDado();

                item.ID = int.Parse(dgvResultado.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString());

                Form form = new VCadastroTipoDado(item);
                form.ShowDialog();

                btnPesquisar_Click(null, null);
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows != null && dgvResultado.SelectedRows.Count > 0)
            {
                DialogResult modal = MessageBox.Show("Deseja excluir este tipo de dado?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (modal == DialogResult.Yes)
                {
                    MTipoDado item = new MTipoDado();

                    item.ID = int.Parse(dgvResultado.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString());

                    try
                    {
                        CTipoDado.Excluir(item);

                        MessageBox.Show("Tipo de dado excluído com sucesso.", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnPesquisar_Click(null, null);
                    }
                    catch (ExcecaoPadrao ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    catch
                    {
                        MessageBox.Show(Erros.ErroGeral);
                    }
                }
            }
        }

    }
}

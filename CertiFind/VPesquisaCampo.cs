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
    public partial class VPesquisaCampo : Form
    {
        public VPesquisaCampo()
        {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new VCadastroCampo(null);
            form.ShowDialog();

            btnPesquisar_Click(null, null);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MCampo item = new MCampo();
            item.Nome = txtNome.Text.Trim();
            item.TipoDado = int.Parse(cboTipoDado.SelectedValue.ToString());

            dgvResultado.DataSource = null;

            try
            {
                dgvResultado.DataSource = CCampo.Pesquisar(item);
            }
            catch (ExcecaoPadrao ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show(Erros.ErroGeral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows != null && dgvResultado.SelectedRows.Count > 0)
            {
                MCampo item = new MCampo();

                item.ID = int.Parse(dgvResultado.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString());

                Form form = new VCadastroCampo(item);
                form.ShowDialog();

                btnPesquisar_Click(null, null);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows != null && dgvResultado.SelectedRows.Count > 0)
            {
                DialogResult modal = MessageBox.Show("Deseja excluir este campo?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (modal == DialogResult.Yes)
                {
                    MCampo item = new MCampo();

                    item.ID = int.Parse(dgvResultado.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString());

                    try
                    {
                        CCampo.Excluir(item);

                        MessageBox.Show("Campo excluído com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnPesquisar_Click(null, null);
                    }
                    catch (ExcecaoPadrao ex)
                    {
                        MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch
                    {
                        MessageBox.Show(Erros.ErroGeral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void VPesquisaCampo_Load(object sender, EventArgs e)
        {
            MTipoDado item = new MTipoDado();
            item.Nome = "";
            List<MTipoDado> lista = CTipoDado.Pesquisar(item);

            if (lista == null)
                lista = new List<MTipoDado>();

            item.Nome = "[Todos]";
            lista.Insert(0, item);

            cboTipoDado.DataSource = lista;
        }
    }
}

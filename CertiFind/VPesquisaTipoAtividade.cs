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
    public partial class VPesquisaTipoAtividade : Form
    {
        public VPesquisaTipoAtividade()
        {
            InitializeComponent();
        }

        //btn Inserir
        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new VCadastroTipoAtividade(null);
            form.ShowDialog();

            btnPesquisar_Click(null, null);
        }

        //btn Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MTipoAtividade item = new MTipoAtividade();
            item.Nome = txtNome.Text.Trim();

            dgvResultado.DataSource = null;

            try
            {
                dgvResultado.DataSource = CTipoAtividade.Pesquisar(item);
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

        //btn Editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            MTipoAtividade item = new MTipoAtividade();

            item.ID = int.Parse(dgvResultado.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString());

            Form form = new VCadastroTipoAtividade(item);
            form.ShowDialog();

            btnPesquisar_Click(null, null);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows != null && dgvResultado.SelectedRows.Count > 0)
            {

                DialogResult modal = MessageBox.Show("Deseja excluir este tipo de dado?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (modal == DialogResult.Yes)
                {
                    MTipoAtividade item = new MTipoAtividade();

                    item.ID = int.Parse(dgvResultado.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString());

                    try
                    {
                        CTipoAtividade.Excluir(item);

                        MessageBox.Show("Tipo de atividade excluído com sucesso.", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

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
    }
}

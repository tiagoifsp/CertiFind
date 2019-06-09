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
    public partial class VPesquisaCertificado : Form
    {
        public VPesquisaCertificado()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MCertificado item = new MCertificado();

            try
            {
                item.UsuarioID = int.Parse(cboUsuario.SelectedValue.ToString());
            }
            catch
            {
                item.UsuarioID = -1;
            }

            item.TipoAtividadeID = int.Parse(cboTipoAtividade.SelectedValue.ToString());

            dgvResultado.DataSource = null;

            try
            {
                dgvResultado.DataSource = CCertificado.Pesquisar(item);
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Form form = new VCadastroCertificado(null);
            form.ShowDialog();

            btnPesquisar_Click(null, null);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows != null && dgvResultado.SelectedRows.Count > 0)
            {
                MCertificado item = new MCertificado();

                item.ID = int.Parse(dgvResultado.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString());

                Form form = new VCadastroCertificado(item);
                form.ShowDialog();

                btnPesquisar_Click(null, null);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows != null && dgvResultado.SelectedRows.Count > 0)
            {
                DialogResult modal = MessageBox.Show("Deseja excluir este relacionamento?", "",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2);

                if (modal == DialogResult.Yes)
                {
                    MCertificado item = new MCertificado();

                    item.ID = int.Parse(dgvResultado.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString());

                    try
                    {
                        CCertificado.Excluir(item);

                        MessageBox.Show("Relacionamento excluído com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void VPesquisaCertificado_Load(object sender, EventArgs e)
        {
            //Preencher combobox com tipo de atividade
            MTipoAtividade item = new MTipoAtividade();
            item.Nome = "";
            List<MTipoAtividade> lista = CTipoAtividade.Pesquisar(item);

            if (lista == null)
                lista = new List<MTipoAtividade>();

            item.Nome = "[Escolha]";
            lista.Insert(0, item);

            cboTipoAtividade.DataSource = lista;

            //CARREGANDO COMBOBOX MANUALMENTE POIS A DAL E CONTROLLER DE USUÁRIOS NÃO TEM PESQUISA IMPLEMENTADA
            List<MUsuario> UsuariosCBO = new List<MUsuario>();
            MUsuario primeiro = new MUsuario();
            MUsuario admin = new MUsuario();
            primeiro.Nome = "[Escolha]";
            primeiro.ID = 0;
            UsuariosCBO.Add(primeiro);
            admin.Nome = "admin";
            admin.ID = 1;
            UsuariosCBO.Add(admin);

            cboUsuario.DataSource = UsuariosCBO;

        }
    }
}

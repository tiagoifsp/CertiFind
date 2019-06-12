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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void btncadastrogp_Click(object sender, EventArgs e)
        {
            VCadastroGrupoPesquisa vgp = new VCadastroGrupoPesquisa();

            vgp.Show();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            if(VLogin.usuarioAtual != null)
            {
                label2.Text = VLogin.usuarioAtual.Nome + " (" + VLogin.usuarioAtual.ID + ")";
            }
        }

        private void btnVCadastroTipoDados_Click(object sender, EventArgs e)
        {
            VCadastroTipoDado form = new VCadastroTipoDado(null);
            form.ShowDialog();
        }

        private void btnVPesquisaTipoDados_Click(object sender, EventArgs e)
        {
            VPesquisaTipoDado form = new VPesquisaTipoDado();
            form.ShowDialog();
        }

        private void btnVCadastroCampo_Click(object sender, EventArgs e)
        {
            VCadastroCampo form = new VCadastroCampo(null);
            form.ShowDialog();
        }

        private void btnVPesquisaCampo_Click(object sender, EventArgs e)
        {
            VPesquisaCampo form = new VPesquisaCampo();
            form.ShowDialog();
        }


        private void btnVPesquisaTipoAtividade_Click(object sender, EventArgs e)
        {
            VPesquisaTipoAtividade form = new VPesquisaTipoAtividade();
            form.ShowDialog();
        }

        private void btnVCadastroTipoAtividadeCampo_Click(object sender, EventArgs e)
        {
            VCadastroTipoAtividadeCampo form = new VCadastroTipoAtividadeCampo(null);
            form.ShowDialog();
        }

        private void btnVPesquisaTipoAtividadeCampo_Click(object sender, EventArgs e)
        {
            VPesquisaTipoAtividadeCampo form = new VPesquisaTipoAtividadeCampo();
            form.ShowDialog();
        }

        private void btnVCadastroTipoAtividade_Click_1(object sender, EventArgs e)
        {
            VCadastroTipoAtividade form = new VCadastroTipoAtividade(null);
            form.ShowDialog();
        }

        private void btnCadastroCertificado_Click(object sender, EventArgs e)
        {
            VCadastroCertificado form = new VCadastroCertificado(null);
            form.ShowDialog();
        }

        private void btnPesquisaCertificado_Click(object sender, EventArgs e)
        {
            VPesquisaCertificado form = new VPesquisaCertificado();
            form.ShowDialog();
        }
    }
}

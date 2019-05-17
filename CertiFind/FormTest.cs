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
            VCadastroCampo form = new VCadastroCampo();
            form.ShowDialog();
        }

        private void btnVPesquisaCampo_Click(object sender, EventArgs e)
        {
            VPesquisaCampo form = new VPesquisaCampo();
            form.ShowDialog();
        }
    }
}

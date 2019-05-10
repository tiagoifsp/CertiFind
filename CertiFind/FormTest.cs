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

        private void btnVCadastroTipoDado_Click(object sender, EventArgs e)
        {
            VCadastroTipoDado form = new VCadastroTipoDado();
            form.ShowDialog();
        }

        private void btnFormPesquisaTipoDados_Click(object sender, EventArgs e)
        {
            VPesquisaTipoDado form = new VPesquisaTipoDado();
            form.ShowDialog();
        }
    }
}

using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
namespace CertiFind
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            if(VLogin.usuarioAtual != null)
            {
                label2.Text = VLogin.usuarioAtual.Nome + " (" + VLogin.usuarioAtual.ID + ")";
            }
            timer1.Start();

            lblBase.Text = CStatus.Banco();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CStatus.VerificaConexao() == false)
                lblStatus.Text = "Desconectado";
            else
                lblStatus.Text = "Conectado";

            // DADOS DA CONTROLLER AQUI
            CStatus p = new CStatus();

            lblBytes.Text = (CStatus.Pastas()[0].ToString() + " Bytes");
            lblQtdArq.Text = (CStatus.Pastas()[1].ToString() + " Arquivos");

            

        }
    }
}

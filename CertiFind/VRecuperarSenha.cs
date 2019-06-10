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
    public partial class VRecuperarSenha : Form
    {
        public VRecuperarSenha()
        {
            InitializeComponent();
        }

        private void VRecuperarSenha_Load(object sender, EventArgs e)
        {
            if (VLogin.usuarioAtual != null)
            {
                txtNome.Text = VLogin.usuarioAtual.Nome;
                  int Id = (int)VLogin.usuarioAtual.ID ;
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            MUsuario u = new MUsuario();
            u.Senha = txtSenha.Text;

            try {

                CUsuario.Atualizar(u);
                MessageBox.Show("Dados salvos com sucesso!");
                this.Close();
            }
            catch {

            }
        }
    }
}

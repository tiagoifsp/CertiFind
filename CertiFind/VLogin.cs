using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertiFind
{
    public partial class VLogin : Form
    {
        public static MUsuario usuarioAtual { get; set; }

        public VLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
             Regex rg = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");

            if ((!rg.IsMatch(txtEmail.Text)))
            {
                errorProvider1.SetError(txtEmail,"Campo E-mail vazio");
                txtEmail.Focus();

                //todo: trocar pra errorProvider
            }
            
            if (txtSenha.Text.Trim() == "")
            {
                errorProvider1.SetError(txtSenha,"Campo Senha vazio");
                txtSenha.Focus();

                //todo: trocar pra errorProvider
            }

            MUsuario u = new MUsuario
            {
                Email = txtEmail.Text,
                Senha = CUsuario.Encriptar(txtSenha.Text)
            };

            try
            {
                usuarioAtual = CUsuario.Login(u);
                if (usuarioAtual != null)
                {
                    usuarioAtual = CUsuario.Obter(usuarioAtual);
                    this.Visible = false;
                    new FormTest().ShowDialog();
                    LimparCampos();
                    this.Visible = true;
                }
                else
                {
                    MessageBox.Show("Usuário/senha inválido. Alterar esta mensagem");
                    //lbMessage.Text = "Usuario ou senha inválidos";
                    //lbRecuperarSenha.Text = "Clique aqui para recuperar senha";
                }
            }
            catch(ExcecaoPadrao ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show(Erros.ErroGeral);
            }
        }

        private void LimparCampos()
        {
            usuarioAtual = null;

            txtEmail.Text = "";
            txtSenha.Text = "";

            txtEmail.Focus(); //não funcionou?
        }

        private void VLogin_Load(object sender, EventArgs e)
        {
            usuarioAtual = null;
        }
    }
}

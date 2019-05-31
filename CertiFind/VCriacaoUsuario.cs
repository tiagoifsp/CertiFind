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
    public partial class VCriacaoUsuario : Form
    {
        public VCriacaoUsuario()
        {
            InitializeComponent();

            MUsuario item = new MUsuario();
            item.Nome = "";
            item.Senha = "";
            item.Email = "";

            cmbSituacao.DataSource = CUsuario.Pesquisar(item);
            cmbTipoUsuario.DataSource = CUsuario.Pesquisar(item);
        }

     
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            //todo: validação da entrada
            MUsuario item = new MUsuario();

            item.Nome = txtNome.Text;
            item.Email = txtEmail.Text;
            item.Senha = txtSenha.Text;
            item.Situacao = cmbSituacao.SelectedText;

            try
            {
                CUsuario.Inserir(item);
                MessageBox.Show("Dados salvos com sucesso!");
                Limpar();
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Limpar()
        {
            txtNome.Text = ("");
            txtEmail.Text = ("");
            txtSenha.Text = ("");
            cmbSituacao.SelectedText = ("");
        }
    }
}

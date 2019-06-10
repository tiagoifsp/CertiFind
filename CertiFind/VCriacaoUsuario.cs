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
           

            MTipoUsuario item1 = new MTipoUsuario();
                 
            cmbTipoUsuario.DataSource = CTipoUsuario.PesquisaLista(item1);

            if(cmbTipoUsuario.SelectedText == "")
            {
                Atualizar();
            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (cmbSituacao.Text.Trim() != "")
            {
                String nome = cmbSituacao.Text.Substring(0, 1);

                //todo: validação da entrada

                MUsuario item = new MUsuario();

            item.Nome = txtNome.Text;
            item.Email = txtEmail.Text;
            item.Senha = txtSenha.Text;
            item.Situacao = nome;
            item.FKTipoUsuarioID = (int)cmbTipoUsuario.SelectedValue;
                    ;

         

                if (txtNome.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtNome, "Campo nome Vazio");
                }
                if (txtEmail.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtEmail, "Campo Email Vazio");
                }
                if (txtEmail.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtSenha, "Campo Senha Vazio");
                }
                if (cmbSituacao.Text.Trim() == "")
                {
                    errorProvider1.SetError(cmbSituacao, "Não pode ser Vazio");
                }

                try
                {
                    CUsuario.Inserir(item);
                    MessageBox.Show("Dados salvos com sucesso!");
                    Atualizar();
                    Limpar();
                }
                catch (Exception ex)

                {
                    MessageBox.Show(ex.Message);
                    Atualizar();
                }
            }
        }

        private void Limpar()
        {
            txtNome.Text = ("");
            txtEmail.Text = ("");
            txtSenha.Text = ("");
            cmbSituacao.SelectedText = ("");
        }


        private void Atualizar()
        {
            MTipoUsuario item = new MTipoUsuario();
            CTipoUsuario.Atualizar(item);

        }
    }
}

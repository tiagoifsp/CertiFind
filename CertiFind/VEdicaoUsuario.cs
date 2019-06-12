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
    public partial class VEdicaoUsuario : Form
    {
        MUsuario atual = null;
        internal bool Atualizou = false;

        public VEdicaoUsuario(MUsuario item)
        {

            InitializeComponent();
            atual = item;

            MTipoUsuario u = new MTipoUsuario();
            cmbUsuario.DataSource = CTipoUsuario.PesquisaLista(u);

            if (cmbUsuario.SelectedText == "")
            {
                Atualizar1();
            }

        }
        private void Atualizar1()
        {
            MTipoUsuario item = new MTipoUsuario();
            CTipoUsuario.Atualizar(item);

        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {

            if (cmbSituação.Text.Trim() != "")
            {
                String te = cmbSituação.Text.Substring(0, 1);

                atual.Email = txtEmail.Text;
                atual.Nome = txtNome.Text;
                atual.FKTipoUsuarioID = (int)cmbUsuario.SelectedValue;
                atual.Situacao = te;

                bool sucesso = false;

                try
                {
                    CUsuario.Atualizar(atual);
                    sucesso = true;
                }
                catch
                {
                    MessageBox.Show("Erro na atualização!");
                }

                if (sucesso)
                {
                    MessageBox.Show("Dados atualizados com sucesso!");
                    Atualizou = true;
                    Close();
                }
            }
        }
        private void VEdicaoUsuario_Load(object sender, EventArgs e)
        {
            atual = CUsuario.Obter(atual);

            if (atual != null)
            {
                txtEmail.Text = atual.Email;
                txtNome.Text = atual.Nome;
            }
            else
            {
                Close();
            }

        }
    }
}

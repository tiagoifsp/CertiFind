using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace CertiFind
{
    public partial class VCriacaoTipoUsuario : Form
    {
        public VCriacaoTipoUsuario()
        {
            InitializeComponent();

            MTipoUsuario item = new MTipoUsuario();
            item.Nome = "";
            item.Descricao = "";
            item.Situacao = "";

          
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            String nome = cmbSituacao.Text.Substring(0,1);

            MTipoUsuario item = new MTipoUsuario();

            item.Nome = txtNome.Text;
            item.Descricao = txtDesc.Text;
            item.Situacao = nome;

            try
            {
                CTipoUsuario.Inserir(item);
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
            txtDesc.Text = ("");
            cmbSituacao.SelectedText = ("");
        }


    }
}

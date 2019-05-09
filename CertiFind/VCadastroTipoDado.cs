using Controller;
using Model;
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
    public partial class VCadastroTipoDado : Form
    {
        internal bool edicao = false;

        public VCadastroTipoDado()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MTipoDado item = new MTipoDado();

            item.Nome = txtNome.Text;
            item.Descricao = txtDescricao.Text;

            try
            {
                if (!edicao)
                {
                    CTipoDado.Inserir(item);
                    MessageBox.Show("Tipo de dado salvo com sucesso.");
                }
                else
                {
                    //CTipoDado.Editar(item);
                    MessageBox.Show("Tipo de dado alterado com sucesso.");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroTipoDado_Load(object sender, EventArgs e)
        {
            if (!edicao)
            {
                this.Text = "Novo tipo de dado";
            }
            else
            {
                this.Text = "Editando tipo de dado";
            }
        }
    }
}

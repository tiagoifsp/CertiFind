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
    public partial class FormCadastroTipoDado : Form
    {
        public FormCadastroTipoDado()
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
                CTipoDado.Inserir(item);
                MessageBox.Show("Tipo de dado salvo com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

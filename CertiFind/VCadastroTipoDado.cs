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
        MTipoDado atual = null;

        public VCadastroTipoDado(MTipoDado item)
        {
            InitializeComponent();
            item = CTipoDado.Obter(item);
            atual = item;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MTipoDado item = new MTipoDado();

            item.Nome = txtNome.Text;
            item.Descricao = txtDescricao.Text;

            try
            {
                if(atual != null)
                {
                    item.ID = atual.ID;
                    CTipoDado.Editar(item);
                    MessageBox.Show("Tipo de dado alterado com sucesso.");
                }
                else
                {
                    CTipoDado.Inserir(item);
                    MessageBox.Show("Tipo de dado salvo com sucesso.");
                }
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormCadastroTipoDado_Load(object sender, EventArgs e)
        {
            if(atual != null)
            {
                this.Text = "Editando tipo de dado";
            }
            else
            {
                this.Text = "Novo tipo de dado";
            }

            try
            {
                if(atual != null)
                {
                    txtNome.Text = atual.Nome;
                    txtDescricao.Text = atual.Descricao;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

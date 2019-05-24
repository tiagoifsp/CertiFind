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
    public partial class VCadastroCampo : Form
    {
        MCampo atual = null;

        public VCadastroCampo(MCampo item)
        {
            InitializeComponent();
            item = CCampo.Obter(item);
            atual = item;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MCampo item = new MCampo();

            item.Nome = txtNome.Text.Trim();
            item.TipoDado = int.Parse(cboTipoDado.SelectedValue.ToString());

            try
            {
                if (atual != null)
                {
                    item.ID = atual.ID;
                    CCampo.Editar(item);
                    MessageBox.Show("Campo alterado com sucesso.");
                }
                else
                {
                    CCampo.Inserir(item);
                    MessageBox.Show("Campo salvo com sucesso.");
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VCadastroCampo_Load(object sender, EventArgs e)
        {
            if (atual != null)
            {
                this.Text = "Editando campo";
            }
            else
            {
                this.Text = "Novo campo";
            }

            MTipoDado item = new MTipoDado();
            item.Nome = "";
            List<MTipoDado> lista = CTipoDado.Pesquisar(item); 

            item.Nome = "[Escolha]";
            lista.Insert(0, item);

            cboTipoDado.DataSource = lista;

            try
            {
                if (atual != null)
                {
                    txtNome.Text = atual.Nome;
                    cboTipoDado.SelectedValue = atual.TipoDado.Value;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

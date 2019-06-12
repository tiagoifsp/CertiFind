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
    public partial class VCadastroTipoAtividade : Form
    {
        MTipoAtividade atual = null;

        public VCadastroTipoAtividade(MTipoAtividade item)
        {
            InitializeComponent();
            item = CTipoAtividade.Obter(item);
            atual = item;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MTipoAtividade item = new MTipoAtividade();

            item.Nome = txtNome.Text.Trim();

            try
            {
                if (atual != null)
                {
                    item.ID = atual.ID;
                    CTipoAtividade.Editar(item);
                    MessageBox.Show("Tipo de dado alterado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CTipoAtividade.Inserir(item);
                    MessageBox.Show("Tipo de dado salvo com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                this.Close();
            }
            catch (ExcecaoPadrao ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show(Erros.ErroGeral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void VTipoAtividade_Load(object sender, EventArgs e)
        {
            if (atual != null)
            {
                this.Text = "Editar tipo de atividade";
            }
            else
            {
                this.Text = "Inserir tipo de atividade";
            }

            try
            {
                if (atual != null)
                {
                    txtNome.Text = atual.Nome;
                }
            }
            catch (ExcecaoPadrao ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show(Erros.ErroGeral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

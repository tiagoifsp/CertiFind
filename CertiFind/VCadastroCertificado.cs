using Model;
using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CertiFind
{
    public partial class VCadastroCertificado : Form
    {
        MCertificado atual = null;

        public VCadastroCertificado(MCertificado item)
        {
            InitializeComponent();
            item = CCertificado.Obter(item);
            atual = item;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool dadosValidos = true;

            if (cboTipoAtividade.SelectedIndex == 0)
            {
                errorProvider.SetError(cboTipoAtividade, Erros.CertificadoCampoTipoAtividade);
                dadosValidos = false;
            }
            else
            {
                errorProvider.SetError(cboTipoAtividade, "");
            }

            if (cboUsuario.SelectedIndex == 0)
            {
                errorProvider.SetError(cboUsuario, Erros.CertificadoCampoUsuario);
                dadosValidos = false;
            }
            else
            {
                errorProvider.SetError(cboUsuario, "");
            }


            if (dadosValidos)
            {
                MCertificado item = new MCertificado();

                try
                {
                    item.UsuarioID = int.Parse(cboUsuario.SelectedValue.ToString());
                }
                catch
                {
                    item.UsuarioID = -1;
                }
                             
                item.TipoAtividadeID = int.Parse(cboTipoAtividade.SelectedValue.ToString());

                try
                {
                    if (atual != null)
                    {
                        item.ID = atual.ID;
                        CCertificado.Editar(item);
                        MessageBox.Show("Certificado alterado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CCertificado.Inserir(item);
                        MessageBox.Show("Certificado salvo com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        }

        private void VCadastroCertificado_Load(object sender, EventArgs e)
        {
            if (atual != null)
            {
                this.Text = "Editar certificado";
            }
            else
            {
                this.Text = "Inserir certificado";
            }

            //Preencher combobox com tipo de atividade
            MTipoAtividade item = new MTipoAtividade();
            item.Nome = "";
            List<MTipoAtividade> lista = CTipoAtividade.Pesquisar(item);

            if (lista == null)
                lista = new List<MTipoAtividade>();

            item.Nome = "[Escolha]";
            lista.Insert(0, item);

            cboTipoAtividade.DataSource = lista;

            //CARREGANDO COMBOBOX MANUALMENTE POIS A DAL E CONTROLLER DE USUÁRIOS NÃO TEM PESQUISA IMPLEMENTADA
            List<MUsuario> UsuariosCBO = new List<MUsuario>();
            MUsuario primeiro = new MUsuario();
            MUsuario admin = new MUsuario();
            primeiro.Nome = "[Escolha]";
            primeiro.ID = 0;
            UsuariosCBO.Add(primeiro);
            admin.Nome = "admin";
            admin.ID = 1;
            UsuariosCBO.Add(admin);

            cboUsuario.DataSource = UsuariosCBO;


            try
            {
                if (atual != null)
                {
                    cboUsuario.SelectedValue = atual.UsuarioID.Value;
                    cboTipoAtividade.SelectedValue = atual.TipoAtividadeID.Value;
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

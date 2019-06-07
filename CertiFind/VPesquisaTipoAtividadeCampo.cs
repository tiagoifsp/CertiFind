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
    public partial class VPesquisaTipoAtividadeCampo : Form
    {
        public VPesquisaTipoAtividadeCampo()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MTipoAtividadeCampo item = new MTipoAtividadeCampo();
            item.CampoID = int.Parse(cboCampo.SelectedValue.ToString());
            item.TipoAtividadeID = int.Parse(cboTipoAtividade.SelectedValue.ToString());
            item.Tamanho = int.Parse(txtTamanho.Text.Trim());
            item.ValorFinal = txtValorFinal.Text.Trim();
            item.ValorInicial = txtValorInicial.Text.Trim();
            
            dgvResultado.DataSource = null;

            try
            {
                dgvResultado.DataSource = CTipoAtividadeCampo.Pesquisar(item);
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

        private void VPesquisaTipoAtividadeCampo_Load(object sender, EventArgs e)
        {
            //Preencher combobox com tipo de atividade
            MTipoAtividade item = new MTipoAtividade();
            item.Nome = "";
            List<MTipoAtividade> lista = CTipoAtividade.Pesquisar(item);

            if (lista == null)
                lista = new List<MTipoAtividade>();

            item.Nome = "[Escolha]";
            lista.Insert(0, item);

            cboTipoAtividade.DataSource = lista;

            //Preencher combobox com os campos
            MCampo itemCampo = new MCampo();
            itemCampo.Nome = "";
            itemCampo.TipoDado = 0;
            List<MCampo> listaCampo = CCampo.Pesquisar(itemCampo);

            if (listaCampo == null)
                listaCampo = new List<MCampo>();

            itemCampo.Nome = "[Escolha]";
            listaCampo.Insert(0, itemCampo);

            cboCampo.DataSource = listaCampo;
        }
    }
}

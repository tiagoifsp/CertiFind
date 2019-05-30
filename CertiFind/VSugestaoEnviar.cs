using Controller;
using DAL;
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
    public partial class VSugestaoEnviar : Form
    {

        List<MTipoSugestao> MTipos = new List<MTipoSugestao>();


        public VSugestaoEnviar()
        {
            InitializeComponent();
        }

        private void btnEnviarSugestão_Click(object sender, EventArgs e)
        {
            MSugestao sugestao = new MSugestao();
            foreach (MTipoSugestao mTipo in MTipos)
            {
                if(mTipo.Nome == cboTipoLista.SelectedItem.ToString())
                {
                    sugestao.FKTipoSugestaoID = mTipo;
                    break;
                }
            }
            sugestao.Texto = rtbOpiniao.Text;
            sugestao.DataEnvio = DateTime.Now;
            if (rdoSim.Checked == true)
            {
                sugestao.FKUsuarioID = VLogin.usuarioAtual;
            }
            CSugestao.EnviarSugestao(sugestao);
            Close();
        }

        private void VSugestaoEnviar_Load(object sender, EventArgs e)
        {
            MTipos = CTipoSugestao.BuscarTipo();

            if (MTipos == null)
                return;

            foreach (MTipoSugestao tipo in MTipos)
            {
                cboTipoLista.Items.Add(tipo.Nome);
            }
        }

        private void rdoSim_CheckedChanged(object sender, EventArgs e)
        {
            btnEnviarSugestão.Enabled = true;
        }

        private void rdoNao_CheckedChanged(object sender, EventArgs e)
        {
            btnEnviarSugestão.Enabled = true;
        }
    }
}
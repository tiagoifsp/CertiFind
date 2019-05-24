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
            if(rdoSim.Checked == true)
            {
                MUsuario usuario = new MUsuario();
                usuario.ID = VLogin.usuarioAtual.ID;
            }
            else
            {
                
            }
        }

        private void VSugestaoEnviar_Load(object sender, EventArgs e)
        {
            MTipos = CSugestao.BuscarTipo();
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
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
    public partial class VSugestaoEnviar : Form
    {
        public VSugestaoEnviar()
        {
            InitializeComponent();
        }

        private void btnEnviarSugestão_Click(object sender, EventArgs e)
        {
            MUsuario usuario_logado = new MUsuario();
            usuario_logado.email = "usuario.logado@email.com";
            usuario_logado.nome = "Generico";
            usuario_logado.senha = "senha";
            usuario_logado.situacao = 'a';
            usuario_logado.tipoUsuario = new MTipoUsuario();
            usuario_logado.tipoUsuario.descricao = "usuario generico";
            usuario_logado.tipoUsuario.nome = "Generico";
            usuario_logado.tipoUsuario.situacao = 'a';

            MSugestao sugestao = new MSugestao();
            sugestao.dataEnvio = DateTime.Now.Date;
            sugestao.texto = rtbOpiniao.Text;
            sugestao.tipoSugestao = cboTipoLista.Text;

            if(rdoSim.Checked == true)
            {
                sugestao.usuario = usuario_logado;
                CSugestao.Enviar(sugestao, true);
            }
            else
            {
                CSugestao.Enviar(sugestao, false);
            }
        }

        private void VSugestaoEnviar_Load(object sender, EventArgs e)
        {
            //cboTipoLista.Items.AddRange(CSugestao.BuscarTipoSugestao());

        }
    }
}
﻿using System;
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
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();


        }

        private void FormTest_Load(object sender, EventArgs e)
        {
            if(VLogin.usuarioAtual != null)
            {
                label2.Text = VLogin.usuarioAtual.Nome + " (" + VLogin.usuarioAtual.ID + ")";
                if( VLogin.usuarioAtual.FKTipoUsuarioID == 2)
                {
                    usuárioToolStripMenuItem.Enabled= false;
                    
                    
                }
            }
        }

        private void criaçãoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VCriacaoUsuario().ShowDialog();
        }

        private void tipoDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VCriacaoTipoUsuario().ShowDialog();
        }

        private void PesquisaDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new VPesquisaUsuario().ShowDialog();
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RecuperarSenhaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new VRecuperarSenha().ShowDialog();
        }
    }
}

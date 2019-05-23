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
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VSugestaoEnviar sugestao = new VSugestaoEnviar();
            sugestao.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new VSugestaoVisualizar().ShowDialog();
        }

    }
}

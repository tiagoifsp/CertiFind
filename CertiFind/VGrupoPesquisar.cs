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
    public partial class VGrupoPesquisar : Form
    {
        public VGrupoPesquisar()
        {
            InitializeComponent();
        }

        private void dgvGrupoPesquisa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tsbPesquisaGrupo_Click(object sender, EventArgs e)
        {
            MGrupoPesquisa item = new MGrupoPesquisa();

           // item.Nome = "";


            dgvGrupoPesquisa.DataSource = CGrupoPesquisa.PesquisaGrupo(item);
        }

        private void tsbEditarGrupo_Click(object sender, EventArgs e)
        {

        }
    }
}
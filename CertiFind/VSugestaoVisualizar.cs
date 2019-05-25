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
    public partial class VSugestaoVisualizar : Form
    {
        List<MTipoSugestao> MTipos = new List<MTipoSugestao>();

        public VSugestaoVisualizar()
        {
            InitializeComponent();
        }

        private void VSugestaoVisualizar_Load(object sender, EventArgs e)
        {
            MTipos = CSugestao.BuscarTipo();
            if (MTipos == null)
                return;

            foreach (MTipoSugestao tipo in MTipos)
            {
                cboTipo.Items.Add(tipo.Nome);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvSugestoes.Columns.Clear();

            dgvSugestoes.DataSource = CSugestao.Pesquisar();
        }
    }
}

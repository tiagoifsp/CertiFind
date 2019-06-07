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
        List<MSugestao> MSugestaos = new List<MSugestao>();

        public VSugestaoVisualizar()
        {
            InitializeComponent();
        }

        private void VSugestaoVisualizar_Load(object sender, EventArgs e)
        {
            MTipos = CTipoSugestao.BuscarTipo();
            if (MTipos == null)
                return;
            int t = 0;
            foreach (MTipoSugestao tipo in MTipos)
            {
                cboTipo.Items.Insert(t, tipo.Nome);
                t += 1;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvSugestoes.DataSource = null;
            if(dtpDataInicial.Checked == false && dtpDataFinal.Checked == false)
            {
                MSugestaos = CSugestao.Pesquisar((Convert.ToInt32(cboTipo.SelectedIndex) + 1));
                dgvSugestoes.DataSource = CSugestao.Pesquisar((Convert.ToInt32(cboTipo.SelectedIndex) + 1));
            }
            else if(dtpDataInicial.Checked == true && dtpDataFinal.Checked == true)
            {
                dgvSugestoes.DataSource = CSugestao.Pesquisar((Convert.ToInt32(cboTipo.SelectedIndex) + 1), dtpDataInicial.Value.ToString("yyyy-MM-dd"), dtpDataFinal.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                if(dtpDataInicial.Checked == true)
                {
                    dgvSugestoes.DataSource = CSugestao.Pesquisar((Convert.ToInt32(cboTipo.SelectedIndex) + 1), true, dtpDataInicial.Value.ToString("yyyy-MM-dd"));
                }
                else
                {
                    dgvSugestoes.DataSource = CSugestao.Pesquisar((Convert.ToInt32(cboTipo.SelectedIndex) + 1), false, dtpDataFinal.Value.ToString("yyyy-MM-dd"));
                }
            }
        }

        private void dgvSugestoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSugestao.Text = CSugestao.Obter((int)dgvSugestoes.Rows[e.RowIndex].Cells[0].Value);
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnPesquisar.Enabled = true;
        }
    }
}

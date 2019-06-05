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
            MTipos = CTipoSugestao.BuscarTipo();
            if (MTipos == null)
                return;

            foreach (MTipoSugestao tipo in MTipos)
            {
                int t = 0;
                cboTipo.Items.Insert(t, tipo.Nome);
                t += 1;
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            dgvSugestoes.DataSource = null;
            if(dtpDataInicial.Checked == false && dtpDataFinal.Checked == false)
            {
                MessageBox.Show("teste");
                dgvSugestoes.DataSource = CSugestao.Pesquisar(Convert.ToInt32(cboTipo.SelectedIndex));
            }
            else if(dtpDataInicial.Checked == true && dtpDataFinal.Checked == true)
            {
                dgvSugestoes.DataSource = CSugestao.Pesquisar((int)cboTipo.SelectedValue, dtpDataInicial.Value.ToString("yyyy-MM-dd"), dtpDataFinal.Value.ToString("yyyy-MM-dd"));
            }
            else
            {
                if(dtpDataInicial.Checked == true)
                {
                    dgvSugestoes.DataSource = CSugestao.Pesquisar((int)cboTipo.SelectedValue, true, dtpDataInicial.Value);
                }
                else
                {
                    dgvSugestoes.DataSource = CSugestao.Pesquisar((int)cboTipo.SelectedValue, false, dtpDataFinal.Value);
                }
            }
        }

        private void dgvSugestoes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSugestao.Text = CSugestao.Obter((int)dgvSugestoes.Rows[e.RowIndex].Cells[0].Value);
        }
    }
}

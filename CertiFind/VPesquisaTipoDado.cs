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

namespace CertiFind {
    public partial class VPesquisaTipoDado : Form {
        public VPesquisaTipoDado() {
            InitializeComponent();
        }

        private void btnInserir_Click(object sender, EventArgs e) {
            Form form = new VCadastroTipoDado(null);
            form.ShowDialog();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MTipoDado item = new MTipoDado();
            item.Nome = txtNome.Text;

            dgvResultado.DataSource = null;

            try
            {
                dgvResultado.DataSource = CTipoDado.Pesquisar(item);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvResultado.SelectedRows != null && dgvResultado.SelectedRows.Count > 0)
            {
                MTipoDado item = new MTipoDado();

                item.ID = int.Parse(dgvResultado.SelectedRows[0].Cells["iDDataGridViewTextBoxColumn"].Value.ToString());

                Form form = new VCadastroTipoDado(item);
                form.ShowDialog();

                item = CTipoDado.Obter(item);

                List<MTipoDado> listaAtual = (List<MTipoDado>)dgvResultado.DataSource;

                for (int i = 0; i < listaAtual.Count; i++)
                {
                    if (listaAtual[i].ID == item.ID)
                    {
                        listaAtual[i] = item;
                        break;
                    }
                }

                dgvResultado.DataSource = listaAtual;
            }
        }

        private void VPesquisaTipoDado_Load(object sender, EventArgs e)
        {
            btnPesquisar_Click(null, null);
        }
    }
}

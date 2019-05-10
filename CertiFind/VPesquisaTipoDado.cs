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


        private void VPesquisaTipoDado_Load(object sender, EventArgs e) {

        }

        private void btnInserir_Click(object sender, EventArgs e) {
            Form frmInserir = new VCadastroTipoDado();
            frmInserir.Show();

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
    }
}

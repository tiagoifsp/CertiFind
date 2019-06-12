using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;
using Model;

namespace CertiFind
{
    public partial class VCadastroGrupoPesquisa : Form
    {
        public VCadastroGrupoPesquisa()
        {
            InitializeComponent();
        }

        private void VCadastroGrupoPesquisa_Load(object sender, EventArgs e)
        {
            List<MUsuario> lider = new List<MUsuario>();
            lider = CGrupoPesquisa.CarregaCombo();

            cbxLider.DataSource = lider;
            cbxLider.DisplayMember = "Nome";
            cbxLider.ValueMember = "ID";
        }

        private void checkFinalizado_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            MGrupoPesquisa item = new MGrupoPesquisa();

            item.Nome = txtNome.Text;
            item.DataInicio = dateInicio.Value;

            if(dateFim.Checked == true)
                item.DataTermino = dateFim.Value;

            item.FKUsuarioID = (Int32)cbxLider.SelectedValue;

            CGrupoPesquisa.Inserir(item);
        }

        private void dateFim_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

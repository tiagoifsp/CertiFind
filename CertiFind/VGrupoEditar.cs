using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace CertiFind
{
    public partial class VGrupoEditar : Form
    {
        MGrupoPesquisa atual = null;
        private MGrupoPesquisa item;

        public VGrupoEditar()
        {
            InitializeComponent();
        }

        public VGrupoEditar(MGrupoPesquisa item)
        {
            atual = item;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
         //   atual.Nome = cboNomeGrupo.ToString();
          // atual.DataInicio = dtpDataInicio.
        }
    }
}

﻿using Controller;
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
    public partial class VCadastroCampo : Form
    {
        MCampo atual = null;

        public VCadastroCampo(MCampo item)
        {
            InitializeComponent();
            item = CCampo.Obter(item);
            atual = item;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool dadosValidos = true;

            if (txtNome.Text.Trim() == "" || txtNome.Text.Length > 100)
            {
                errorProvider.SetError(txtNome, Erros.CampoNome);
                dadosValidos = false;
            }
            else
            {
                errorProvider.SetError(txtNome, "");
            }

            if (cboTipoDado.SelectedIndex == 0)
            {
                errorProvider.SetError(cboTipoDado, Erros.CampoTipoDado);
                dadosValidos = false;
            }
            else
            {
                errorProvider.SetError(cboTipoDado, "");
            }

            if (dadosValidos)
            {
                MCampo item = new MCampo();

                item.Nome = txtNome.Text.Trim();
                item.TipoDado = int.Parse(cboTipoDado.SelectedValue.ToString());

                try
                {
                    if (atual != null)
                    {
                        item.ID = atual.ID;
                        CCampo.Editar(item);
                        MessageBox.Show("Campo alterado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CCampo.Inserir(item);
                        MessageBox.Show("Campo salvo com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                catch (ExcecaoPadrao ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show(Erros.ErroGeral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void VCadastroCampo_Load(object sender, EventArgs e)
        {
            if (atual != null)
            {
                this.Text = "Editar campo";
            }
            else
            {
                this.Text = "Inserir campo";
            }

            MTipoDado item = new MTipoDado();
            item.Nome = "";
            List<MTipoDado> lista = CTipoDado.Pesquisar(item);

            if (lista == null)
                lista = new List<MTipoDado>();

            item.Nome = "[Escolha]";
            lista.Insert(0, item);

            cboTipoDado.DataSource = lista;

            try
            {
                if (atual != null)
                {
                    txtNome.Text = atual.Nome;
                    cboTipoDado.SelectedValue = atual.TipoDado.Value;
                }
            }
            catch (ExcecaoPadrao ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show(Erros.ErroGeral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

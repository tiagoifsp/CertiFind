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
    public partial class VCadastroTipoDado : Form
    {
        MTipoDado atual = null;

        public VCadastroTipoDado(MTipoDado item)
        {
            InitializeComponent();
            item = CTipoDado.Obter(item);
            atual = item;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            bool dadosValidos = true;

            if (txtNome.Text.Trim() == "" || txtNome.Text.Length > 100)
            {
                errorProvider.SetError(txtNome, Erros.TipoDadoNome);
                dadosValidos = false;
            }
            else
            {
                errorProvider.SetError(txtNome, "");
            }

            if (dadosValidos)
            {
                MTipoDado item = new MTipoDado();

                item.Nome = txtNome.Text.Trim();
                item.Descricao = txtDescricao.Text.Trim();

                try
                {
                    if (atual != null)
                    {
                        item.ID = atual.ID;
                        CTipoDado.Editar(item);
                        MessageBox.Show("Tipo de dado alterado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CTipoDado.Inserir(item);
                        MessageBox.Show("Tipo de dado salvo com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormCadastroTipoDado_Load(object sender, EventArgs e)
        {
            if (atual != null)
            {
                this.Text = "Editar tipo de dado";
            }
            else
            {
                this.Text = "Inserir tipo de dado";
            }

            try
            {
                if (atual != null)
                {
                    txtNome.Text = atual.Nome;
                    txtDescricao.Text = atual.Descricao;
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

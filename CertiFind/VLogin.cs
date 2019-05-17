﻿using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertiFind
{
    public partial class VLogin : Form
    {
        private static string Encriptar(String t)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(t);
            SHA256Managed hash = new SHA256Managed();
            return BitConverter.ToString(hash.ComputeHash(bytes)).Replace("-","");                
        }

        public VLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text.Trim() == "")
            {

                MessageBox.Show("Campo E-mail vazio");
                txtEmail.Focus();

            }
            if (txtSenha.Text.Trim() == "")
            {

                MessageBox.Show("Campo Senha vazio");
                txtSenha.Focus();
            }

            MUsuario u = new MUsuario
            {
                Email = txtEmail.Text.ToString(),
                Senha = Encriptar(txtSenha.Text.ToString())
            };
            try
            {
                if (CUsuario.Login(u) == true)
                {
                    new FormTest().ShowDialog();
                }
                else
                {
                    // lbMessage.Text = "Usuario ou senha inválidos";
                    lbRecuperarSenha.Text = "Clique aqui para recuperar senha";
                }
            }
            catch(ExcecaoPadrao ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch
            {
                MessageBox.Show(Erros.ErroGeral);
            }
        }
            
        private void txtSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbSenha_Click(object sender, EventArgs e)
        {

        }

        private void gboxLogin_Enter(object sender, EventArgs e)
        {

        }
    }
}
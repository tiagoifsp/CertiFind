﻿namespace CertiFind
{
    partial class FormTest
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criaçãoDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tipoDeUsuárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recuperarSenhaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem,
            this.recuperarSenhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criaçãoDeUsuárioToolStripMenuItem,
            this.tipoDeUsuárioToolStripMenuItem,
            this.pesquisaDeUsuarioToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // criaçãoDeUsuárioToolStripMenuItem
            // 
            this.criaçãoDeUsuárioToolStripMenuItem.Name = "criaçãoDeUsuárioToolStripMenuItem";
            this.criaçãoDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.criaçãoDeUsuárioToolStripMenuItem.Text = "Criação de Usuário";
            this.criaçãoDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.criaçãoDeUsuárioToolStripMenuItem_Click);
            // 
            // tipoDeUsuárioToolStripMenuItem
            // 
            this.tipoDeUsuárioToolStripMenuItem.Name = "tipoDeUsuárioToolStripMenuItem";
            this.tipoDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.tipoDeUsuárioToolStripMenuItem.Text = "Tipo de Usuário";
            this.tipoDeUsuárioToolStripMenuItem.Click += new System.EventHandler(this.tipoDeUsuárioToolStripMenuItem_Click);
            // 
            // pesquisaDeUsuarioToolStripMenuItem
            // 
            this.pesquisaDeUsuarioToolStripMenuItem.Name = "pesquisaDeUsuarioToolStripMenuItem";
            this.pesquisaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.pesquisaDeUsuarioToolStripMenuItem.Text = "Pesquisa de Usuario";
            this.pesquisaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.PesquisaDeUsuarioToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.SairToolStripMenuItem_Click);
            // 
            // recuperarSenhaToolStripMenuItem
            // 
            this.recuperarSenhaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recuperarSenhaToolStripMenuItem1});
            this.recuperarSenhaToolStripMenuItem.Name = "recuperarSenhaToolStripMenuItem";
            this.recuperarSenhaToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.recuperarSenhaToolStripMenuItem.Text = "Dados Pessoais";
            // 
            // recuperarSenhaToolStripMenuItem1
            // 
            this.recuperarSenhaToolStripMenuItem1.Name = "recuperarSenhaToolStripMenuItem1";
            this.recuperarSenhaToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.recuperarSenhaToolStripMenuItem1.Text = "Recuperar Senha";
            this.recuperarSenhaToolStripMenuItem1.Click += new System.EventHandler(this.RecuperarSenhaToolStripMenuItem1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Usuário atual: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "label2";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.Load += new System.EventHandler(this.FormTest_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criaçãoDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem tipoDeUsuárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recuperarSenhaToolStripMenuItem1;
    }
}
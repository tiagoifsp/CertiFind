﻿namespace CertiFind
{
    partial class VLogin
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
            this.gboxLogin = new System.Windows.Forms.GroupBox();
            this.lbRecuperarSenha = new System.Windows.Forms.Label();
            this.lbMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.gboxLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxLogin
            // 
            this.gboxLogin.Controls.Add(this.lbRecuperarSenha);
            this.gboxLogin.Controls.Add(this.lbMessage);
            this.gboxLogin.Controls.Add(this.btnLogin);
            this.gboxLogin.Controls.Add(this.txtSenha);
            this.gboxLogin.Controls.Add(this.txtEmail);
            this.gboxLogin.Controls.Add(this.lbSenha);
            this.gboxLogin.Controls.Add(this.lbEmail);
            this.gboxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gboxLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gboxLogin.Location = new System.Drawing.Point(12, 12);
            this.gboxLogin.Name = "gboxLogin";
            this.gboxLogin.Size = new System.Drawing.Size(360, 537);
            this.gboxLogin.TabIndex = 0;
            this.gboxLogin.TabStop = false;
            this.gboxLogin.Enter += new System.EventHandler(this.gboxLogin_Enter);
            // 
            // lbRecuperarSenha
            // 
            this.lbRecuperarSenha.AutoSize = true;
            this.lbRecuperarSenha.BackColor = System.Drawing.SystemColors.Control;
            this.lbRecuperarSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRecuperarSenha.ForeColor = System.Drawing.Color.Red;
            this.lbRecuperarSenha.Location = new System.Drawing.Point(92, 515);
            this.lbRecuperarSenha.Name = "lbRecuperarSenha";
            this.lbRecuperarSenha.Size = new System.Drawing.Size(0, 20);
            this.lbRecuperarSenha.TabIndex = 6;
            // 
            // lbMessage
            // 
            this.lbMessage.AutoSize = true;
            this.lbMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(104, 209);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(0, 20);
            this.lbMessage.TabIndex = 5;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.Control;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(23, 198);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(314, 31);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "LOGIN";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(120, 137);
            this.txtSenha.MaxLength = 200;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(217, 26);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.WordWrap = false;
            this.txtSenha.TextChanged += new System.EventHandler(this.txtSenha_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(120, 77);
            this.txtEmail.MaxLength = 200;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(217, 26);
            this.txtEmail.TabIndex = 2;
            // 
            // lbSenha
            // 
            this.lbSenha.AutoSize = true;
            this.lbSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.Location = new System.Drawing.Point(38, 141);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(54, 18);
            this.lbSenha.TabIndex = 1;
            this.lbSenha.Text = "Senha:";
            this.lbSenha.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbSenha.Click += new System.EventHandler(this.lbSenha_Click);
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(43, 81);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(49, 18);
            this.lbEmail.TabIndex = 0;
            this.lbEmail.Text = "Email:";
            this.lbEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // VLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.gboxLogin);
            this.MaximizeBox = false;
            this.Name = "VLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulário de Login";
            this.gboxLogin.ResumeLayout(false);
            this.gboxLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbRecuperarSenha;
    }
}
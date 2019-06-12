namespace CertiFind
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVCadastroTipoDados = new System.Windows.Forms.Button();
            this.btnVPesquisaTipoDados = new System.Windows.Forms.Button();
            this.btnVPesquisaCampo = new System.Windows.Forms.Button();
            this.btnVCadastroCampo = new System.Windows.Forms.Button();
//<<<<<<< RF23
            this.btnGerarRestaurarBackup = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
//=======
            this.btnVCadastroTipoAtividade = new System.Windows.Forms.Button();
            this.btnVPesquisaTipoAtividade = new System.Windows.Forms.Button();
            this.btnVCadastroTipoAtividadeCampo = new System.Windows.Forms.Button();
            this.btnVPesquisaTipoAtividadeCampo = new System.Windows.Forms.Button();
            this.btnPesquisaCertificado = new System.Windows.Forms.Button();
            this.btnCadastroCertificado = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.btncadastrogp = new System.Windows.Forms.Button();
//>>>>>>> master
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuárioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuárioToolStripMenuItem
            // 
            this.usuárioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criaçãoDeUsuárioToolStripMenuItem});
            this.usuárioToolStripMenuItem.Name = "usuárioToolStripMenuItem";
            this.usuárioToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.usuárioToolStripMenuItem.Text = "Usuário";
            // 
            // criaçãoDeUsuárioToolStripMenuItem
            // 
            this.criaçãoDeUsuárioToolStripMenuItem.Name = "criaçãoDeUsuárioToolStripMenuItem";
            this.criaçãoDeUsuárioToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.criaçãoDeUsuárioToolStripMenuItem.Text = "Criação de Usuário";
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
//<<<<<<< RF16-
            // btncadastrogp
            // 
            this.btncadastrogp.Location = new System.Drawing.Point(184, 197);
            this.btncadastrogp.Name = "btncadastrogp";
            this.btncadastrogp.Size = new System.Drawing.Size(171, 23);
            this.btncadastrogp.TabIndex = 1;
            this.btncadastrogp.Text = "cadastro grupo pesquisa";
            this.btncadastrogp.UseVisualStyleBackColor = true;
            this.btncadastrogp.Click += new System.EventHandler(this.btncadastrogp_Click);
//=======
            // btnVCadastroTipoDados
            // 
            this.btnVCadastroTipoDados.Location = new System.Drawing.Point(16, 43);
            this.btnVCadastroTipoDados.Name = "btnVCadastroTipoDados";
            this.btnVCadastroTipoDados.Size = new System.Drawing.Size(143, 23);
            this.btnVCadastroTipoDados.TabIndex = 1;
            this.btnVCadastroTipoDados.Text = "VCadastroTipoDados";
            this.btnVCadastroTipoDados.UseVisualStyleBackColor = true;
            this.btnVCadastroTipoDados.Click += new System.EventHandler(this.btnVCadastroTipoDados_Click);
            // 
            // btnVPesquisaTipoDados
            // 
            this.btnVPesquisaTipoDados.Location = new System.Drawing.Point(16, 72);
            this.btnVPesquisaTipoDados.Name = "btnVPesquisaTipoDados";
            this.btnVPesquisaTipoDados.Size = new System.Drawing.Size(143, 23);
            this.btnVPesquisaTipoDados.TabIndex = 2;
            this.btnVPesquisaTipoDados.Text = "VPesquisaTipoDados";
            this.btnVPesquisaTipoDados.UseVisualStyleBackColor = true;
            this.btnVPesquisaTipoDados.Click += new System.EventHandler(this.btnVPesquisaTipoDados_Click);
            // 
            // btnVPesquisaCampo
            // 
            this.btnVPesquisaCampo.Location = new System.Drawing.Point(16, 130);
            this.btnVPesquisaCampo.Name = "btnVPesquisaCampo";
            this.btnVPesquisaCampo.Size = new System.Drawing.Size(143, 23);
            this.btnVPesquisaCampo.TabIndex = 4;
            this.btnVPesquisaCampo.Text = "VPesquisaCampo";
            this.btnVPesquisaCampo.UseVisualStyleBackColor = true;
            this.btnVPesquisaCampo.Click += new System.EventHandler(this.btnVPesquisaCampo_Click);
            // 
            // btnVCadastroCampo
            // 
            this.btnVCadastroCampo.Location = new System.Drawing.Point(16, 101);
            this.btnVCadastroCampo.Name = "btnVCadastroCampo";
            this.btnVCadastroCampo.Size = new System.Drawing.Size(143, 23);
            this.btnVCadastroCampo.TabIndex = 3;
            this.btnVCadastroCampo.Text = "VCadastroCampo";
            this.btnVCadastroCampo.UseVisualStyleBackColor = true;
            this.btnVCadastroCampo.Click += new System.EventHandler(this.btnVCadastroCampo_Click);
            // 
//<<<<<<< RF23
            // btnGerarRestaurarBackup
            // 
            this.btnGerarRestaurarBackup.Location = new System.Drawing.Point(16, 400);
            this.btnGerarRestaurarBackup.Name = "btnGerarRestaurarBackup";
            this.btnGerarRestaurarBackup.Size = new System.Drawing.Size(143, 23);
            this.btnGerarRestaurarBackup.TabIndex = 5;
            this.btnGerarRestaurarBackup.Text = "Gerar e Restaurar Backup";
            this.btnGerarRestaurarBackup.UseVisualStyleBackColor = true;
            this.btnGerarRestaurarBackup.Click += new System.EventHandler(this.btnGerarRestaurarBackup_Click);
//=======
            // btnVCadastroTipoAtividade
            // 
            this.btnVCadastroTipoAtividade.Location = new System.Drawing.Point(16, 159);
            this.btnVCadastroTipoAtividade.Name = "btnVCadastroTipoAtividade";
            this.btnVCadastroTipoAtividade.Size = new System.Drawing.Size(143, 23);
            this.btnVCadastroTipoAtividade.TabIndex = 5;
            this.btnVCadastroTipoAtividade.Text = "VCadastroTipoAtividade";
            this.btnVCadastroTipoAtividade.UseVisualStyleBackColor = true;
            this.btnVCadastroTipoAtividade.Click += new System.EventHandler(this.btnVCadastroTipoAtividade_Click_1);
            // 
            // btnVPesquisaTipoAtividade
            // 
            this.btnVPesquisaTipoAtividade.Location = new System.Drawing.Point(16, 188);
            this.btnVPesquisaTipoAtividade.Name = "btnVPesquisaTipoAtividade";
            this.btnVPesquisaTipoAtividade.Size = new System.Drawing.Size(143, 23);
            this.btnVPesquisaTipoAtividade.TabIndex = 6;
            this.btnVPesquisaTipoAtividade.Text = "VPesquisaTipoAtividade";
            this.btnVPesquisaTipoAtividade.UseVisualStyleBackColor = true;
            this.btnVPesquisaTipoAtividade.Click += new System.EventHandler(this.btnVPesquisaTipoAtividade_Click);
            // 
            // btnVCadastroTipoAtividadeCampo
            // 
            this.btnVCadastroTipoAtividadeCampo.Location = new System.Drawing.Point(16, 217);
            this.btnVCadastroTipoAtividadeCampo.Name = "btnVCadastroTipoAtividadeCampo";
            this.btnVCadastroTipoAtividadeCampo.Size = new System.Drawing.Size(143, 23);
            this.btnVCadastroTipoAtividadeCampo.TabIndex = 7;
            this.btnVCadastroTipoAtividadeCampo.Text = "VCadastroTipoAtividadeCampo";
            this.btnVCadastroTipoAtividadeCampo.UseVisualStyleBackColor = true;
            this.btnVCadastroTipoAtividadeCampo.Click += new System.EventHandler(this.btnVCadastroTipoAtividadeCampo_Click);
            // 
            // btnVPesquisaTipoAtividadeCampo
            // 
            this.btnVPesquisaTipoAtividadeCampo.Location = new System.Drawing.Point(16, 246);
            this.btnVPesquisaTipoAtividadeCampo.Name = "btnVPesquisaTipoAtividadeCampo";
            this.btnVPesquisaTipoAtividadeCampo.Size = new System.Drawing.Size(143, 23);
            this.btnVPesquisaTipoAtividadeCampo.TabIndex = 8;
            this.btnVPesquisaTipoAtividadeCampo.Text = "VPesquisaTipoAtividadeCampo";
            this.btnVPesquisaTipoAtividadeCampo.UseVisualStyleBackColor = true;
            this.btnVPesquisaTipoAtividadeCampo.Click += new System.EventHandler(this.btnVPesquisaTipoAtividadeCampo_Click);
            // 
            // btnPesquisaCertificado
            // 
            this.btnPesquisaCertificado.Location = new System.Drawing.Point(16, 304);
            this.btnPesquisaCertificado.Name = "btnPesquisaCertificado";
            this.btnPesquisaCertificado.Size = new System.Drawing.Size(143, 23);
            this.btnPesquisaCertificado.TabIndex = 10;
            this.btnPesquisaCertificado.Text = "VPesquisaCertificado";
            this.btnPesquisaCertificado.UseVisualStyleBackColor = true;
            this.btnPesquisaCertificado.Click += new System.EventHandler(this.btnPesquisaCertificado_Click);
            // 
            // btnCadastroCertificado
            // 
            this.btnCadastroCertificado.Location = new System.Drawing.Point(16, 275);
            this.btnCadastroCertificado.Name = "btnCadastroCertificado";
            this.btnCadastroCertificado.Size = new System.Drawing.Size(143, 23);
            this.btnCadastroCertificado.TabIndex = 9;
            this.btnCadastroCertificado.Text = "VCadastroCertificado";
            this.btnCadastroCertificado.UseVisualStyleBackColor = true;
            this.btnCadastroCertificado.Click += new System.EventHandler(this.btnCadastroCertificado_Click);
//>>>>>>> master
//>>>>>>> master
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
//<<<<<<< RF23
            this.Controls.Add(this.btnGerarRestaurarBackup);
//=======
            this.Controls.Add(this.btnPesquisaCertificado);
            this.Controls.Add(this.btnCadastroCertificado);
            this.Controls.Add(this.btnVPesquisaTipoAtividadeCampo);
            this.Controls.Add(this.btnVCadastroTipoAtividadeCampo);
            this.Controls.Add(this.btnVPesquisaTipoAtividade);
            this.Controls.Add(this.btnVCadastroTipoAtividade);
//>>>>>>> master
            this.Controls.Add(this.btnVPesquisaCampo);
            this.Controls.Add(this.btnVCadastroCampo);
            this.Controls.Add(this.btnVPesquisaTipoDados);
            this.Controls.Add(this.btnVCadastroTipoDados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btncadastrogp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
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
//<<<<<<< RF23
//=======
        private System.Windows.Forms.Button btncadastrogp;
        private System.Windows.Forms.Label label2;
//>>>>>>> master
        private System.Windows.Forms.Button btnVCadastroTipoDados;
        private System.Windows.Forms.Button btnVPesquisaTipoDados;
        private System.Windows.Forms.Button btnVPesquisaCampo;
        private System.Windows.Forms.Button btnVCadastroCampo;
//<<<<<<< RF23
        private System.Windows.Forms.Button btnGerarRestaurarBackup;
        public System.Windows.Forms.Label label2;
//=======
        private System.Windows.Forms.Button btnVCadastroTipoAtividade;
        private System.Windows.Forms.Button btnVPesquisaTipoAtividade;
        private System.Windows.Forms.Button btnVCadastroTipoAtividadeCampo;
        private System.Windows.Forms.Button btnVPesquisaTipoAtividadeCampo;
        private System.Windows.Forms.Button btnPesquisaCertificado;
        private System.Windows.Forms.Button btnCadastroCertificado;
//>>>>>>> master
    }
}
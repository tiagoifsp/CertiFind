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
            this.label1 = new System.Windows.Forms.Label();
            this.btnVCadastroTipoDados = new System.Windows.Forms.Button();
            this.btnVPesquisaTipoDados = new System.Windows.Forms.Button();
            this.btnVPesquisaCampo = new System.Windows.Forms.Button();
            this.btnVCadastroCampo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(910, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Form apenas para testes. Utilize para chamar outros formulários. Quando o login f" +
    "uncionar, este formulário deverá ser removido.";
            // 
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
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btnVPesquisaCampo);
            this.Controls.Add(this.btnVCadastroCampo);
            this.Controls.Add(this.btnVPesquisaTipoDados);
            this.Controls.Add(this.btnVCadastroTipoDados);
            this.Controls.Add(this.label1);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVCadastroTipoDados;
        private System.Windows.Forms.Button btnVPesquisaTipoDados;
        private System.Windows.Forms.Button btnVPesquisaCampo;
        private System.Windows.Forms.Button btnVCadastroCampo;
    }
}
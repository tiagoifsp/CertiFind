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
            this.btnVPesquisaTipoDado = new System.Windows.Forms.Button();
            this.btnVCadastroTipoDado = new System.Windows.Forms.Button();
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
            // btnVPesquisaTipoDado
            // 
            this.btnVPesquisaTipoDado.Location = new System.Drawing.Point(16, 74);
            this.btnVPesquisaTipoDado.Name = "btnVPesquisaTipoDado";
            this.btnVPesquisaTipoDado.Size = new System.Drawing.Size(143, 23);
            this.btnVPesquisaTipoDado.TabIndex = 2;
            this.btnVPesquisaTipoDado.Text = "VPesquisaTipoDado";
            this.btnVPesquisaTipoDado.UseVisualStyleBackColor = true;
            this.btnVPesquisaTipoDado.Click += new System.EventHandler(this.btnFormPesquisaTipoDados_Click);
            // 
            // btnVCadastroTipoDado
            // 
            this.btnVCadastroTipoDado.Location = new System.Drawing.Point(16, 45);
            this.btnVCadastroTipoDado.Name = "btnVCadastroTipoDado";
            this.btnVCadastroTipoDado.Size = new System.Drawing.Size(143, 23);
            this.btnVCadastroTipoDado.TabIndex = 3;
            this.btnVCadastroTipoDado.Text = "VCadastroTipoDado";
            this.btnVCadastroTipoDado.UseVisualStyleBackColor = true;
            this.btnVCadastroTipoDado.Click += new System.EventHandler(this.btnVCadastroTipoDado_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btnVCadastroTipoDado);
            this.Controls.Add(this.btnVPesquisaTipoDado);
            this.Controls.Add(this.label1);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVPesquisaTipoDado;
        private System.Windows.Forms.Button btnVCadastroTipoDado;
    }
}
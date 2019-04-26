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
            this.btnFormCadastroTipoDados = new System.Windows.Forms.Button();
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
            // btnFormCadastroTipoDados
            // 
            this.btnFormCadastroTipoDados.Location = new System.Drawing.Point(16, 43);
            this.btnFormCadastroTipoDados.Name = "btnFormCadastroTipoDados";
            this.btnFormCadastroTipoDados.Size = new System.Drawing.Size(143, 23);
            this.btnFormCadastroTipoDados.TabIndex = 1;
            this.btnFormCadastroTipoDados.Text = "FormCadastroTipoDados";
            this.btnFormCadastroTipoDados.UseVisualStyleBackColor = true;
            this.btnFormCadastroTipoDados.Click += new System.EventHandler(this.btnFormCadastroTipoDados_Click);
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 450);
            this.Controls.Add(this.btnFormCadastroTipoDados);
            this.Controls.Add(this.label1);
            this.Name = "FormTest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFormCadastroTipoDados;
    }
}
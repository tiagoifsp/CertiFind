namespace CertiFind
{
    partial class VSugestaoEnviar
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
            this.cboTipoLista = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdoNao = new System.Windows.Forms.RadioButton();
            this.rdoSim = new System.Windows.Forms.RadioButton();
            this.rtbOpiniao = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEnviarSugestão = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboTipoLista
            // 
            this.cboTipoLista.BackColor = System.Drawing.SystemColors.Control;
            this.cboTipoLista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoLista.FormattingEnabled = true;
            this.cboTipoLista.Items.AddRange(new object[] {
            "Crítica",
            "Dúvida",
            "Elogio",
            "Reclamação",
            "Sugestão"});
            this.cboTipoLista.Location = new System.Drawing.Point(12, 27);
            this.cboTipoLista.Name = "cboTipoLista";
            this.cboTipoLista.Size = new System.Drawing.Size(139, 21);
            this.cboTipoLista.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Escolha uma Opção";
            // 
            // rdoNao
            // 
            this.rdoNao.AutoSize = true;
            this.rdoNao.Location = new System.Drawing.Point(54, 19);
            this.rdoNao.Name = "rdoNao";
            this.rdoNao.Size = new System.Drawing.Size(45, 17);
            this.rdoNao.TabIndex = 4;
            this.rdoNao.TabStop = true;
            this.rdoNao.Text = "Não";
            this.rdoNao.UseVisualStyleBackColor = true;
            // 
            // rdoSim
            // 
            this.rdoSim.AutoSize = true;
            this.rdoSim.Location = new System.Drawing.Point(6, 19);
            this.rdoSim.Name = "rdoSim";
            this.rdoSim.Size = new System.Drawing.Size(42, 17);
            this.rdoSim.TabIndex = 3;
            this.rdoSim.TabStop = true;
            this.rdoSim.Text = "Sim";
            this.rdoSim.UseVisualStyleBackColor = true;
            // 
            // rtbOpiniao
            // 
            this.rtbOpiniao.Location = new System.Drawing.Point(12, 67);
            this.rtbOpiniao.Name = "rtbOpiniao";
            this.rtbOpiniao.Size = new System.Drawing.Size(692, 292);
            this.rtbOpiniao.TabIndex = 2;
            this.rtbOpiniao.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(9, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Deixe sua Opinião aqui";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoNao);
            this.groupBox1.Controls.Add(this.rdoSim);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(12, 365);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 43);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Deseja se Identificar";
            // 
            // btnEnviarSugestão
            // 
            this.btnEnviarSugestão.Enabled = false;
            this.btnEnviarSugestão.Location = new System.Drawing.Point(579, 385);
            this.btnEnviarSugestão.Name = "btnEnviarSugestão";
            this.btnEnviarSugestão.Size = new System.Drawing.Size(125, 23);
            this.btnEnviarSugestão.TabIndex = 5;
            this.btnEnviarSugestão.Text = "Enviar";
            this.btnEnviarSugestão.UseVisualStyleBackColor = true;
            this.btnEnviarSugestão.Click += new System.EventHandler(this.btnEnviarSugestão_Click);
            // 
            // VSugestaoEnviar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 413);
            this.Controls.Add(this.btnEnviarSugestão);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rtbOpiniao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTipoLista);
            this.MaximizeBox = false;
            this.Name = "VSugestaoEnviar";
            this.ShowIcon = false;
            this.Text = "Sugestao";
            this.Load += new System.EventHandler(this.VSugestaoEnviar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoNao;
        private System.Windows.Forms.RadioButton rdoSim;
        private System.Windows.Forms.RichTextBox rtbOpiniao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEnviarSugestão;
    }
}
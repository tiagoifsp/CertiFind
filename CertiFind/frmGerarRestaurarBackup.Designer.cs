namespace CertiFind
{
    partial class frmGerarRestaurarBackup
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
            this.dgvGerarRestaurarBackup = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.colNomeArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestaurar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerarRestaurarBackup)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGerarRestaurarBackup
            // 
            this.dgvGerarRestaurarBackup.AllowUserToAddRows = false;
            this.dgvGerarRestaurarBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvGerarRestaurarBackup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGerarRestaurarBackup.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNomeArquivo,
            this.colRestaurar});
            this.dgvGerarRestaurarBackup.Location = new System.Drawing.Point(12, 12);
            this.dgvGerarRestaurarBackup.Name = "dgvGerarRestaurarBackup";
            this.dgvGerarRestaurarBackup.Size = new System.Drawing.Size(685, 426);
            this.dgvGerarRestaurarBackup.TabIndex = 0;
            this.dgvGerarRestaurarBackup.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGerarRestaurarBackup_CellMouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colNomeArquivo
            // 
            this.colNomeArquivo.HeaderText = "Nome do Arquivo";
            this.colNomeArquivo.Name = "colNomeArquivo";
            this.colNomeArquivo.Width = 500;
            // 
            // colRestaurar
            // 
            this.colRestaurar.HeaderText = "Restaurar";
            this.colRestaurar.Name = "colRestaurar";
            // 
            // frmGerarRestaurarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGerarRestaurarBackup);
            this.Name = "frmGerarRestaurarBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.frmGerarRestaurarBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerarRestaurarBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGerarRestaurarBackup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeArquivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRestaurar;
    }
}
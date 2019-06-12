namespace CertiFind
{
    partial class VGerarRestaurarBackup
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
            this.btnGerarBackup = new System.Windows.Forms.Button();
            this.colNomeArquivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRestaurar = new System.Windows.Forms.DataGridViewImageColumn();
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
            // btnGerarBackup
            // 
            this.btnGerarBackup.Location = new System.Drawing.Point(713, 12);
            this.btnGerarBackup.Name = "btnGerarBackup";
            this.btnGerarBackup.Size = new System.Drawing.Size(75, 51);
            this.btnGerarBackup.TabIndex = 1;
            this.btnGerarBackup.Text = "Gerar Backup";
            this.btnGerarBackup.UseVisualStyleBackColor = true;
            this.btnGerarBackup.Click += new System.EventHandler(this.btnGerarBackup_Click);
            // 
            // colNomeArquivo
            // 
            this.colNomeArquivo.HeaderText = "Nome do Arquivo";
            this.colNomeArquivo.Name = "colNomeArquivo";
            this.colNomeArquivo.Width = 500;
            // 
            // colRestaurar
            // 
            this.colRestaurar.HeaderText = "";
            this.colRestaurar.Image = global::CertiFind.Properties.Resources.Data_Database_Restore;
            this.colRestaurar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.colRestaurar.Name = "colRestaurar";
            this.colRestaurar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colRestaurar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.colRestaurar.Width = 50;
            // 
            // VGerarRestaurarBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGerarBackup);
            this.Controls.Add(this.dgvGerarRestaurarBackup);
            this.Name = "VGerarRestaurarBackup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Backup";
            this.Load += new System.EventHandler(this.frmGerarRestaurarBackup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGerarRestaurarBackup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGerarRestaurarBackup;
        private System.Windows.Forms.Button btnGerarBackup;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNomeArquivo;
        private System.Windows.Forms.DataGridViewImageColumn colRestaurar;
    }
}
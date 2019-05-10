namespace CertiFind
{
    partial class VPesquisaTipoDado
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
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbBotoes = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnRemover = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.tbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(12, 53);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(367, 211);
            this.dgvResultado.TabIndex = 11;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(282, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(53, 27);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(223, 20);
            this.txtNome.TabIndex = 7;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 30);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome";
            // 
            // tbBotoes
            // 
            this.tbBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnRemover});
            this.tbBotoes.Location = new System.Drawing.Point(0, 0);
            this.tbBotoes.Name = "tbBotoes";
            this.tbBotoes.Size = new System.Drawing.Size(389, 25);
            this.tbBotoes.TabIndex = 12;
            this.tbBotoes.Text = "toolStrip1";
            // 
            // btnInserir
            // 
            this.btnInserir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInserir.Image = global::CertiFind.Properties.Resources.circularplusbutton_121982;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(23, 22);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = global::CertiFind.Properties.Resources.inclinedpencil_122017;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            // 
            // btnRemover
            // 
            this.btnRemover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemover.Enabled = false;
            this.btnRemover.Image = global::CertiFind.Properties.Resources.biggarbagebin_121980;
            this.btnRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(23, 22);
            this.btnRemover.Text = "Remover";
            // 
            // VPesquisaTipoDado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 273);
            this.Controls.Add(this.tbBotoes);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(405, 312);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(405, 312);
            this.Name = "VPesquisaTipoDado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar tipo de dado";
            this.Load += new System.EventHandler(this.VPesquisaTipoDado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.tbBotoes.ResumeLayout(false);
            this.tbBotoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ToolStrip tbBotoes;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnRemover;
    }
}
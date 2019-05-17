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
            this.components = new System.ComponentModel.Container();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTipoDadoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.tbBotoes = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnRemover = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTipoDadoBindingSource)).BeginInit();
            this.tbBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvResultado
            // 
            this.dgvResultado.AllowUserToAddRows = false;
            this.dgvResultado.AllowUserToDeleteRows = false;
            this.dgvResultado.AllowUserToResizeColumns = false;
            this.dgvResultado.AllowUserToResizeRows = false;
            this.dgvResultado.AutoGenerateColumns = false;
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn});
            this.dgvResultado.DataSource = this.mTipoDadoBindingSource;
            this.dgvResultado.Location = new System.Drawing.Point(12, 53);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(367, 211);
            this.dgvResultado.TabIndex = 11;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // mTipoDadoBindingSource
            // 
            this.mTipoDadoBindingSource.DataSource = typeof(Model.MTipoDado);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(282, 25);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(97, 23);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.btnInserir.Image = global::CertiFind.Properties.Resources.inserir;
            this.btnInserir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(23, 22);
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::CertiFind.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRemover.Image = global::CertiFind.Properties.Resources.remover;
            this.btnRemover.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(23, 22);
            this.btnRemover.Text = "Remover";
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTipoDadoBindingSource)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mTipoDadoBindingSource;
    }
}
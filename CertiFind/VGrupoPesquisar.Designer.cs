namespace CertiFind
{
    partial class VGrupoPesquisar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VGrupoPesquisar));
            this.dgvGrupoPesquisa = new System.Windows.Forms.DataGridView();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataTermino = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mGrupoPesquisaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbPesquisaGrupo = new System.Windows.Forms.ToolStripButton();
            this.tsbEditarGrupo = new System.Windows.Forms.ToolStripButton();
            this.mGrupoPesquisaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mGrupoPesquisaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoPesquisa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrupoPesquisaBindingSource2)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGrupoPesquisaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrupoPesquisaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGrupoPesquisa
            // 
            this.dgvGrupoPesquisa.AllowUserToAddRows = false;
            this.dgvGrupoPesquisa.AllowUserToDeleteRows = false;
            this.dgvGrupoPesquisa.AllowUserToResizeColumns = false;
            this.dgvGrupoPesquisa.AllowUserToResizeRows = false;
            this.dgvGrupoPesquisa.AutoGenerateColumns = false;
            this.dgvGrupoPesquisa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrupoPesquisa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrupoPesquisa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.DataInicio,
            this.DataTermino});
            this.dgvGrupoPesquisa.DataSource = this.mGrupoPesquisaBindingSource2;
            this.dgvGrupoPesquisa.Location = new System.Drawing.Point(12, 28);
            this.dgvGrupoPesquisa.MultiSelect = false;
            this.dgvGrupoPesquisa.Name = "dgvGrupoPesquisa";
            this.dgvGrupoPesquisa.ReadOnly = true;
            this.dgvGrupoPesquisa.RowHeadersVisible = false;
            this.dgvGrupoPesquisa.Size = new System.Drawing.Size(604, 273);
            this.dgvGrupoPesquisa.TabIndex = 0;
            this.dgvGrupoPesquisa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrupoPesquisa_CellContentClick);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // DataInicio
            // 
            this.DataInicio.DataPropertyName = "DataInicio";
            this.DataInicio.HeaderText = "DataInicio";
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.ReadOnly = true;
            // 
            // DataTermino
            // 
            this.DataTermino.DataPropertyName = "DataTermino";
            this.DataTermino.HeaderText = "DataTermino";
            this.DataTermino.Name = "DataTermino";
            this.DataTermino.ReadOnly = true;
            // 
            // mGrupoPesquisaBindingSource2
            // 
            this.mGrupoPesquisaBindingSource2.DataSource = typeof(Model.MGrupoPesquisa);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbPesquisaGrupo,
            this.tsbEditarGrupo});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(628, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbPesquisaGrupo
            // 
            this.tsbPesquisaGrupo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbPesquisaGrupo.Image = global::CertiFind.Properties.Resources.search;
            this.tsbPesquisaGrupo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPesquisaGrupo.Name = "tsbPesquisaGrupo";
            this.tsbPesquisaGrupo.Size = new System.Drawing.Size(23, 22);
            this.tsbPesquisaGrupo.Text = "tsbPesquisar";
            this.tsbPesquisaGrupo.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.tsbPesquisaGrupo.Click += new System.EventHandler(this.tsbPesquisaGrupo_Click);
            // 
            // tsbEditarGrupo
            // 
            this.tsbEditarGrupo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditarGrupo.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditarGrupo.Image")));
            this.tsbEditarGrupo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditarGrupo.Name = "tsbEditarGrupo";
            this.tsbEditarGrupo.Size = new System.Drawing.Size(23, 22);
            this.tsbEditarGrupo.Text = "Editar";
            this.tsbEditarGrupo.Click += new System.EventHandler(this.tsbEditarGrupo_Click);
            // 
            // mGrupoPesquisaBindingSource
            // 
            this.mGrupoPesquisaBindingSource.DataSource = typeof(Model.MGrupoPesquisa);
            // 
            // mGrupoPesquisaBindingSource1
            // 
            this.mGrupoPesquisaBindingSource1.DataSource = typeof(Model.MGrupoPesquisa);
            // 
            // VGrupoPesquisar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(628, 316);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvGrupoPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VGrupoPesquisar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Grupo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrupoPesquisa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrupoPesquisaBindingSource2)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mGrupoPesquisaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mGrupoPesquisaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGrupoPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataTerminoDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mGrupoPesquisaBindingSource;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbPesquisaGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataTermino;
        private System.Windows.Forms.BindingSource mGrupoPesquisaBindingSource2;
        private System.Windows.Forms.BindingSource mGrupoPesquisaBindingSource1;
        private System.Windows.Forms.ToolStripButton tsbEditarGrupo;
    }
}
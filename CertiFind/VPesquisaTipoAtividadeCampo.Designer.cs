namespace CertiFind
{
    partial class VPesquisaTipoAtividadeCampo
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
            this.tbBotoes = new System.Windows.Forms.ToolStrip();
            this.btnInserir = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.campoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoAtividadeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tamanhoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorInicialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorFinalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mTipoAtividadeCampoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTipoAtividade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTipoAtividadeCampoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBotoes
            // 
            this.tbBotoes.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInserir,
            this.btnEditar,
            this.btnExcluir});
            this.tbBotoes.Location = new System.Drawing.Point(0, 0);
            this.tbBotoes.Name = "tbBotoes";
            this.tbBotoes.Size = new System.Drawing.Size(522, 25);
            this.tbBotoes.TabIndex = 0;
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
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::CertiFind.Properties.Resources.editar;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            // 
            // btnExcluir
            // 
            this.btnExcluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExcluir.Image = global::CertiFind.Properties.Resources.remover;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(23, 22);
            this.btnExcluir.Text = "Excluir";
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
            this.campoIDDataGridViewTextBoxColumn,
            this.tipoAtividadeIDDataGridViewTextBoxColumn,
            this.tamanhoDataGridViewTextBoxColumn,
            this.valorInicialDataGridViewTextBoxColumn,
            this.valorFinalDataGridViewTextBoxColumn});
            this.dgvResultado.DataSource = this.mTipoAtividadeCampoBindingSource;
            this.dgvResultado.Location = new System.Drawing.Point(15, 90);
            this.dgvResultado.MultiSelect = false;
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.ReadOnly = true;
            this.dgvResultado.RowHeadersVisible = false;
            this.dgvResultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResultado.Size = new System.Drawing.Size(496, 236);
            this.dgvResultado.TabIndex = 7;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Visible = false;
            // 
            // campoIDDataGridViewTextBoxColumn
            // 
            this.campoIDDataGridViewTextBoxColumn.DataPropertyName = "CampoID";
            this.campoIDDataGridViewTextBoxColumn.HeaderText = "Nome Campo";
            this.campoIDDataGridViewTextBoxColumn.Name = "campoIDDataGridViewTextBoxColumn";
            this.campoIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoAtividadeIDDataGridViewTextBoxColumn
            // 
            this.tipoAtividadeIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoAtividadeIDDataGridViewTextBoxColumn.DataPropertyName = "TipoAtividadeID";
            this.tipoAtividadeIDDataGridViewTextBoxColumn.HeaderText = "Tipo Atividade";
            this.tipoAtividadeIDDataGridViewTextBoxColumn.Name = "tipoAtividadeIDDataGridViewTextBoxColumn";
            this.tipoAtividadeIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tamanhoDataGridViewTextBoxColumn
            // 
            this.tamanhoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tamanhoDataGridViewTextBoxColumn.DataPropertyName = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.HeaderText = "Tamanho";
            this.tamanhoDataGridViewTextBoxColumn.Name = "tamanhoDataGridViewTextBoxColumn";
            this.tamanhoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorInicialDataGridViewTextBoxColumn
            // 
            this.valorInicialDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorInicialDataGridViewTextBoxColumn.DataPropertyName = "ValorInicial";
            this.valorInicialDataGridViewTextBoxColumn.HeaderText = "Valor Inicial";
            this.valorInicialDataGridViewTextBoxColumn.Name = "valorInicialDataGridViewTextBoxColumn";
            this.valorInicialDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // valorFinalDataGridViewTextBoxColumn
            // 
            this.valorFinalDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.valorFinalDataGridViewTextBoxColumn.DataPropertyName = "ValorFinal";
            this.valorFinalDataGridViewTextBoxColumn.HeaderText = "Valor Final";
            this.valorFinalDataGridViewTextBoxColumn.Name = "valorFinalDataGridViewTextBoxColumn";
            this.valorFinalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mTipoAtividadeCampoBindingSource
            // 
            this.mTipoAtividadeCampoBindingSource.DataSource = typeof(Model.MTipoAtividadeCampo);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(409, 55);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(102, 23);
            this.btnPesquisar.TabIndex = 6;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(458, 29);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(53, 20);
            this.txtTamanho.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(406, 32);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(52, 13);
            this.lblNome.TabIndex = 16;
            this.lblNome.Text = "Tamanho";
            // 
            // cboCampo
            // 
            this.cboCampo.DisplayMember = "Nome";
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(70, 28);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 1;
            this.cboCampo.ValueMember = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Campo";
            // 
            // cboTipoAtividade
            // 
            this.cboTipoAtividade.DisplayMember = "Nome";
            this.cboTipoAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAtividade.FormattingEnabled = true;
            this.cboTipoAtividade.Location = new System.Drawing.Point(278, 28);
            this.cboTipoAtividade.Name = "cboTipoAtividade";
            this.cboTipoAtividade.Size = new System.Drawing.Size(121, 21);
            this.cboTipoAtividade.TabIndex = 2;
            this.cboTipoAtividade.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tipo Atividade";
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Location = new System.Drawing.Point(70, 58);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(121, 20);
            this.txtValorInicial.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Valor Inicial";
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(278, 58);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(121, 20);
            this.txtValorFinal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Valor Final";
            // 
            // VPesquisaTipoAtividadeCampo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 336);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtValorInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoAtividade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbBotoes);
            this.Controls.Add(this.dgvResultado);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.lblNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(538, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(538, 375);
            this.Name = "VPesquisaTipoAtividadeCampo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar relacionamentos";
            this.tbBotoes.ResumeLayout(false);
            this.tbBotoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTipoAtividadeCampoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tbBotoes;
        private System.Windows.Forms.ToolStripButton btnInserir;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTipoAtividade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValorInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValorFinal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn campoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoAtividadeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tamanhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorInicialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorFinalDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource mTipoAtividadeCampoBindingSource;
    }
}
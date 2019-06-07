namespace CertiFind
{
    partial class VGrupoEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VGrupoEditar));
            this.Nome = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNomeGrupo = new System.Windows.Forms.ComboBox();
            this.dtpDataInicio = new System.Windows.Forms.DateTimePicker();
            this.dtpDataTermino = new System.Windows.Forms.DateTimePicker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.Location = new System.Drawing.Point(34, 52);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(82, 13);
            this.Nome.TabIndex = 0;
            this.Nome.Text = "Nome do Grupo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data Témino";
            // 
            // cboNomeGrupo
            // 
            this.cboNomeGrupo.FormattingEnabled = true;
            this.cboNomeGrupo.Location = new System.Drawing.Point(120, 46);
            this.cboNomeGrupo.Name = "cboNomeGrupo";
            this.cboNomeGrupo.Size = new System.Drawing.Size(243, 21);
            this.cboNomeGrupo.TabIndex = 3;
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.Location = new System.Drawing.Point(120, 87);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.Size = new System.Drawing.Size(243, 20);
            this.dtpDataInicio.TabIndex = 4;
            // 
            // dtpDataTermino
            // 
            this.dtpDataTermino.Location = new System.Drawing.Point(120, 120);
            this.dtpDataTermino.Name = "dtpDataTermino";
            this.dtpDataTermino.Size = new System.Drawing.Size(243, 20);
            this.dtpDataTermino.TabIndex = 5;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(42, 181);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(321, 23);
            this.btnSalvar.TabIndex = 6;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnE_Click);
            // 
            // VGrupoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 256);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.dtpDataTermino);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.cboNomeGrupo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VGrupoEditar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Grupo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNomeGrupo;
        private System.Windows.Forms.DateTimePicker dtpDataInicio;
        private System.Windows.Forms.DateTimePicker dtpDataTermino;
        private System.Windows.Forms.Button btnSalvar;
    }
}
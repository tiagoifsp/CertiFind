using Controller;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertiFind
{
    public partial class VCadastroTipoAtividadeCampo : Form
    {
        private Label label1;
        private ComboBox cboCampo;
        private ComboBox cboTipoAtividade;
        private Label label2;
        private Label label3;
        private TextBox txtTamanho;
        private TextBox txtValorInicial;
        private Label label4;
        private TextBox txtValorFinal;
        private Label label5;
        private Button btnSalvar;
        private ErrorProvider errorProvider;
        private IContainer components;
        MTipoAtividadeCampo atual = null;

        public VCadastroTipoAtividadeCampo(MTipoAtividadeCampo item)
        {
            InitializeComponent();
            item = CTipoAtividadeCampo.Obter(item);
            atual = item;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            bool dadosValidos = true;

            if (cboCampo.SelectedIndex == 0)
            {
                errorProvider.SetError(cboCampo, Erros.AtividadeCampoCampo);
                dadosValidos = false;
            }
            else
            {
                errorProvider.SetError(cboCampo, "");
            }

            if (cboTipoAtividade.SelectedIndex == 0)
            {
                errorProvider.SetError(cboTipoAtividade, Erros.AtividadeCampoTipoAtividade);
                dadosValidos = false;
            }
            else
            {
                errorProvider.SetError(cboTipoAtividade, "");
            }

            if (dadosValidos)
            {
                MTipoAtividadeCampo item = new MTipoAtividadeCampo();

                item.CampoID = int.Parse(cboCampo.SelectedValue.ToString());
                item.TipoAtividadeID = int.Parse(cboTipoAtividade.SelectedValue.ToString());

                if (txtTamanho.Text != "")
                {
                    try
                    {
                        item.Tamanho = int.Parse(txtTamanho.Text.ToString());
                    }
                    catch
                    {
                        MessageBox.Show(Erros.AtividadeCampoTamanho, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

                item.ValorInicial = txtValorInicial.Text.Trim();
                item.ValorFinal = txtValorFinal.Text.Trim();

                try
                {
                    if (atual != null)
                    {
                        item.ID = atual.ID;
                        CTipoAtividadeCampo.Editar(item);
                        MessageBox.Show("Relacionamento alterado com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        CTipoAtividadeCampo.Inserir(item);
                        MessageBox.Show("Relacionamento salvo com sucesso.", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.Close();
                }
                catch (ExcecaoPadrao ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    MessageBox.Show(Erros.ErroGeral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Load
        private void VCadastroTipoAtividadeCampo_Load_1(object sender, EventArgs e)
        {
            if (atual != null)
            {
                this.Text = "Editar relacionamento";
            }
            else
            {
                this.Text = "Inserir relacionamento";
            }

            //Preencher combobox com tipo de atividade
            MTipoAtividade item = new MTipoAtividade();
            item.Nome = "";
            List<MTipoAtividade> lista = CTipoAtividade.Pesquisar(item);

            if (lista == null)
                lista = new List<MTipoAtividade>();

            item.Nome = "[Escolha]";
            lista.Insert(0, item);

            cboTipoAtividade.DataSource = lista;

            //Preencher combobox com os campos
            MCampo itemCampo = new MCampo();
            itemCampo.Nome = "";
            itemCampo.TipoDado = 0;
            List<MCampo> listaCampo = CCampo.Pesquisar(itemCampo);

            if (listaCampo == null)
                listaCampo = new List<MCampo>();

            itemCampo.Nome = "[Escolha]";
            listaCampo.Insert(0, itemCampo);

            cboCampo.DataSource = listaCampo;

            try
            {
                if (atual != null)
                {
                    cboCampo.SelectedValue = atual.CampoID.Value;
                    cboTipoAtividade.SelectedValue = atual.TipoAtividadeID.Value;
                }
            }
            catch (ExcecaoPadrao ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show(Erros.ErroGeral, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.cboTipoAtividade = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.txtValorInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValorFinal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Campo";
            // 
            // cboCampo
            // 
            this.cboCampo.DisplayMember = "Nome";
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Location = new System.Drawing.Point(120, 12);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(184, 21);
            this.cboCampo.TabIndex = 1;
            this.cboCampo.ValueMember = "ID";
            // 
            // cboTipoAtividade
            // 
            this.cboTipoAtividade.DisplayMember = "Nome";
            this.cboTipoAtividade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoAtividade.FormattingEnabled = true;
            this.cboTipoAtividade.Location = new System.Drawing.Point(120, 49);
            this.cboTipoAtividade.Name = "cboTipoAtividade";
            this.cboTipoAtividade.Size = new System.Drawing.Size(184, 21);
            this.cboTipoAtividade.TabIndex = 3;
            this.cboTipoAtividade.ValueMember = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Atividade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tamanho";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(120, 84);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(184, 20);
            this.txtTamanho.TabIndex = 5;
            // 
            // txtValorInicial
            // 
            this.txtValorInicial.Location = new System.Drawing.Point(120, 120);
            this.txtValorInicial.Name = "txtValorInicial";
            this.txtValorInicial.Size = new System.Drawing.Size(184, 20);
            this.txtValorInicial.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Valor Inicial";
            // 
            // txtValorFinal
            // 
            this.txtValorFinal.Location = new System.Drawing.Point(120, 157);
            this.txtValorFinal.Name = "txtValorFinal";
            this.txtValorFinal.Size = new System.Drawing.Size(184, 20);
            this.txtValorFinal.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Valor Final";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(229, 183);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 10;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // VCadastroTipoAtividadeCampo
            // 
            this.ClientSize = new System.Drawing.Size(335, 225);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtValorFinal);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtValorInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoAtividade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboCampo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(351, 264);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(351, 264);
            this.Name = "VCadastroTipoAtividadeCampo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.VCadastroTipoAtividadeCampo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

    }
}


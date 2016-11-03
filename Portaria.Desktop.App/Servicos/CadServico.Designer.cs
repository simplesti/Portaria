namespace Portaria.Servicos
{
    partial class CadServico
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
            this.txtObs = new System.Windows.Forms.TextBox();
            this.bsContatoServico = new System.Windows.Forms.BindingSource(this.components);
            this.lblTipoServico = new MaterialSkin.Controls.MaterialLabel();
            this.cboTipoServico = new System.Windows.Forms.ComboBox();
            this.lblObs = new MaterialSkin.Controls.MaterialLabel();
            this.txtTelefone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTelefone = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtEndereco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblEndereco = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblNome = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnExcluir = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContatoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.btnExcluir);
            this.pnlConteudo.Controls.Add(this.btnCancelar);
            this.pnlConteudo.Controls.Add(this.txtObs);
            this.pnlConteudo.Controls.Add(this.lblTipoServico);
            this.pnlConteudo.Controls.Add(this.cboTipoServico);
            this.pnlConteudo.Controls.Add(this.lblObs);
            this.pnlConteudo.Controls.Add(this.txtTelefone);
            this.pnlConteudo.Controls.Add(this.lblTelefone);
            this.pnlConteudo.Controls.Add(this.btnSalvar);
            this.pnlConteudo.Controls.Add(this.txtEndereco);
            this.pnlConteudo.Controls.Add(this.lblEndereco);
            this.pnlConteudo.Controls.Add(this.txtNome);
            this.pnlConteudo.Controls.Add(this.lblNome);
            this.pnlConteudo.Size = new System.Drawing.Size(629, 250);
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContatoServico, "Observacao", true));
            this.txtObs.Location = new System.Drawing.Point(16, 122);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObs.Size = new System.Drawing.Size(602, 59);
            this.txtObs.TabIndex = 39;
            // 
            // bsContatoServico
            // 
            this.bsContatoServico.DataSource = typeof(Portaria.Core.Model.ContatoServico);
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Depth = 0;
            this.lblTipoServico.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoServico.Location = new System.Drawing.Point(419, 0);
            this.lblTipoServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(113, 19);
            this.lblTipoServico.TabIndex = 38;
            this.lblTipoServico.Text = "Tipo de Serviço";
            // 
            // cboTipoServico
            // 
            this.cboTipoServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoServico.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsContatoServico, "TipoServico", true));
            this.cboTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoServico.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoServico.FormattingEnabled = true;
            this.cboTipoServico.Location = new System.Drawing.Point(423, 22);
            this.cboTipoServico.Name = "cboTipoServico";
            this.cboTipoServico.Size = new System.Drawing.Size(195, 27);
            this.cboTipoServico.TabIndex = 37;
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Depth = 0;
            this.lblObs.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObs.Location = new System.Drawing.Point(12, 100);
            this.lblObs.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(88, 19);
            this.lblObs.TabIndex = 36;
            this.lblObs.Text = "Observação";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTelefone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContatoServico, "Telefone", true));
            this.txtTelefone.Depth = 0;
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Hint = "";
            this.txtTelefone.Location = new System.Drawing.Point(423, 74);
            this.txtTelefone.Mask = "";
            this.txtTelefone.MaxLength = 32767;
            this.txtTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PasswordChar = '\0';
            this.txtTelefone.SelectedText = "";
            this.txtTelefone.SelectionLength = 0;
            this.txtTelefone.SelectionStart = 0;
            this.txtTelefone.Size = new System.Drawing.Size(195, 23);
            this.txtTelefone.TabIndex = 34;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.UseSystemPasswordChar = false;
            // 
            // lblTelefone
            // 
            this.lblTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Depth = 0;
            this.lblTelefone.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTelefone.Location = new System.Drawing.Point(419, 52);
            this.lblTelefone.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(68, 19);
            this.lblTelefone.TabIndex = 33;
            this.lblTelefone.Text = "Telefone";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(545, 198);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEndereco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContatoServico, "Endereco", true));
            this.txtEndereco.Depth = 0;
            this.txtEndereco.Hint = "";
            this.txtEndereco.Location = new System.Drawing.Point(16, 74);
            this.txtEndereco.Mask = "";
            this.txtEndereco.MaxLength = 32767;
            this.txtEndereco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.PasswordChar = '\0';
            this.txtEndereco.SelectedText = "";
            this.txtEndereco.SelectionLength = 0;
            this.txtEndereco.SelectionStart = 0;
            this.txtEndereco.Size = new System.Drawing.Size(389, 23);
            this.txtEndereco.TabIndex = 31;
            this.txtEndereco.TabStop = false;
            this.txtEndereco.UseSystemPasswordChar = false;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Depth = 0;
            this.lblEndereco.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEndereco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEndereco.Location = new System.Drawing.Point(12, 52);
            this.lblEndereco.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(72, 19);
            this.lblEndereco.TabIndex = 30;
            this.lblEndereco.Text = "Endereço";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsContatoServico, "Nome", true));
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(16, 22);
            this.txtNome.Mask = "";
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(389, 23);
            this.txtNome.TabIndex = 29;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Depth = 0;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(12, 0);
            this.lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 28;
            this.lblNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(446, 198);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AutoSize = true;
            this.btnExcluir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnExcluir.Depth = 0;
            this.btnExcluir.Icon = null;
            this.btnExcluir.Location = new System.Drawing.Point(16, 198);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnExcluir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Primary = false;
            this.btnExcluir.Size = new System.Drawing.Size(75, 36);
            this.btnExcluir.TabIndex = 41;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // CadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 316);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 316);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(630, 316);
            this.Name = "CadServico";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Cadastro de Serviço";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsContatoServico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtObs;
        private MaterialSkin.Controls.MaterialLabel lblTipoServico;
        private System.Windows.Forms.ComboBox cboTipoServico;
        private MaterialSkin.Controls.MaterialLabel lblObs;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTelefone;
        private MaterialSkin.Controls.MaterialLabel lblTelefone;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEndereco;
        private MaterialSkin.Controls.MaterialLabel lblEndereco;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialLabel lblNome;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private System.Windows.Forms.BindingSource bsContatoServico;
        private MaterialSkin.Controls.MaterialFlatButton btnExcluir;
    }
}
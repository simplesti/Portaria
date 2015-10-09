namespace Portaria.Usuarios
{
    partial class CadUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUsuario));
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtGrauParentesco = new System.Windows.Forms.TextBox();
            this.bsUsuario = new System.Windows.Forms.BindingSource(this.components);
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.botaoSalvar = new Portaria.Desktop.Framework.Botoes.BotaoSalvar();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.pnlBiometria = new System.Windows.Forms.Panel();
            this.lblStatusBiometria = new System.Windows.Forms.Label();
            this.botaoVerificarBiometria = new Portaria.Desktop.Framework.Botoes.BotaoVerificarBiometria();
            this.botaoCapturarBiometria = new Portaria.Desktop.Framework.Botoes.BotaoCapturarBiometria();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).BeginInit();
            this.tlpCampos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlBiometria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(532, 189);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(3, 39);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 23;
            this.lblSenha.Text = "Senha";
            // 
            // txtGrauParentesco
            // 
            this.txtGrauParentesco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "Login", true));
            this.txtGrauParentesco.Location = new System.Drawing.Point(288, 16);
            this.txtGrauParentesco.Name = "txtGrauParentesco";
            this.txtGrauParentesco.Size = new System.Drawing.Size(241, 20);
            this.txtGrauParentesco.TabIndex = 1;
            // 
            // bsUsuario
            // 
            this.bsUsuario.DataSource = typeof(Portaria.Core.Model.Usuario);
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(3, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(279, 20);
            this.txtNome.TabIndex = 0;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(288, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Tag = "";
            this.lblLogin.Text = "Login";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 2;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.62776F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.37224F));
            this.tlpCampos.Controls.Add(this.lblNome, 0, 0);
            this.tlpCampos.Controls.Add(this.lblLogin, 1, 0);
            this.tlpCampos.Controls.Add(this.txtNome, 0, 1);
            this.tlpCampos.Controls.Add(this.txtGrauParentesco, 1, 1);
            this.tlpCampos.Controls.Add(this.lblSenha, 0, 2);
            this.tlpCampos.Controls.Add(this.txtSenha, 0, 8);
            this.tlpCampos.Controls.Add(this.cboTipo, 1, 8);
            this.tlpCampos.Controls.Add(this.lblTipo, 1, 2);
            this.tlpCampos.Controls.Add(this.lblRG, 1, 9);
            this.tlpCampos.Controls.Add(this.lblCPF, 0, 9);
            this.tlpCampos.Controls.Add(this.panel1, 1, 11);
            this.tlpCampos.Controls.Add(this.txtRG, 1, 10);
            this.tlpCampos.Controls.Add(this.txtCPF, 0, 10);
            this.tlpCampos.Controls.Add(this.pnlBiometria, 0, 11);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(0, 0);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 12;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCampos.Size = new System.Drawing.Size(532, 189);
            this.tlpCampos.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "Senha", true));
            this.txtSenha.Location = new System.Drawing.Point(3, 55);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(279, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsUsuario, "Tipo", true));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(288, 55);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(241, 21);
            this.cboTipo.TabIndex = 3;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(288, 39);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(28, 13);
            this.lblTipo.TabIndex = 26;
            this.lblTipo.Text = "Tipo";
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(288, 79);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 27;
            this.lblRG.Text = "RG";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(3, 79);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 28;
            this.lblCPF.Text = "CPF";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botaoCancelar);
            this.panel1.Controls.Add(this.botaoSalvar);
            this.panel1.Location = new System.Drawing.Point(288, 121);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 65);
            this.panel1.TabIndex = 29;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(141, 24);
            this.botaoCancelar.MaximumSize = new System.Drawing.Size(100, 37);
            this.botaoCancelar.MinimumSize = new System.Drawing.Size(100, 37);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 37);
            this.botaoCancelar.TabIndex = 3;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoSalvar.BackColor = System.Drawing.Color.White;
            this.botaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoSalvar.Location = new System.Drawing.Point(35, 24);
            this.botaoSalvar.MaximumSize = new System.Drawing.Size(100, 37);
            this.botaoSalvar.MinimumSize = new System.Drawing.Size(100, 37);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(100, 37);
            this.botaoSalvar.TabIndex = 2;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // txtRG
            // 
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "RG", true));
            this.txtRG.Location = new System.Drawing.Point(288, 95);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(241, 20);
            this.txtRG.TabIndex = 30;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "CPF", true));
            this.txtCPF.Location = new System.Drawing.Point(3, 95);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(279, 20);
            this.txtCPF.TabIndex = 31;
            // 
            // pnlBiometria
            // 
            this.pnlBiometria.Controls.Add(this.lblStatusBiometria);
            this.pnlBiometria.Controls.Add(this.botaoVerificarBiometria);
            this.pnlBiometria.Controls.Add(this.botaoCapturarBiometria);
            this.pnlBiometria.Location = new System.Drawing.Point(3, 121);
            this.pnlBiometria.Name = "pnlBiometria";
            this.pnlBiometria.Size = new System.Drawing.Size(279, 65);
            this.pnlBiometria.TabIndex = 32;
            // 
            // lblStatusBiometria
            // 
            this.lblStatusBiometria.AutoSize = true;
            this.lblStatusBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBiometria.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatusBiometria.Location = new System.Drawing.Point(0, 5);
            this.lblStatusBiometria.Name = "lblStatusBiometria";
            this.lblStatusBiometria.Size = new System.Drawing.Size(241, 18);
            this.lblStatusBiometria.TabIndex = 1;
            this.lblStatusBiometria.Text = "BIOMETRIA NÃO CAPTURADA";
            // 
            // botaoVerificarBiometria
            // 
            this.botaoVerificarBiometria.BackColor = System.Drawing.Color.White;
            this.botaoVerificarBiometria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoVerificarBiometria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoVerificarBiometria.Image = ((System.Drawing.Image)(resources.GetObject("botaoVerificarBiometria.Image")));
            this.botaoVerificarBiometria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoVerificarBiometria.Location = new System.Drawing.Point(144, 26);
            this.botaoVerificarBiometria.Name = "botaoVerificarBiometria";
            this.botaoVerificarBiometria.Size = new System.Drawing.Size(135, 35);
            this.botaoVerificarBiometria.TabIndex = 1;
            this.botaoVerificarBiometria.Text = "Verificar Biometria";
            this.botaoVerificarBiometria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoVerificarBiometria.UseVisualStyleBackColor = false;
            this.botaoVerificarBiometria.Click += new System.EventHandler(this.botaoVerificarBiometria_Click);
            // 
            // botaoCapturarBiometria
            // 
            this.botaoCapturarBiometria.BackColor = System.Drawing.Color.White;
            this.botaoCapturarBiometria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCapturarBiometria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCapturarBiometria.Image = ((System.Drawing.Image)(resources.GetObject("botaoCapturarBiometria.Image")));
            this.botaoCapturarBiometria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCapturarBiometria.Location = new System.Drawing.Point(3, 26);
            this.botaoCapturarBiometria.Name = "botaoCapturarBiometria";
            this.botaoCapturarBiometria.Size = new System.Drawing.Size(135, 35);
            this.botaoCapturarBiometria.TabIndex = 0;
            this.botaoCapturarBiometria.Text = "Capturar Biometria";
            this.botaoCapturarBiometria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCapturarBiometria.UseVisualStyleBackColor = false;
            this.botaoCapturarBiometria.Click += new System.EventHandler(this.botaoCapturarBiometria_Click);
            // 
            // CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(538, 252);
            this.ConfiguracoesUsuarioVisivel = true;
            this.MaximumSize = new System.Drawing.Size(538, 252);
            this.MinimumSize = new System.Drawing.Size(538, 252);
            this.Name = "CadUsuario";
            this.Text = "CadUsuario";
            this.Titulo = "Cadastro de usuário";
            this.pnlConteudo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).EndInit();
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.pnlBiometria.ResumeLayout(false);
            this.pnlBiometria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtGrauParentesco;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.BindingSource bsUsuario;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.Panel panel1;
        private Portaria.Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private Portaria.Desktop.Framework.Botoes.BotaoSalvar botaoSalvar;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Panel pnlBiometria;
        private System.Windows.Forms.Label lblStatusBiometria;
        private Portaria.Desktop.Framework.Botoes.BotaoVerificarBiometria botaoVerificarBiometria;
        private Portaria.Desktop.Framework.Botoes.BotaoCapturarBiometria botaoCapturarBiometria;

    }
}
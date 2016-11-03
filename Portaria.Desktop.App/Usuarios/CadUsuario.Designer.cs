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
            this.bsUsuario = new System.Windows.Forms.BindingSource(this.components);
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtLogin = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtCpf = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtRG = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.chkAutorizarBiometria = new MaterialSkin.Controls.MaterialCheckBox();
            this.lblStatusBiometria = new System.Windows.Forms.Label();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnCapturarBio = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVerificarBio = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.btnCapturarBio);
            this.pnlConteudo.Controls.Add(this.btnVerificarBio);
            this.pnlConteudo.Controls.Add(this.cboTipo);
            this.pnlConteudo.Controls.Add(this.txtNome);
            this.pnlConteudo.Controls.Add(this.txtLogin);
            this.pnlConteudo.Controls.Add(this.txtSenha);
            this.pnlConteudo.Controls.Add(this.txtCpf);
            this.pnlConteudo.Controls.Add(this.txtRG);
            this.pnlConteudo.Controls.Add(this.btnSalvar);
            this.pnlConteudo.Controls.Add(this.chkAutorizarBiometria);
            this.pnlConteudo.Controls.Add(this.lblStatusBiometria);
            this.pnlConteudo.Controls.Add(this.materialLabel2);
            this.pnlConteudo.Controls.Add(this.materialLabel3);
            this.pnlConteudo.Controls.Add(this.materialLabel4);
            this.pnlConteudo.Controls.Add(this.materialLabel5);
            this.pnlConteudo.Controls.Add(this.materialLabel6);
            this.pnlConteudo.Controls.Add(this.btnCancelar);
            this.pnlConteudo.Controls.Add(this.materialLabel1);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 66);
            this.pnlConteudo.Size = new System.Drawing.Size(570, 254);
            // 
            // bsUsuario
            // 
            this.bsUsuario.DataSource = typeof(Portaria.Core.Model.Usuario);
            // 
            // cboTipo
            // 
            this.cboTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipo.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.bsUsuario, "Tipo", true));
            this.cboTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(308, 70);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(259, 26);
            this.cboTipo.TabIndex = 51;
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "Nome", true));
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(3, 22);
            this.txtNome.Mask = "";
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(288, 23);
            this.txtNome.TabIndex = 52;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            this.txtLogin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogin.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "Login", true));
            this.txtLogin.Depth = 0;
            this.txtLogin.Hint = "";
            this.txtLogin.Location = new System.Drawing.Point(308, 22);
            this.txtLogin.Mask = "";
            this.txtLogin.MaxLength = 32767;
            this.txtLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.PasswordChar = '\0';
            this.txtLogin.SelectedText = "";
            this.txtLogin.SelectionLength = 0;
            this.txtLogin.SelectionStart = 0;
            this.txtLogin.Size = new System.Drawing.Size(259, 23);
            this.txtLogin.TabIndex = 53;
            this.txtLogin.TabStop = false;
            this.txtLogin.UseSystemPasswordChar = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "Senha", true));
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(3, 70);
            this.txtSenha.Mask = "";
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(288, 23);
            this.txtSenha.TabIndex = 54;
            this.txtSenha.TabStop = false;
            this.txtSenha.UseSystemPasswordChar = false;
            // 
            // txtCpf
            // 
            this.txtCpf.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCpf.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "CPF", true));
            this.txtCpf.Depth = 0;
            this.txtCpf.Hint = "";
            this.txtCpf.Location = new System.Drawing.Point(3, 121);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.MaxLength = 32767;
            this.txtCpf.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.PasswordChar = '\0';
            this.txtCpf.SelectedText = "";
            this.txtCpf.SelectionLength = 0;
            this.txtCpf.SelectionStart = 0;
            this.txtCpf.Size = new System.Drawing.Size(288, 23);
            this.txtCpf.TabIndex = 55;
            this.txtCpf.TabStop = false;
            this.txtCpf.Text = "   .   .   -";
            this.txtCpf.UseSystemPasswordChar = false;
            // 
            // txtRG
            // 
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUsuario, "RG", true));
            this.txtRG.Depth = 0;
            this.txtRG.Hint = "";
            this.txtRG.Location = new System.Drawing.Point(308, 121);
            this.txtRG.Mask = "";
            this.txtRG.MaxLength = 32767;
            this.txtRG.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRG.Name = "txtRG";
            this.txtRG.PasswordChar = '\0';
            this.txtRG.SelectedText = "";
            this.txtRG.SelectionLength = 0;
            this.txtRG.SelectionStart = 0;
            this.txtRG.Size = new System.Drawing.Size(259, 23);
            this.txtRG.TabIndex = 56;
            this.txtRG.TabStop = false;
            this.txtRG.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(494, 215);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 47;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // chkAutorizarBiometria
            // 
            this.chkAutorizarBiometria.AutoSize = true;
            this.chkAutorizarBiometria.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsUsuario, "ControleAcessoAutorizado", true));
            this.chkAutorizarBiometria.Depth = 0;
            this.chkAutorizarBiometria.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkAutorizarBiometria.Location = new System.Drawing.Point(303, 147);
            this.chkAutorizarBiometria.Margin = new System.Windows.Forms.Padding(0);
            this.chkAutorizarBiometria.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAutorizarBiometria.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAutorizarBiometria.Name = "chkAutorizarBiometria";
            this.chkAutorizarBiometria.Ripple = true;
            this.chkAutorizarBiometria.Size = new System.Drawing.Size(227, 30);
            this.chkAutorizarBiometria.TabIndex = 57;
            this.chkAutorizarBiometria.Text = "Autorizar acesso com biometria";
            this.chkAutorizarBiometria.UseVisualStyleBackColor = true;
            // 
            // lblStatusBiometria
            // 
            this.lblStatusBiometria.AutoSize = true;
            this.lblStatusBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBiometria.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatusBiometria.Location = new System.Drawing.Point(4, 186);
            this.lblStatusBiometria.Name = "lblStatusBiometria";
            this.lblStatusBiometria.Size = new System.Drawing.Size(241, 18);
            this.lblStatusBiometria.TabIndex = 48;
            this.lblStatusBiometria.Text = "BIOMETRIA NÃO CAPTURADA";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(308, 0);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(46, 19);
            this.materialLabel2.TabIndex = 59;
            this.materialLabel2.Text = "Login";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(308, 48);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(39, 19);
            this.materialLabel3.TabIndex = 60;
            this.materialLabel3.Text = "Tipo";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 48);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(50, 19);
            this.materialLabel4.TabIndex = 61;
            this.materialLabel4.Text = "Senha";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(3, 99);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(36, 19);
            this.materialLabel5.TabIndex = 62;
            this.materialLabel5.Text = "CPF";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(308, 99);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(28, 19);
            this.materialLabel6.TabIndex = 63;
            this.materialLabel6.Text = "RG";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(395, 215);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 50;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 0);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 58;
            this.materialLabel1.Text = "Nome";
            // 
            // btnCapturarBio
            // 
            this.btnCapturarBio.AutoSize = true;
            this.btnCapturarBio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapturarBio.Depth = 0;
            this.btnCapturarBio.Icon = global::Portaria.Properties.Resources.fingerprint;
            this.btnCapturarBio.Location = new System.Drawing.Point(202, 215);
            this.btnCapturarBio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapturarBio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapturarBio.Name = "btnCapturarBio";
            this.btnCapturarBio.Primary = false;
            this.btnCapturarBio.Size = new System.Drawing.Size(195, 36);
            this.btnCapturarBio.TabIndex = 70;
            this.btnCapturarBio.Text = "Capturar Biometria";
            this.btnCapturarBio.UseVisualStyleBackColor = true;
            this.btnCapturarBio.Click += new System.EventHandler(this.botaoCapturarBiometria_Click);
            // 
            // btnVerificarBio
            // 
            this.btnVerificarBio.AutoSize = true;
            this.btnVerificarBio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVerificarBio.Depth = 0;
            this.btnVerificarBio.Icon = global::Portaria.Properties.Resources.verifiedfingerprint;
            this.btnVerificarBio.Location = new System.Drawing.Point(3, 215);
            this.btnVerificarBio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerificarBio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerificarBio.Name = "btnVerificarBio";
            this.btnVerificarBio.Primary = false;
            this.btnVerificarBio.Size = new System.Drawing.Size(191, 36);
            this.btnVerificarBio.TabIndex = 69;
            this.btnVerificarBio.Text = "Verificar Biometria";
            this.btnVerificarBio.UseVisualStyleBackColor = true;
            this.btnVerificarBio.Click += new System.EventHandler(this.botaoVerificarBiometria_Click);
            // 
            // CadUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(570, 320);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(570, 320);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(570, 320);
            this.Name = "CadUsuario";
            this.ShowInTaskbar = false;
            this.Sizable = false;
            this.Text = "Cadastro de Usuário";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsUsuario;
        private System.Windows.Forms.ComboBox cboTipo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLogin;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCpf;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRG;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialCheckBox chkAutorizarBiometria;
        private System.Windows.Forms.Label lblStatusBiometria;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialFlatButton btnCapturarBio;
        private MaterialSkin.Controls.MaterialFlatButton btnVerificarBio;
    }
}
namespace Portaria
{
    partial class CadPessoa
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
            this.bsPessoa = new System.Windows.Forms.BindingSource(this.components);
            this.lblStatusBiometria = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.chkAutorizadoControleAcesso = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCPF = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFoneResidencial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFoneComercial = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtGrauParentesco = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtRG = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFoneCel = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCapturarBio = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVerificarBio = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.btnCancelar);
            this.pnlConteudo.Controls.Add(this.btnSalvar);
            this.pnlConteudo.Controls.Add(this.btnCapturarBio);
            this.pnlConteudo.Controls.Add(this.btnVerificarBio);
            this.pnlConteudo.Controls.Add(this.txtEmail);
            this.pnlConteudo.Controls.Add(this.materialLabel8);
            this.pnlConteudo.Controls.Add(this.txtFoneCel);
            this.pnlConteudo.Controls.Add(this.materialLabel7);
            this.pnlConteudo.Controls.Add(this.txtRG);
            this.pnlConteudo.Controls.Add(this.materialLabel6);
            this.pnlConteudo.Controls.Add(this.txtGrauParentesco);
            this.pnlConteudo.Controls.Add(this.materialLabel5);
            this.pnlConteudo.Controls.Add(this.txtFoneComercial);
            this.pnlConteudo.Controls.Add(this.materialLabel4);
            this.pnlConteudo.Controls.Add(this.txtFoneResidencial);
            this.pnlConteudo.Controls.Add(this.materialLabel3);
            this.pnlConteudo.Controls.Add(this.txtCPF);
            this.pnlConteudo.Controls.Add(this.materialLabel2);
            this.pnlConteudo.Controls.Add(this.txtNome);
            this.pnlConteudo.Controls.Add(this.materialLabel1);
            this.pnlConteudo.Controls.Add(this.chkAutorizadoControleAcesso);
            this.pnlConteudo.Controls.Add(this.lblStatusBiometria);
            this.pnlConteudo.Controls.Add(this.pbFoto);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 66);
            this.pnlConteudo.Size = new System.Drawing.Size(640, 443);
            // 
            // bsPessoa
            // 
            this.bsPessoa.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Pessoa);
            // 
            // lblStatusBiometria
            // 
            this.lblStatusBiometria.AutoSize = true;
            this.lblStatusBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBiometria.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatusBiometria.Location = new System.Drawing.Point(10, 375);
            this.lblStatusBiometria.Name = "lblStatusBiometria";
            this.lblStatusBiometria.Size = new System.Drawing.Size(241, 18);
            this.lblStatusBiometria.TabIndex = 32;
            this.lblStatusBiometria.Text = "BIOMETRIA NÃO CAPTURADA";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFoto.Location = new System.Drawing.Point(12, 3);
            this.pbFoto.MaximumSize = new System.Drawing.Size(150, 150);
            this.pbFoto.MinimumSize = new System.Drawing.Size(150, 150);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 46;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // chkAutorizadoControleAcesso
            // 
            this.chkAutorizadoControleAcesso.AutoSize = true;
            this.chkAutorizadoControleAcesso.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPessoa, "ControleAcessoAutorizado", true));
            this.chkAutorizadoControleAcesso.Depth = 0;
            this.chkAutorizadoControleAcesso.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkAutorizadoControleAcesso.Location = new System.Drawing.Point(346, 123);
            this.chkAutorizadoControleAcesso.Margin = new System.Windows.Forms.Padding(0);
            this.chkAutorizadoControleAcesso.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAutorizadoControleAcesso.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAutorizadoControleAcesso.Name = "chkAutorizadoControleAcesso";
            this.chkAutorizadoControleAcesso.Ripple = true;
            this.chkAutorizadoControleAcesso.Size = new System.Drawing.Size(227, 30);
            this.chkAutorizadoControleAcesso.TabIndex = 49;
            this.chkAutorizadoControleAcesso.Text = "Autorizar acesso com biometria";
            this.chkAutorizadoControleAcesso.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 156);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 50;
            this.materialLabel1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "Nome", true));
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(12, 178);
            this.txtNome.Mask = "";
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(329, 23);
            this.txtNome.TabIndex = 51;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(8, 204);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(36, 19);
            this.materialLabel2.TabIndex = 52;
            this.materialLabel2.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "CPF", true));
            this.txtCPF.Depth = 0;
            this.txtCPF.Hint = "";
            this.txtCPF.Location = new System.Drawing.Point(12, 226);
            this.txtCPF.Mask = "000,000,000-00";
            this.txtCPF.MaxLength = 32767;
            this.txtCPF.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.PasswordChar = '\0';
            this.txtCPF.SelectedText = "";
            this.txtCPF.SelectionLength = 0;
            this.txtCPF.SelectionStart = 0;
            this.txtCPF.Size = new System.Drawing.Size(329, 23);
            this.txtCPF.TabIndex = 53;
            this.txtCPF.TabStop = false;
            this.txtCPF.Text = "   .   .   -";
            this.txtCPF.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(8, 252);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(119, 19);
            this.materialLabel3.TabIndex = 54;
            this.materialLabel3.Text = "Fone residêncial";
            // 
            // txtFoneResidencial
            // 
            this.txtFoneResidencial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "FoneResidencial", true));
            this.txtFoneResidencial.Depth = 0;
            this.txtFoneResidencial.Hint = "";
            this.txtFoneResidencial.Location = new System.Drawing.Point(12, 274);
            this.txtFoneResidencial.Mask = "";
            this.txtFoneResidencial.MaxLength = 32767;
            this.txtFoneResidencial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFoneResidencial.Name = "txtFoneResidencial";
            this.txtFoneResidencial.PasswordChar = '\0';
            this.txtFoneResidencial.SelectedText = "";
            this.txtFoneResidencial.SelectionLength = 0;
            this.txtFoneResidencial.SelectionStart = 0;
            this.txtFoneResidencial.Size = new System.Drawing.Size(329, 23);
            this.txtFoneResidencial.TabIndex = 55;
            this.txtFoneResidencial.TabStop = false;
            this.txtFoneResidencial.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(8, 300);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(113, 19);
            this.materialLabel4.TabIndex = 56;
            this.materialLabel4.Text = "Fone comercial";
            // 
            // txtFoneComercial
            // 
            this.txtFoneComercial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "FoneComercial", true));
            this.txtFoneComercial.Depth = 0;
            this.txtFoneComercial.Hint = "";
            this.txtFoneComercial.Location = new System.Drawing.Point(12, 322);
            this.txtFoneComercial.Mask = "";
            this.txtFoneComercial.MaxLength = 32767;
            this.txtFoneComercial.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFoneComercial.Name = "txtFoneComercial";
            this.txtFoneComercial.PasswordChar = '\0';
            this.txtFoneComercial.SelectedText = "";
            this.txtFoneComercial.SelectionLength = 0;
            this.txtFoneComercial.SelectionStart = 0;
            this.txtFoneComercial.Size = new System.Drawing.Size(329, 23);
            this.txtFoneComercial.TabIndex = 57;
            this.txtFoneComercial.TabStop = false;
            this.txtFoneComercial.UseSystemPasswordChar = false;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(347, 156);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(242, 19);
            this.materialLabel5.TabIndex = 58;
            this.materialLabel5.Text = "Grau de parentesco do proprietário";
            // 
            // txtGrauParentesco
            // 
            this.txtGrauParentesco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "GrauParentesco", true));
            this.txtGrauParentesco.Depth = 0;
            this.txtGrauParentesco.Hint = "";
            this.txtGrauParentesco.Location = new System.Drawing.Point(351, 178);
            this.txtGrauParentesco.Mask = "";
            this.txtGrauParentesco.MaxLength = 32767;
            this.txtGrauParentesco.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGrauParentesco.Name = "txtGrauParentesco";
            this.txtGrauParentesco.PasswordChar = '\0';
            this.txtGrauParentesco.SelectedText = "";
            this.txtGrauParentesco.SelectionLength = 0;
            this.txtGrauParentesco.SelectionStart = 0;
            this.txtGrauParentesco.Size = new System.Drawing.Size(283, 23);
            this.txtGrauParentesco.TabIndex = 59;
            this.txtGrauParentesco.TabStop = false;
            this.txtGrauParentesco.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(347, 204);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(28, 19);
            this.materialLabel6.TabIndex = 60;
            this.materialLabel6.Text = "RG";
            // 
            // txtRG
            // 
            this.txtRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "RG", true));
            this.txtRG.Depth = 0;
            this.txtRG.Hint = "";
            this.txtRG.Location = new System.Drawing.Point(351, 226);
            this.txtRG.Mask = "";
            this.txtRG.MaxLength = 32767;
            this.txtRG.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtRG.Name = "txtRG";
            this.txtRG.PasswordChar = '\0';
            this.txtRG.SelectedText = "";
            this.txtRG.SelectionLength = 0;
            this.txtRG.SelectionStart = 0;
            this.txtRG.Size = new System.Drawing.Size(283, 23);
            this.txtRG.TabIndex = 61;
            this.txtRG.TabStop = false;
            this.txtRG.UseSystemPasswordChar = false;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(347, 252);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(91, 19);
            this.materialLabel7.TabIndex = 62;
            this.materialLabel7.Text = "Fone celular";
            // 
            // txtFoneCel
            // 
            this.txtFoneCel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "FoneCelular", true));
            this.txtFoneCel.Depth = 0;
            this.txtFoneCel.Hint = "";
            this.txtFoneCel.Location = new System.Drawing.Point(351, 274);
            this.txtFoneCel.Mask = "";
            this.txtFoneCel.MaxLength = 32767;
            this.txtFoneCel.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFoneCel.Name = "txtFoneCel";
            this.txtFoneCel.PasswordChar = '\0';
            this.txtFoneCel.SelectedText = "";
            this.txtFoneCel.SelectionLength = 0;
            this.txtFoneCel.SelectionStart = 0;
            this.txtFoneCel.Size = new System.Drawing.Size(283, 23);
            this.txtFoneCel.TabIndex = 63;
            this.txtFoneCel.TabStop = false;
            this.txtFoneCel.UseSystemPasswordChar = false;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel8.Location = new System.Drawing.Point(347, 300);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(51, 19);
            this.materialLabel8.TabIndex = 64;
            this.materialLabel8.Text = "E-mail";
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "Email", true));
            this.txtEmail.Depth = 0;
            this.txtEmail.Hint = "";
            this.txtEmail.Location = new System.Drawing.Point(351, 322);
            this.txtEmail.Mask = "";
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.Size = new System.Drawing.Size(283, 23);
            this.txtEmail.TabIndex = 65;
            this.txtEmail.TabStop = false;
            this.txtEmail.UseSystemPasswordChar = false;
            // 
            // btnCapturarBio
            // 
            this.btnCapturarBio.AutoSize = true;
            this.btnCapturarBio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapturarBio.Depth = 0;
            this.btnCapturarBio.Icon = global::Portaria.Properties.Resources.fingerprint;
            this.btnCapturarBio.Location = new System.Drawing.Point(211, 399);
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
            this.btnVerificarBio.Location = new System.Drawing.Point(12, 399);
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
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(463, 399);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 72;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(562, 399);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 71;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // CadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(640, 509);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 509);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(640, 509);
            this.Name = "CadPessoa";
            this.Sizable = false;
            this.Text = "Cadastro de Pessoa";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsPessoa;
        private System.Windows.Forms.Label lblStatusBiometria;
        private System.Windows.Forms.PictureBox pbFoto;
        private MaterialSkin.Controls.MaterialCheckBox chkAutorizadoControleAcesso;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCPF;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFoneComercial;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFoneResidencial;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtGrauParentesco;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtRG;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEmail;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFoneCel;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialFlatButton btnCapturarBio;
        private MaterialSkin.Controls.MaterialFlatButton btnVerificarBio;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
    }
}
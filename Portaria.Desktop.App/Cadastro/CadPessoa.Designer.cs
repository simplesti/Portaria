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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadPessoa));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblGrauParentesco = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bsPessoa = new System.Windows.Forms.BindingSource(this.components);
            this.txtGrauParentesco = new System.Windows.Forms.TextBox();
            this.lblFoneResidencial = new System.Windows.Forms.Label();
            this.lblFoneCel = new System.Windows.Forms.Label();
            this.txtFoneResidencial = new System.Windows.Forms.TextBox();
            this.txtFoneCel = new System.Windows.Forms.TextBox();
            this.lblFoneComercial = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFoneComercial = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblRG = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.botaoSalvar = new Portaria.Desktop.Framework.Botoes.BotaoSalvar();
            this.pnlBiometria = new System.Windows.Forms.Panel();
            this.lblStatusBiometria = new System.Windows.Forms.Label();
            this.botaoVerificarBiometria = new Portaria.Desktop.Framework.Botoes.BotaoVerificarBiometria();
            this.botaoCapturarBiometria = new Portaria.Desktop.Framework.Botoes.BotaoCapturarBiometria();
            this.chkAutorizadoControleAcesso = new System.Windows.Forms.CheckBox();
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.pnlBotoes.SuspendLayout();
            this.pnlBiometria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(634, 382);
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 2;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.62776F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.37224F));
            this.tlpCampos.Controls.Add(this.lblNome, 0, 1);
            this.tlpCampos.Controls.Add(this.lblGrauParentesco, 1, 1);
            this.tlpCampos.Controls.Add(this.txtNome, 0, 2);
            this.tlpCampos.Controls.Add(this.txtGrauParentesco, 1, 2);
            this.tlpCampos.Controls.Add(this.lblFoneResidencial, 0, 5);
            this.tlpCampos.Controls.Add(this.lblFoneCel, 1, 5);
            this.tlpCampos.Controls.Add(this.txtFoneResidencial, 0, 6);
            this.tlpCampos.Controls.Add(this.txtFoneCel, 1, 6);
            this.tlpCampos.Controls.Add(this.lblFoneComercial, 0, 7);
            this.tlpCampos.Controls.Add(this.lblEmail, 1, 7);
            this.tlpCampos.Controls.Add(this.txtFoneComercial, 0, 8);
            this.tlpCampos.Controls.Add(this.txtEmail, 1, 8);
            this.tlpCampos.Controls.Add(this.pbFoto, 0, 0);
            this.tlpCampos.Controls.Add(this.lblRG, 1, 3);
            this.tlpCampos.Controls.Add(this.lblCPF, 0, 3);
            this.tlpCampos.Controls.Add(this.txtRG, 1, 4);
            this.tlpCampos.Controls.Add(this.txtCPF, 0, 4);
            this.tlpCampos.Controls.Add(this.pnlBotoes, 1, 10);
            this.tlpCampos.Controls.Add(this.pnlBiometria, 0, 10);
            this.tlpCampos.Controls.Add(this.chkAutorizadoControleAcesso, 1, 0);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(0, 0);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 11;
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
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCampos.Size = new System.Drawing.Size(634, 382);
            this.tlpCampos.TabIndex = 0;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(3, 156);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblGrauParentesco
            // 
            this.lblGrauParentesco.AutoSize = true;
            this.lblGrauParentesco.Location = new System.Drawing.Point(343, 156);
            this.lblGrauParentesco.Name = "lblGrauParentesco";
            this.lblGrauParentesco.Size = new System.Drawing.Size(171, 13);
            this.lblGrauParentesco.TabIndex = 1;
            this.lblGrauParentesco.Tag = "";
            this.lblGrauParentesco.Text = "Grau de parentesco do proprietário";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(3, 172);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(334, 20);
            this.txtNome.TabIndex = 0;
            // 
            // bsPessoa
            // 
            this.bsPessoa.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Pessoa);
            // 
            // txtGrauParentesco
            // 
            this.txtGrauParentesco.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "GrauParentesco", true));
            this.txtGrauParentesco.Location = new System.Drawing.Point(343, 172);
            this.txtGrauParentesco.Name = "txtGrauParentesco";
            this.txtGrauParentesco.Size = new System.Drawing.Size(288, 20);
            this.txtGrauParentesco.TabIndex = 1;
            // 
            // lblFoneResidencial
            // 
            this.lblFoneResidencial.AutoSize = true;
            this.lblFoneResidencial.Location = new System.Drawing.Point(3, 234);
            this.lblFoneResidencial.Name = "lblFoneResidencial";
            this.lblFoneResidencial.Size = new System.Drawing.Size(84, 13);
            this.lblFoneResidencial.TabIndex = 4;
            this.lblFoneResidencial.Text = "Fone residêncial";
            // 
            // lblFoneCel
            // 
            this.lblFoneCel.AutoSize = true;
            this.lblFoneCel.Location = new System.Drawing.Point(343, 234);
            this.lblFoneCel.Name = "lblFoneCel";
            this.lblFoneCel.Size = new System.Drawing.Size(65, 13);
            this.lblFoneCel.TabIndex = 5;
            this.lblFoneCel.Text = "Fone celular";
            // 
            // txtFoneResidencial
            // 
            this.txtFoneResidencial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "FoneResidencial", true));
            this.txtFoneResidencial.Location = new System.Drawing.Point(3, 250);
            this.txtFoneResidencial.Name = "txtFoneResidencial";
            this.txtFoneResidencial.Size = new System.Drawing.Size(334, 20);
            this.txtFoneResidencial.TabIndex = 4;
            // 
            // txtFoneCel
            // 
            this.txtFoneCel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "FoneCelular", true));
            this.txtFoneCel.Location = new System.Drawing.Point(343, 250);
            this.txtFoneCel.Name = "txtFoneCel";
            this.txtFoneCel.Size = new System.Drawing.Size(288, 20);
            this.txtFoneCel.TabIndex = 5;
            // 
            // lblFoneComercial
            // 
            this.lblFoneComercial.AutoSize = true;
            this.lblFoneComercial.Location = new System.Drawing.Point(3, 273);
            this.lblFoneComercial.Name = "lblFoneComercial";
            this.lblFoneComercial.Size = new System.Drawing.Size(79, 13);
            this.lblFoneComercial.TabIndex = 8;
            this.lblFoneComercial.Text = "Fone comercial";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(343, 273);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 9;
            this.lblEmail.Text = "E-mail";
            // 
            // txtFoneComercial
            // 
            this.txtFoneComercial.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "FoneComercial", true));
            this.txtFoneComercial.Location = new System.Drawing.Point(3, 289);
            this.txtFoneComercial.Name = "txtFoneComercial";
            this.txtFoneComercial.Size = new System.Drawing.Size(334, 20);
            this.txtFoneComercial.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "Email", true));
            this.txtEmail.Location = new System.Drawing.Point(343, 289);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(288, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFoto.Location = new System.Drawing.Point(3, 3);
            this.pbFoto.MaximumSize = new System.Drawing.Size(150, 150);
            this.pbFoto.MinimumSize = new System.Drawing.Size(150, 150);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(150, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 12;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblRG
            // 
            this.lblRG.AutoSize = true;
            this.lblRG.Location = new System.Drawing.Point(343, 195);
            this.lblRG.Name = "lblRG";
            this.lblRG.Size = new System.Drawing.Size(23, 13);
            this.lblRG.TabIndex = 22;
            this.lblRG.Text = "RG";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(3, 195);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF";
            // 
            // txtRG
            // 
            this.txtRG.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRG.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "RG", true));
            this.txtRG.Location = new System.Drawing.Point(343, 211);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(288, 20);
            this.txtRG.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCPF.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsPessoa, "CPF", true));
            this.txtCPF.Location = new System.Drawing.Point(3, 211);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(334, 20);
            this.txtCPF.TabIndex = 2;
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.botaoCancelar);
            this.pnlBotoes.Controls.Add(this.botaoSalvar);
            this.pnlBotoes.Location = new System.Drawing.Point(343, 315);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(288, 64);
            this.pnlBotoes.TabIndex = 24;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(188, 26);
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
            this.botaoSalvar.Location = new System.Drawing.Point(82, 26);
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
            // pnlBiometria
            // 
            this.pnlBiometria.Controls.Add(this.lblStatusBiometria);
            this.pnlBiometria.Controls.Add(this.botaoVerificarBiometria);
            this.pnlBiometria.Controls.Add(this.botaoCapturarBiometria);
            this.pnlBiometria.Location = new System.Drawing.Point(3, 315);
            this.pnlBiometria.Name = "pnlBiometria";
            this.pnlBiometria.Size = new System.Drawing.Size(334, 64);
            this.pnlBiometria.TabIndex = 25;
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
            // chkAutorizadoControleAcesso
            // 
            this.chkAutorizadoControleAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutorizadoControleAcesso.AutoSize = true;
            this.chkAutorizadoControleAcesso.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsPessoa, "ControleAcessoAutorizado", true));
            this.chkAutorizadoControleAcesso.Location = new System.Drawing.Point(343, 136);
            this.chkAutorizadoControleAcesso.Name = "chkAutorizadoControleAcesso";
            this.chkAutorizadoControleAcesso.Size = new System.Drawing.Size(172, 17);
            this.chkAutorizadoControleAcesso.TabIndex = 26;
            this.chkAutorizadoControleAcesso.Text = "Autorizar acesso com biometria";
            this.chkAutorizadoControleAcesso.UseVisualStyleBackColor = true;
            // 
            // CadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 445);
            this.ConfiguracoesUsuarioVisivel = true;
            this.MaximumSize = new System.Drawing.Size(640, 445);
            this.MinimumSize = new System.Drawing.Size(640, 445);
            this.Name = "CadPessoa";
            this.Text = "CadPessoa";
            this.Titulo = "Cadastro de pessoa";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBiometria.ResumeLayout(false);
            this.pnlBiometria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblGrauParentesco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtGrauParentesco;
        private System.Windows.Forms.Label lblFoneResidencial;
        private System.Windows.Forms.Label lblFoneCel;
        private System.Windows.Forms.TextBox txtFoneResidencial;
        private System.Windows.Forms.TextBox txtFoneCel;
        private System.Windows.Forms.Label lblFoneComercial;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtFoneComercial;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.BindingSource bsPessoa;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Panel pnlBotoes;
        private Portaria.Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private Portaria.Desktop.Framework.Botoes.BotaoSalvar botaoSalvar;
        private System.Windows.Forms.Panel pnlBiometria;
        private System.Windows.Forms.Label lblStatusBiometria;
        private Portaria.Desktop.Framework.Botoes.BotaoVerificarBiometria botaoVerificarBiometria;
        private Portaria.Desktop.Framework.Botoes.BotaoCapturarBiometria botaoCapturarBiometria;
        private System.Windows.Forms.CheckBox chkAutorizadoControleAcesso;
    }
}
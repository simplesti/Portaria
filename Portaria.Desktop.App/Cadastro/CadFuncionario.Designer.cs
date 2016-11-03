namespace Portaria.UnidadesBlocos
{
    partial class CadFuncionario
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
            this.lblStatusBiometria = new System.Windows.Forms.Label();
            this.dtEntrada = new System.Windows.Forms.DateTimePicker();
            this.bsFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.dtSaida = new System.Windows.Forms.DateTimePicker();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtDescricao = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.chkAutorizadoSemPresenca = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFrequencia = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtFone = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkAutorizarControleAcesso = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCapturarBio = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnVerificarBio = new MaterialSkin.Controls.MaterialFlatButton();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.btnCapturarBio);
            this.pnlConteudo.Controls.Add(this.btnVerificarBio);
            this.pnlConteudo.Controls.Add(this.btnCancelar);
            this.pnlConteudo.Controls.Add(this.btnSalvar);
            this.pnlConteudo.Controls.Add(this.materialLabel7);
            this.pnlConteudo.Controls.Add(this.chkAutorizarControleAcesso);
            this.pnlConteudo.Controls.Add(this.txtFone);
            this.pnlConteudo.Controls.Add(this.materialLabel6);
            this.pnlConteudo.Controls.Add(this.txtFrequencia);
            this.pnlConteudo.Controls.Add(this.materialLabel5);
            this.pnlConteudo.Controls.Add(this.chkAutorizadoSemPresenca);
            this.pnlConteudo.Controls.Add(this.materialLabel4);
            this.pnlConteudo.Controls.Add(this.txtDescricao);
            this.pnlConteudo.Controls.Add(this.materialLabel3);
            this.pnlConteudo.Controls.Add(this.txtDocumento);
            this.pnlConteudo.Controls.Add(this.materialLabel2);
            this.pnlConteudo.Controls.Add(this.txtNome);
            this.pnlConteudo.Controls.Add(this.materialLabel1);
            this.pnlConteudo.Controls.Add(this.lblStatusBiometria);
            this.pnlConteudo.Controls.Add(this.pbFoto);
            this.pnlConteudo.Controls.Add(this.dtEntrada);
            this.pnlConteudo.Controls.Add(this.dtSaida);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 66);
            this.pnlConteudo.Size = new System.Drawing.Size(745, 469);
            // 
            // lblStatusBiometria
            // 
            this.lblStatusBiometria.AutoSize = true;
            this.lblStatusBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusBiometria.ForeColor = System.Drawing.Color.DarkRed;
            this.lblStatusBiometria.Location = new System.Drawing.Point(12, 391);
            this.lblStatusBiometria.Name = "lblStatusBiometria";
            this.lblStatusBiometria.Size = new System.Drawing.Size(241, 18);
            this.lblStatusBiometria.TabIndex = 32;
            this.lblStatusBiometria.Text = "BIOMETRIA NÃO CAPTURADA";
            // 
            // dtEntrada
            // 
            this.dtEntrada.CustomFormat = "HH:mm";
            this.dtEntrada.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFuncionario, "HorarioEntrada", true));
            this.dtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEntrada.Location = new System.Drawing.Point(15, 322);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(200, 24);
            this.dtEntrada.TabIndex = 43;
            // 
            // bsFuncionario
            // 
            this.bsFuncionario.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Funcionario);
            // 
            // dtSaida
            // 
            this.dtSaida.CustomFormat = "HH:mm";
            this.dtSaida.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFuncionario, "HorarioSaida", true));
            this.dtSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSaida.Location = new System.Drawing.Point(405, 322);
            this.dtSaida.Name = "dtSaida";
            this.dtSaida.Size = new System.Drawing.Size(200, 24);
            this.dtSaida.TabIndex = 44;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(11, 156);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(50, 19);
            this.materialLabel1.TabIndex = 51;
            this.materialLabel1.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Nome", true));
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(15, 178);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(368, 23);
            this.txtNome.TabIndex = 52;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(11, 204);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(87, 19);
            this.materialLabel2.TabIndex = 53;
            this.materialLabel2.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Documento", true));
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Hint = "";
            this.txtDocumento.Location = new System.Drawing.Point(15, 226);
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(368, 23);
            this.txtDocumento.TabIndex = 54;
            this.txtDocumento.TabStop = false;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(11, 252);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(151, 19);
            this.materialLabel3.TabIndex = 55;
            this.materialLabel3.Text = "Descrição do serviço";
            // 
            // txtDescricao
            // 
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Descricao", true));
            this.txtDescricao.Depth = 0;
            this.txtDescricao.Hint = "";
            this.txtDescricao.Location = new System.Drawing.Point(15, 274);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.Size = new System.Drawing.Size(368, 23);
            this.txtDescricao.TabIndex = 56;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(11, 300);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(134, 19);
            this.materialLabel4.TabIndex = 57;
            this.materialLabel4.Text = "Horário de entrada";
            // 
            // chkAutorizadoSemPresenca
            // 
            this.chkAutorizadoSemPresenca.AutoSize = true;
            this.chkAutorizadoSemPresenca.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsFuncionario, "AutorizadaSemPresenca", true));
            this.chkAutorizadoSemPresenca.Depth = 0;
            this.chkAutorizadoSemPresenca.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkAutorizadoSemPresenca.Location = new System.Drawing.Point(400, 253);
            this.chkAutorizadoSemPresenca.Margin = new System.Windows.Forms.Padding(0);
            this.chkAutorizadoSemPresenca.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAutorizadoSemPresenca.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAutorizadoSemPresenca.Name = "chkAutorizadoSemPresenca";
            this.chkAutorizadoSemPresenca.Ripple = true;
            this.chkAutorizadoSemPresenca.Size = new System.Drawing.Size(313, 30);
            this.chkAutorizadoSemPresenca.TabIndex = 58;
            this.chkAutorizadoSemPresenca.Text = "Autorizar entrada sem a presença do morador";
            this.chkAutorizadoSemPresenca.UseVisualStyleBackColor = true;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(401, 156);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(83, 19);
            this.materialLabel5.TabIndex = 59;
            this.materialLabel5.Text = "Frequência";
            // 
            // txtFrequencia
            // 
            this.txtFrequencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Frequencia", true));
            this.txtFrequencia.Depth = 0;
            this.txtFrequencia.Hint = "";
            this.txtFrequencia.Location = new System.Drawing.Point(405, 178);
            this.txtFrequencia.MaxLength = 32767;
            this.txtFrequencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFrequencia.Name = "txtFrequencia";
            this.txtFrequencia.PasswordChar = '\0';
            this.txtFrequencia.SelectedText = "";
            this.txtFrequencia.SelectionLength = 0;
            this.txtFrequencia.SelectionStart = 0;
            this.txtFrequencia.Size = new System.Drawing.Size(328, 23);
            this.txtFrequencia.TabIndex = 60;
            this.txtFrequencia.TabStop = false;
            this.txtFrequencia.UseSystemPasswordChar = false;
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(401, 204);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(42, 19);
            this.materialLabel6.TabIndex = 61;
            this.materialLabel6.Text = "Fone";
            // 
            // txtFone
            // 
            this.txtFone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Fone", true));
            this.txtFone.Depth = 0;
            this.txtFone.Hint = "";
            this.txtFone.Location = new System.Drawing.Point(405, 226);
            this.txtFone.MaxLength = 32767;
            this.txtFone.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtFone.Name = "txtFone";
            this.txtFone.PasswordChar = '\0';
            this.txtFone.SelectedText = "";
            this.txtFone.SelectionLength = 0;
            this.txtFone.SelectionStart = 0;
            this.txtFone.Size = new System.Drawing.Size(328, 23);
            this.txtFone.TabIndex = 62;
            this.txtFone.TabStop = false;
            this.txtFone.UseSystemPasswordChar = false;
            // 
            // chkAutorizarControleAcesso
            // 
            this.chkAutorizarControleAcesso.AutoSize = true;
            this.chkAutorizarControleAcesso.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsFuncionario, "ControleAcessoAutorizado", true));
            this.chkAutorizarControleAcesso.Depth = 0;
            this.chkAutorizarControleAcesso.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkAutorizarControleAcesso.Location = new System.Drawing.Point(9, 361);
            this.chkAutorizarControleAcesso.Margin = new System.Windows.Forms.Padding(0);
            this.chkAutorizarControleAcesso.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkAutorizarControleAcesso.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkAutorizarControleAcesso.Name = "chkAutorizarControleAcesso";
            this.chkAutorizarControleAcesso.Ripple = true;
            this.chkAutorizarControleAcesso.Size = new System.Drawing.Size(227, 30);
            this.chkAutorizarControleAcesso.TabIndex = 63;
            this.chkAutorizarControleAcesso.Text = "Autorizar acesso com biometria";
            this.chkAutorizarControleAcesso.UseVisualStyleBackColor = true;
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel7.Location = new System.Drawing.Point(401, 300);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(120, 19);
            this.materialLabel7.TabIndex = 64;
            this.materialLabel7.Text = "Horário de saída";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(661, 427);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 65;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(562, 427);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 66;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // btnCapturarBio
            // 
            this.btnCapturarBio.AutoSize = true;
            this.btnCapturarBio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCapturarBio.Depth = 0;
            this.btnCapturarBio.Icon = global::Portaria.Properties.Resources.fingerprint;
            this.btnCapturarBio.Location = new System.Drawing.Point(214, 427);
            this.btnCapturarBio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCapturarBio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCapturarBio.Name = "btnCapturarBio";
            this.btnCapturarBio.Primary = false;
            this.btnCapturarBio.Size = new System.Drawing.Size(195, 36);
            this.btnCapturarBio.TabIndex = 68;
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
            this.btnVerificarBio.Location = new System.Drawing.Point(15, 427);
            this.btnVerificarBio.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVerificarBio.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVerificarBio.Name = "btnVerificarBio";
            this.btnVerificarBio.Primary = false;
            this.btnVerificarBio.Size = new System.Drawing.Size(191, 36);
            this.btnVerificarBio.TabIndex = 67;
            this.btnVerificarBio.Text = "Verificar Biometria";
            this.btnVerificarBio.UseVisualStyleBackColor = true;
            this.btnVerificarBio.Click += new System.EventHandler(this.botaoVerificarBiometria_Click);
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
            this.pbFoto.TabIndex = 47;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // CadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(745, 535);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(745, 535);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(745, 535);
            this.Name = "CadFuncionario";
            this.Sizable = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Cadastro de Funcionário";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsFuncionario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.Label lblStatusBiometria;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DateTimePicker dtEntrada;
        private System.Windows.Forms.DateTimePicker dtSaida;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDescricao;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialCheckBox chkAutorizadoSemPresenca;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFone;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtFrequencia;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialCheckBox chkAutorizarControleAcesso;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton btnCapturarBio;
        private MaterialSkin.Controls.MaterialFlatButton btnVerificarBio;
    }
}
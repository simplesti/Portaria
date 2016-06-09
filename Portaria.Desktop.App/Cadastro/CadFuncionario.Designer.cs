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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadFuncionario));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bsFuncionario = new System.Windows.Forms.BindingSource(this.components);
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblFone = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtFone = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblDocumento = new System.Windows.Forms.Label();
            this.txtDocumento = new System.Windows.Forms.TextBox();
            this.lblHorarioSaida = new System.Windows.Forms.Label();
            this.lblHorarioEntrada = new System.Windows.Forms.Label();
            this.lblFrequencia = new System.Windows.Forms.Label();
            this.txtFrequencia = new System.Windows.Forms.TextBox();
            this.chkAutorizadoSemPresenca = new System.Windows.Forms.CheckBox();
            this.dtEntrada = new System.Windows.Forms.DateTimePicker();
            this.dtSaida = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.botaoSalvar = new Portaria.Desktop.Framework.Botoes.BotaoSalvar();
            this.pnlBiometria = new System.Windows.Forms.Panel();
            this.lblStatusBiometria = new System.Windows.Forms.Label();
            this.botaoVerificarBiometria = new Portaria.Desktop.Framework.Botoes.BotaoVerificarBiometria();
            this.botaoCapturarBiometria = new Portaria.Desktop.Framework.Botoes.BotaoCapturarBiometria();
            this.chkAutorizarControleAcesso = new System.Windows.Forms.CheckBox();
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnlBiometria.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(729, 387);
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 2;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.62776F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.37224F));
            this.tlpCampos.Controls.Add(this.lblNome, 0, 1);
            this.tlpCampos.Controls.Add(this.txtNome, 0, 2);
            this.tlpCampos.Controls.Add(this.lblDescricao, 0, 5);
            this.tlpCampos.Controls.Add(this.lblFone, 1, 5);
            this.tlpCampos.Controls.Add(this.txtDescricao, 0, 6);
            this.tlpCampos.Controls.Add(this.txtFone, 1, 6);
            this.tlpCampos.Controls.Add(this.pbFoto, 0, 0);
            this.tlpCampos.Controls.Add(this.lblDocumento, 0, 3);
            this.tlpCampos.Controls.Add(this.txtDocumento, 0, 4);
            this.tlpCampos.Controls.Add(this.lblHorarioSaida, 1, 9);
            this.tlpCampos.Controls.Add(this.lblHorarioEntrada, 0, 9);
            this.tlpCampos.Controls.Add(this.lblFrequencia, 1, 3);
            this.tlpCampos.Controls.Add(this.txtFrequencia, 1, 4);
            this.tlpCampos.Controls.Add(this.chkAutorizadoSemPresenca, 1, 2);
            this.tlpCampos.Controls.Add(this.dtEntrada, 0, 10);
            this.tlpCampos.Controls.Add(this.dtSaida, 1, 10);
            this.tlpCampos.Controls.Add(this.panel1, 1, 11);
            this.tlpCampos.Controls.Add(this.pnlBiometria, 0, 11);
            this.tlpCampos.Controls.Add(this.chkAutorizarControleAcesso, 1, 0);
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
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tlpCampos.Size = new System.Drawing.Size(729, 387);
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
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Nome", true));
            this.txtNome.Location = new System.Drawing.Point(3, 172);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(384, 20);
            this.txtNome.TabIndex = 0;
            // 
            // bsFuncionario
            // 
            this.bsFuncionario.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Funcionario);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(3, 234);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblFone
            // 
            this.lblFone.AutoSize = true;
            this.lblFone.Location = new System.Drawing.Point(393, 234);
            this.lblFone.Name = "lblFone";
            this.lblFone.Size = new System.Drawing.Size(31, 13);
            this.lblFone.TabIndex = 5;
            this.lblFone.Text = "Fone";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Descricao", true));
            this.txtDescricao.Location = new System.Drawing.Point(3, 250);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(384, 20);
            this.txtDescricao.TabIndex = 4;
            // 
            // txtFone
            // 
            this.txtFone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Fone", true));
            this.txtFone.Location = new System.Drawing.Point(393, 250);
            this.txtFone.Name = "txtFone";
            this.txtFone.Size = new System.Drawing.Size(333, 20);
            this.txtFone.TabIndex = 5;
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
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Location = new System.Drawing.Point(3, 195);
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(62, 13);
            this.lblDocumento.TabIndex = 23;
            this.lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Documento", true));
            this.txtDocumento.Location = new System.Drawing.Point(3, 211);
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.Size = new System.Drawing.Size(384, 20);
            this.txtDocumento.TabIndex = 2;
            // 
            // lblHorarioSaida
            // 
            this.lblHorarioSaida.AutoSize = true;
            this.lblHorarioSaida.Location = new System.Drawing.Point(393, 273);
            this.lblHorarioSaida.Name = "lblHorarioSaida";
            this.lblHorarioSaida.Size = new System.Drawing.Size(86, 13);
            this.lblHorarioSaida.TabIndex = 26;
            this.lblHorarioSaida.Text = "Horário de saída";
            // 
            // lblHorarioEntrada
            // 
            this.lblHorarioEntrada.AutoSize = true;
            this.lblHorarioEntrada.Location = new System.Drawing.Point(3, 273);
            this.lblHorarioEntrada.Name = "lblHorarioEntrada";
            this.lblHorarioEntrada.Size = new System.Drawing.Size(95, 13);
            this.lblHorarioEntrada.TabIndex = 9;
            this.lblHorarioEntrada.Text = "Horário de entrada";
            // 
            // lblFrequencia
            // 
            this.lblFrequencia.AutoSize = true;
            this.lblFrequencia.Location = new System.Drawing.Point(393, 195);
            this.lblFrequencia.Name = "lblFrequencia";
            this.lblFrequencia.Size = new System.Drawing.Size(60, 13);
            this.lblFrequencia.TabIndex = 8;
            this.lblFrequencia.Text = "Frequência";
            // 
            // txtFrequencia
            // 
            this.txtFrequencia.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFrequencia.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsFuncionario, "Frequencia", true));
            this.txtFrequencia.Location = new System.Drawing.Point(393, 211);
            this.txtFrequencia.Name = "txtFrequencia";
            this.txtFrequencia.Size = new System.Drawing.Size(333, 20);
            this.txtFrequencia.TabIndex = 3;
            // 
            // chkAutorizadoSemPresenca
            // 
            this.chkAutorizadoSemPresenca.AutoSize = true;
            this.chkAutorizadoSemPresenca.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsFuncionario, "AutorizadaSemPresenca", true));
            this.chkAutorizadoSemPresenca.Location = new System.Drawing.Point(393, 172);
            this.chkAutorizadoSemPresenca.Name = "chkAutorizadoSemPresenca";
            this.chkAutorizadoSemPresenca.Size = new System.Drawing.Size(258, 17);
            this.chkAutorizadoSemPresenca.TabIndex = 1;
            this.chkAutorizadoSemPresenca.Text = "Autorizada a entrada sem a presença do morador";
            this.chkAutorizadoSemPresenca.UseVisualStyleBackColor = true;
            // 
            // dtEntrada
            // 
            this.dtEntrada.CustomFormat = "HH:mm";
            this.dtEntrada.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFuncionario, "HorarioEntrada", true));
            this.dtEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtEntrada.Location = new System.Drawing.Point(3, 289);
            this.dtEntrada.Name = "dtEntrada";
            this.dtEntrada.Size = new System.Drawing.Size(200, 20);
            this.dtEntrada.TabIndex = 6;
            // 
            // dtSaida
            // 
            this.dtSaida.CustomFormat = "HH:mm";
            this.dtSaida.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsFuncionario, "HorarioSaida", true));
            this.dtSaida.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtSaida.Location = new System.Drawing.Point(393, 289);
            this.dtSaida.Name = "dtSaida";
            this.dtSaida.Size = new System.Drawing.Size(200, 20);
            this.dtSaida.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botaoCancelar);
            this.panel1.Controls.Add(this.botaoSalvar);
            this.panel1.Location = new System.Drawing.Point(393, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 69);
            this.panel1.TabIndex = 27;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(230, 26);
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
            this.botaoSalvar.Location = new System.Drawing.Point(124, 26);
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
            this.pnlBiometria.Size = new System.Drawing.Size(384, 67);
            this.pnlBiometria.TabIndex = 28;
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
            // chkAutorizarControleAcesso
            // 
            this.chkAutorizarControleAcesso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkAutorizarControleAcesso.AutoSize = true;
            this.chkAutorizarControleAcesso.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsFuncionario, "ControleAcessoAutorizado", true));
            this.chkAutorizarControleAcesso.Location = new System.Drawing.Point(393, 136);
            this.chkAutorizarControleAcesso.Name = "chkAutorizarControleAcesso";
            this.chkAutorizarControleAcesso.Size = new System.Drawing.Size(172, 17);
            this.chkAutorizarControleAcesso.TabIndex = 29;
            this.chkAutorizarControleAcesso.Text = "Autorizar acesso com biometria";
            this.chkAutorizarControleAcesso.UseVisualStyleBackColor = true;
            // 
            // CadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 450);
            this.ConfiguracoesUsuarioVisivel = true;
            this.MaximumSize = new System.Drawing.Size(735, 450);
            this.MinimumSize = new System.Drawing.Size(735, 450);
            this.Name = "CadFuncionario";
            this.Text = "CadFuncionario";
            this.Titulo = "Cadastro de Funcionário";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.pnlBiometria.ResumeLayout(false);
            this.pnlBiometria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblFone;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtFone;
        private System.Windows.Forms.Label lblFrequencia;
        private System.Windows.Forms.Label lblHorarioEntrada;
        private System.Windows.Forms.TextBox txtFrequencia;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblDocumento;
        private System.Windows.Forms.TextBox txtDocumento;
        private System.Windows.Forms.Label lblHorarioSaida;
        private System.Windows.Forms.CheckBox chkAutorizadoSemPresenca;
        private System.Windows.Forms.BindingSource bsFuncionario;
        private System.Windows.Forms.DateTimePicker dtEntrada;
        private System.Windows.Forms.DateTimePicker dtSaida;
        private System.Windows.Forms.Panel panel1;
        private Portaria.Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private Portaria.Desktop.Framework.Botoes.BotaoSalvar botaoSalvar;
        private System.Windows.Forms.Panel pnlBiometria;
        private System.Windows.Forms.Label lblStatusBiometria;
        private Portaria.Desktop.Framework.Botoes.BotaoVerificarBiometria botaoVerificarBiometria;
        private Portaria.Desktop.Framework.Botoes.BotaoCapturarBiometria botaoCapturarBiometria;
        private System.Windows.Forms.CheckBox chkAutorizarControleAcesso;
    }
}
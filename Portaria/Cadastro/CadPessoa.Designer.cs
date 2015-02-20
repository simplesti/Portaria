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
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.botaoCancelar = new Portaria.Framework.Botoes.BotaoCancelar();
            this.botaoSalvar = new Portaria.Framework.Botoes.BotaoSalvar();
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
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(634, 362);
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 2;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.62776F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.37224F));
            this.tlpCampos.Controls.Add(this.tlpBotoes, 0, 9);
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
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(0, 0);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 10;
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
            this.tlpCampos.Size = new System.Drawing.Size(634, 362);
            this.tlpCampos.TabIndex = 0;
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotoes.AutoSize = true;
            this.tlpBotoes.ColumnCount = 2;
            this.tlpCampos.SetColumnSpan(this.tlpBotoes, 2);
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBotoes.Controls.Add(this.botaoCancelar, 1, 0);
            this.tlpBotoes.Controls.Add(this.botaoSalvar, 0, 0);
            this.tlpBotoes.Location = new System.Drawing.Point(419, 316);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpBotoes.Size = new System.Drawing.Size(212, 43);
            this.tlpBotoes.TabIndex = 21;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(109, 3);
            this.botaoCancelar.MaximumSize = new System.Drawing.Size(100, 37);
            this.botaoCancelar.MinimumSize = new System.Drawing.Size(100, 37);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 37);
            this.botaoCancelar.TabIndex = 1;
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
            this.botaoSalvar.Location = new System.Drawing.Point(3, 3);
            this.botaoSalvar.MaximumSize = new System.Drawing.Size(100, 37);
            this.botaoSalvar.MinimumSize = new System.Drawing.Size(100, 37);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(100, 37);
            this.botaoSalvar.TabIndex = 0;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
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
            // CadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 425);
            this.MaximumSize = new System.Drawing.Size(640, 425);
            this.MinimumSize = new System.Drawing.Size(640, 425);
            this.Name = "CadPessoa";
            this.Text = "CadPessoa";
            this.Titulo = "Cadastro de pessoa";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            this.tlpBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private Framework.Botoes.BotaoCancelar botaoCancelar;
        private Framework.Botoes.BotaoSalvar botaoSalvar;
        private System.Windows.Forms.BindingSource bsPessoa;
        private System.Windows.Forms.Label lblRG;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
    }
}
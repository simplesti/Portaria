namespace Portaria.LivroNegro
{
    partial class CadCategoriaLivroNegro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadCategoriaLivroNegro));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bsCategoria = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.botaoSalvar = new Portaria.Desktop.Framework.Botoes.BotaoSalvar();
            this.chkEnviarEmail = new System.Windows.Forms.CheckBox();
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoria)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(464, 112);
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 2;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.62776F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.37224F));
            this.tlpCampos.Controls.Add(this.lblNome, 0, 0);
            this.tlpCampos.Controls.Add(this.txtNome, 0, 1);
            this.tlpCampos.Controls.Add(this.panel1, 1, 11);
            this.tlpCampos.Controls.Add(this.chkEnviarEmail, 1, 1);
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
            this.tlpCampos.Size = new System.Drawing.Size(464, 112);
            this.tlpCampos.TabIndex = 2;
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
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCategoria, "Nome", true));
            this.txtNome.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNome.Location = new System.Drawing.Point(3, 16);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(242, 20);
            this.txtNome.TabIndex = 0;
            // 
            // bsCategoria
            // 
            this.bsCategoria.DataSource = typeof(Portaria.Core.Model.CategoriaLivroNegro);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botaoCancelar);
            this.panel1.Controls.Add(this.botaoSalvar);
            this.panel1.Location = new System.Drawing.Point(251, 42);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 65);
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
            this.botaoCancelar.Location = new System.Drawing.Point(110, 24);
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
            this.botaoSalvar.Location = new System.Drawing.Point(4, 24);
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
            // chkEnviarEmail
            // 
            this.chkEnviarEmail.AutoSize = true;
            this.chkEnviarEmail.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.bsCategoria, "EnviarEmailNotificacao", true));
            this.chkEnviarEmail.Location = new System.Drawing.Point(251, 16);
            this.chkEnviarEmail.Name = "chkEnviarEmail";
            this.chkEnviarEmail.Size = new System.Drawing.Size(156, 17);
            this.chkEnviarEmail.TabIndex = 30;
            this.chkEnviarEmail.Text = "Enviar e-mail de notificação";
            this.chkEnviarEmail.UseVisualStyleBackColor = true;
            // 
            // CadCategoriaLivroNegro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 175);
            this.ConfiguracoesUsuarioVisivel = true;
            this.MaximumSize = new System.Drawing.Size(470, 175);
            this.MinimumSize = new System.Drawing.Size(470, 175);
            this.Name = "CadCategoriaLivroNegro";
            this.Text = "Cadastro de categoria";
            this.Titulo = "Cadastro de categoria";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategoria)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Panel panel1;
        private Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private Desktop.Framework.Botoes.BotaoSalvar botaoSalvar;
        private System.Windows.Forms.BindingSource bsCategoria;
        private System.Windows.Forms.CheckBox chkEnviarEmail;
    }
}
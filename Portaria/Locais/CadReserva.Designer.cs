namespace Portaria.Locais
{
    partial class CadReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadReserva));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.botaoSalvar = new Portaria.Desktop.Framework.Botoes.BotaoSalvar();
            this.lblInicio = new System.Windows.Forms.Label();
            this.lblFim = new System.Windows.Forms.Label();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.bsReserva = new System.Windows.Forms.BindingSource(this.components);
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.lblSolicitante = new System.Windows.Forms.Label();
            this.txtSolicitante = new System.Windows.Forms.TextBox();
            this.botaoEditarSolicitante = new Portaria.Desktop.Framework.Botoes.BotaoEditar();
            this.lblUnidade = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.botaoPesquisarUnidade = new Portaria.Desktop.Framework.Botoes.BotaoPesquisar();
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(465, 228);
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 3;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.Controls.Add(this.tlpBotoes, 0, 15);
            this.tlpCampos.Controls.Add(this.lblInicio, 0, 3);
            this.tlpCampos.Controls.Add(this.lblFim, 2, 3);
            this.tlpCampos.Controls.Add(this.dtInicio, 0, 4);
            this.tlpCampos.Controls.Add(this.dtFim, 2, 4);
            this.tlpCampos.Controls.Add(this.lblLocal, 0, 1);
            this.tlpCampos.Controls.Add(this.txtLocal, 0, 2);
            this.tlpCampos.Controls.Add(this.lblSolicitante, 0, 11);
            this.tlpCampos.Controls.Add(this.txtSolicitante, 0, 12);
            this.tlpCampos.Controls.Add(this.botaoEditarSolicitante, 1, 12);
            this.tlpCampos.Controls.Add(this.lblUnidade, 0, 13);
            this.tlpCampos.Controls.Add(this.txtUnidade, 0, 14);
            this.tlpCampos.Controls.Add(this.botaoPesquisarUnidade, 1, 14);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(0, 0);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 16;
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
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCampos.Size = new System.Drawing.Size(465, 228);
            this.tlpCampos.TabIndex = 2;
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotoes.AutoSize = true;
            this.tlpBotoes.ColumnCount = 2;
            this.tlpCampos.SetColumnSpan(this.tlpBotoes, 3);
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBotoes.Controls.Add(this.botaoCancelar, 1, 0);
            this.tlpBotoes.Controls.Add(this.botaoSalvar, 0, 0);
            this.tlpBotoes.Location = new System.Drawing.Point(250, 182);
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
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(3, 39);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(34, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Início";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Location = new System.Drawing.Point(254, 39);
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(23, 13);
            this.lblFim.TabIndex = 1;
            this.lblFim.Tag = "";
            this.lblFim.Text = "Fim";
            // 
            // dtInicio
            // 
            this.dtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsReserva, "DataHoraInicio", true));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(3, 55);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(207, 20);
            this.dtInicio.TabIndex = 22;
            // 
            // bsReserva
            // 
            this.bsReserva.DataSource = typeof(Portaria.Core.Model.Reserva);
            // 
            // dtFim
            // 
            this.dtFim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFim.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsReserva, "DataHoraFim", true));
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFim.Location = new System.Drawing.Point(254, 55);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(208, 20);
            this.dtFim.TabIndex = 23;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(3, 0);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 24;
            this.lblLocal.Text = "Local";
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.Location = new System.Drawing.Point(3, 16);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(207, 20);
            this.txtLocal.TabIndex = 25;
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Location = new System.Drawing.Point(3, 78);
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(56, 13);
            this.lblSolicitante.TabIndex = 26;
            this.lblSolicitante.Text = "Solicitante";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolicitante.Location = new System.Drawing.Point(3, 94);
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.ReadOnly = true;
            this.txtSolicitante.Size = new System.Drawing.Size(207, 20);
            this.txtSolicitante.TabIndex = 27;
            // 
            // botaoEditarSolicitante
            // 
            this.botaoEditarSolicitante.AutoSize = true;
            this.botaoEditarSolicitante.BackColor = System.Drawing.Color.White;
            this.botaoEditarSolicitante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditarSolicitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEditarSolicitante.Image = ((System.Drawing.Image)(resources.GetObject("botaoEditarSolicitante.Image")));
            this.botaoEditarSolicitante.Location = new System.Drawing.Point(216, 94);
            this.botaoEditarSolicitante.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarSolicitante.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarSolicitante.Name = "botaoEditarSolicitante";
            this.botaoEditarSolicitante.Size = new System.Drawing.Size(24, 24);
            this.botaoEditarSolicitante.TabIndex = 28;
            this.botaoEditarSolicitante.UseVisualStyleBackColor = true;
            this.botaoEditarSolicitante.Click += new System.EventHandler(this.botaoEditarSolicitante_Click);
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Location = new System.Drawing.Point(3, 121);
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(47, 13);
            this.lblUnidade.TabIndex = 29;
            this.lblUnidade.Text = "Unidade";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnidade.Location = new System.Drawing.Point(3, 143);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.ReadOnly = true;
            this.txtUnidade.Size = new System.Drawing.Size(207, 20);
            this.txtUnidade.TabIndex = 30;
            // 
            // botaoPesquisarUnidade
            // 
            this.botaoPesquisarUnidade.AutoSize = true;
            this.botaoPesquisarUnidade.BackColor = System.Drawing.Color.White;
            this.botaoPesquisarUnidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisarUnidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPesquisarUnidade.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisarUnidade.Image")));
            this.botaoPesquisarUnidade.Location = new System.Drawing.Point(216, 137);
            this.botaoPesquisarUnidade.MaximumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisarUnidade.MinimumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisarUnidade.Name = "botaoPesquisarUnidade";
            this.botaoPesquisarUnidade.Size = new System.Drawing.Size(32, 32);
            this.botaoPesquisarUnidade.TabIndex = 31;
            this.botaoPesquisarUnidade.UseVisualStyleBackColor = false;
            this.botaoPesquisarUnidade.Click += new System.EventHandler(this.botaoPesquisarUnidade_Click);
            // 
            // CadReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 291);
            this.ConfiguracoesUsuarioVisivel = true;
            this.MaximumSize = new System.Drawing.Size(471, 291);
            this.MinimumSize = new System.Drawing.Size(471, 291);
            this.Name = "CadReserva";
            this.Text = "CadReserva";
            this.Titulo = "Cadastro de Reserva";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            this.tlpBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bsReserva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private Portaria.Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private Portaria.Desktop.Framework.Botoes.BotaoSalvar botaoSalvar;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Label lblFim;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label lblSolicitante;
        private System.Windows.Forms.TextBox txtSolicitante;
        private Portaria.Desktop.Framework.Botoes.BotaoEditar botaoEditarSolicitante;
        private System.Windows.Forms.BindingSource bsReserva;
        private System.Windows.Forms.Label lblUnidade;
        private System.Windows.Forms.TextBox txtUnidade;
        private Portaria.Desktop.Framework.Botoes.BotaoPesquisar botaoPesquisarUnidade;
    }
}
namespace Portaria.LivroNegro
{
    partial class CadRegistroLivroNegro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadRegistroLivroNegro));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.rtbMensagem = new System.Windows.Forms.RichTextBox();
            this.tlpBotoes = new System.Windows.Forms.TableLayoutPanel();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.botaoSalvar = new Portaria.Desktop.Framework.Botoes.BotaoSalvar();
            this.lblData = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblPessoa = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.botaoEditarPessoa = new Portaria.Desktop.Framework.Botoes.BotaoEditar();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoAdicionar = new Portaria.Desktop.Framework.Botoes.BotaoAdicionar();
            this.botaoRemover = new Portaria.Desktop.Framework.Botoes.BotaoRemover();
            this.dgvEntidades = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEntidades = new System.Windows.Forms.BindingSource(this.components);
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            this.tlpBotoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntidades)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(738, 382);
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 4;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.157F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.13013F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampos.Controls.Add(this.lblMensagem, 0, 5);
            this.tlpCampos.Controls.Add(this.rtbMensagem, 0, 6);
            this.tlpCampos.Controls.Add(this.tlpBotoes, 2, 13);
            this.tlpCampos.Controls.Add(this.lblData, 0, 1);
            this.tlpCampos.Controls.Add(this.lblUsuario, 1, 1);
            this.tlpCampos.Controls.Add(this.lblPessoa, 0, 3);
            this.tlpCampos.Controls.Add(this.txtUsuario, 1, 2);
            this.tlpCampos.Controls.Add(this.txtData, 0, 2);
            this.tlpCampos.Controls.Add(this.txtNomePessoa, 0, 4);
            this.tlpCampos.Controls.Add(this.botaoEditarPessoa, 1, 4);
            this.tlpCampos.Controls.Add(this.label1, 2, 1);
            this.tlpCampos.Controls.Add(this.botaoAdicionar, 3, 2);
            this.tlpCampos.Controls.Add(this.botaoRemover, 3, 4);
            this.tlpCampos.Controls.Add(this.dgvEntidades, 2, 2);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(0, 0);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 14;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.Size = new System.Drawing.Size(738, 382);
            this.tlpCampos.TabIndex = 2;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(3, 86);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(59, 13);
            this.lblMensagem.TabIndex = 0;
            this.lblMensagem.Text = "Mensagem";
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpCampos.SetColumnSpan(this.rtbMensagem, 3);
            this.rtbMensagem.Location = new System.Drawing.Point(3, 102);
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.Size = new System.Drawing.Size(701, 228);
            this.rtbMensagem.TabIndex = 22;
            this.rtbMensagem.Text = "";
            // 
            // tlpBotoes
            // 
            this.tlpBotoes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpBotoes.AutoSize = true;
            this.tlpBotoes.ColumnCount = 2;
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBotoes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpBotoes.Controls.Add(this.botaoCancelar, 1, 0);
            this.tlpBotoes.Controls.Add(this.botaoSalvar, 0, 0);
            this.tlpBotoes.Location = new System.Drawing.Point(492, 336);
            this.tlpBotoes.Name = "tlpBotoes";
            this.tlpBotoes.RowCount = 1;
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotoes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpBotoes.Size = new System.Drawing.Size(212, 43);
            this.tlpBotoes.TabIndex = 23;
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
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(3, 0);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(30, 13);
            this.lblData.TabIndex = 25;
            this.lblData.Text = "Data";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(206, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 26;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Location = new System.Drawing.Point(3, 43);
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(118, 13);
            this.lblPessoa.TabIndex = 27;
            this.lblPessoa.Text = "Solicitante/Reclamante";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(206, 16);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.ReadOnly = true;
            this.txtUsuario.Size = new System.Drawing.Size(186, 20);
            this.txtUsuario.TabIndex = 28;
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Location = new System.Drawing.Point(3, 16);
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(197, 20);
            this.txtData.TabIndex = 29;
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePessoa.Location = new System.Drawing.Point(3, 59);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.ReadOnly = true;
            this.txtNomePessoa.Size = new System.Drawing.Size(197, 20);
            this.txtNomePessoa.TabIndex = 30;
            // 
            // botaoEditarPessoa
            // 
            this.botaoEditarPessoa.AutoSize = true;
            this.botaoEditarPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditarPessoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEditarPessoa.Image = ((System.Drawing.Image)(resources.GetObject("botaoEditarPessoa.Image")));
            this.botaoEditarPessoa.Location = new System.Drawing.Point(206, 59);
            this.botaoEditarPessoa.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarPessoa.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarPessoa.Name = "botaoEditarPessoa";
            this.botaoEditarPessoa.Size = new System.Drawing.Size(24, 24);
            this.botaoEditarPessoa.TabIndex = 31;
            this.botaoEditarPessoa.UseVisualStyleBackColor = true;
            this.botaoEditarPessoa.Click += new System.EventHandler(this.botaoEditarPessoa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(398, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Entidades envolvidas";
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.AutoSize = true;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("botaoAdicionar.Image")));
            this.botaoAdicionar.Location = new System.Drawing.Point(710, 16);
            this.botaoAdicionar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.TabIndex = 24;
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // botaoRemover
            // 
            this.botaoRemover.AutoSize = true;
            this.botaoRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRemover.Image = ((System.Drawing.Image)(resources.GetObject("botaoRemover.Image")));
            this.botaoRemover.Location = new System.Drawing.Point(710, 59);
            this.botaoRemover.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(24, 24);
            this.botaoRemover.TabIndex = 34;
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // dgvEntidades
            // 
            this.dgvEntidades.AllowUserToResizeRows = false;
            this.dgvEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntidades.AutoGenerateColumns = false;
            this.dgvEntidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoEntidadeDataGridViewTextBoxColumn,
            this.descricaoEntidadeDataGridViewTextBoxColumn});
            this.dgvEntidades.DataSource = this.bsEntidades;
            this.dgvEntidades.Location = new System.Drawing.Point(398, 16);
            this.dgvEntidades.Name = "dgvEntidades";
            this.dgvEntidades.ReadOnly = true;
            this.dgvEntidades.RowHeadersVisible = false;
            this.tlpCampos.SetRowSpan(this.dgvEntidades, 4);
            this.dgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntidades.Size = new System.Drawing.Size(306, 80);
            this.dgvEntidades.TabIndex = 35;
            this.dgvEntidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntidades_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoEntidadeDataGridViewTextBoxColumn
            // 
            this.tipoEntidadeDataGridViewTextBoxColumn.DataPropertyName = "TipoEntidade";
            this.tipoEntidadeDataGridViewTextBoxColumn.HeaderText = "TipoEntidade";
            this.tipoEntidadeDataGridViewTextBoxColumn.Name = "tipoEntidadeDataGridViewTextBoxColumn";
            this.tipoEntidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoEntidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoEntidadeDataGridViewTextBoxColumn
            // 
            this.descricaoEntidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoEntidadeDataGridViewTextBoxColumn.DataPropertyName = "DescricaoEntidade";
            this.descricaoEntidadeDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoEntidadeDataGridViewTextBoxColumn.Name = "descricaoEntidadeDataGridViewTextBoxColumn";
            this.descricaoEntidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsEntidades
            // 
            this.bsEntidades.DataSource = typeof(Portaria.Core.Model.IEntidade);
            // 
            // CadRegistroLivroNegro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 445);
            this.MinimumSize = new System.Drawing.Size(744, 396);
            this.Name = "CadRegistroLivroNegro";
            this.Text = "CadRegistroLivroNegro";
            this.Titulo = "Registrar no livro negro";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            this.tlpBotoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.RichTextBox rtbMensagem;
        private System.Windows.Forms.TableLayoutPanel tlpBotoes;
        private Portaria.Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private Portaria.Desktop.Framework.Botoes.BotaoSalvar botaoSalvar;
        private Portaria.Desktop.Framework.Botoes.BotaoAdicionar botaoAdicionar;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblPessoa;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private Portaria.Desktop.Framework.Botoes.BotaoEditar botaoEditarPessoa;
        private System.Windows.Forms.Label label1;
        private Portaria.Desktop.Framework.Botoes.BotaoRemover botaoRemover;
        private System.Windows.Forms.DataGridView dgvEntidades;
        private System.Windows.Forms.BindingSource bsEntidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEntidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoEntidadeDataGridViewTextBoxColumn;
    }
}
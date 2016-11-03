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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadRegistroLivroNegro));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.rtbMensagem = new System.Windows.Forms.RichTextBox();
            this.dgvEntidades = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEntidades = new System.Windows.Forms.BindingSource(this.components);
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.lblData = new MaterialSkin.Controls.MaterialLabel();
            this.lblUsuario = new MaterialSkin.Controls.MaterialLabel();
            this.lblPessoa = new MaterialSkin.Controls.MaterialLabel();
            this.lblCategoria = new MaterialSkin.Controls.MaterialLabel();
            this.lblEntidades = new MaterialSkin.Controls.MaterialLabel();
            this.lblMensagem = new MaterialSkin.Controls.MaterialLabel();
            this.botaoEditarPessoa = new Portaria.Desktop.Framework.Botoes.BotaoPessoa();
            this.txtData = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtNomePessoa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.botaoAdicionar = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.botaoRemover = new Portaria.Desktop.Framework.Botoes.BotaoRemove();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntidades)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            // 
            // tlpCampos
            // 
            this.tlpCampos.BackColor = System.Drawing.Color.White;
            this.tlpCampos.ColumnCount = 5;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71287F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.23904F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.04809F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampos.Controls.Add(this.rtbMensagem, 0, 6);
            this.tlpCampos.Controls.Add(this.dgvEntidades, 3, 2);
            this.tlpCampos.Controls.Add(this.cboCategoria, 2, 4);
            this.tlpCampos.Controls.Add(this.lblData, 0, 1);
            this.tlpCampos.Controls.Add(this.lblUsuario, 2, 1);
            this.tlpCampos.Controls.Add(this.lblPessoa, 0, 3);
            this.tlpCampos.Controls.Add(this.lblCategoria, 2, 3);
            this.tlpCampos.Controls.Add(this.lblEntidades, 3, 1);
            this.tlpCampos.Controls.Add(this.lblMensagem, 0, 5);
            this.tlpCampos.Controls.Add(this.botaoEditarPessoa, 1, 4);
            this.tlpCampos.Controls.Add(this.txtData, 0, 2);
            this.tlpCampos.Controls.Add(this.txtUsuario, 2, 2);
            this.tlpCampos.Controls.Add(this.txtNomePessoa, 0, 4);
            this.tlpCampos.Controls.Add(this.botaoAdicionar, 4, 2);
            this.tlpCampos.Controls.Add(this.botaoRemover, 4, 3);
            this.tlpCampos.Controls.Add(this.panel1, 3, 13);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(0, 0);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 14;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.Size = new System.Drawing.Size(838, 430);
            this.tlpCampos.TabIndex = 2;
            // 
            // rtbMensagem
            // 
            this.rtbMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbMensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlpCampos.SetColumnSpan(this.rtbMensagem, 4);
            this.rtbMensagem.Location = new System.Drawing.Point(3, 131);
            this.rtbMensagem.Name = "rtbMensagem";
            this.rtbMensagem.Size = new System.Drawing.Size(801, 251);
            this.rtbMensagem.TabIndex = 22;
            this.rtbMensagem.Text = "";
            // 
            // dgvEntidades
            // 
            this.dgvEntidades.AllowUserToResizeRows = false;
            this.dgvEntidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntidades.AutoGenerateColumns = false;
            this.dgvEntidades.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tipoEntidadeDataGridViewTextBoxColumn,
            this.descricaoEntidadeDataGridViewTextBoxColumn});
            this.dgvEntidades.DataSource = this.bsEntidades;
            this.dgvEntidades.Location = new System.Drawing.Point(514, 22);
            this.dgvEntidades.Name = "dgvEntidades";
            this.dgvEntidades.ReadOnly = true;
            this.dgvEntidades.RowHeadersVisible = false;
            this.tlpCampos.SetRowSpan(this.dgvEntidades, 3);
            this.dgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntidades.Size = new System.Drawing.Size(290, 84);
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
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoria.BackColor = System.Drawing.SystemColors.Window;
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(256, 82);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(252, 27);
            this.cboCategoria.TabIndex = 37;
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Depth = 0;
            this.lblData.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblData.Location = new System.Drawing.Point(3, 0);
            this.lblData.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(40, 19);
            this.lblData.TabIndex = 38;
            this.lblData.Text = "Data";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Depth = 0;
            this.lblUsuario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Location = new System.Drawing.Point(256, 0);
            this.lblUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(61, 19);
            this.lblUsuario.TabIndex = 39;
            this.lblUsuario.Text = "Usuário";
            // 
            // lblPessoa
            // 
            this.lblPessoa.AutoSize = true;
            this.lblPessoa.Depth = 0;
            this.lblPessoa.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPessoa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPessoa.Location = new System.Drawing.Point(3, 49);
            this.lblPessoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPessoa.Name = "lblPessoa";
            this.lblPessoa.Size = new System.Drawing.Size(166, 19);
            this.lblPessoa.TabIndex = 40;
            this.lblPessoa.Text = "Solicitante/Reclamante";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Depth = 0;
            this.lblCategoria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblCategoria.Location = new System.Drawing.Point(256, 49);
            this.lblCategoria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(74, 19);
            this.lblCategoria.TabIndex = 41;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblEntidades
            // 
            this.lblEntidades.AutoSize = true;
            this.lblEntidades.Depth = 0;
            this.lblEntidades.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEntidades.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEntidades.Location = new System.Drawing.Point(514, 0);
            this.lblEntidades.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEntidades.Name = "lblEntidades";
            this.lblEntidades.Size = new System.Drawing.Size(151, 19);
            this.lblEntidades.TabIndex = 42;
            this.lblEntidades.Text = "Entidades Envolvidas";
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Depth = 0;
            this.lblMensagem.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensagem.Location = new System.Drawing.Point(3, 109);
            this.lblMensagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(83, 19);
            this.lblMensagem.TabIndex = 43;
            this.lblMensagem.Text = "Mensagem";
            // 
            // botaoEditarPessoa
            // 
            this.botaoEditarPessoa.BackColor = System.Drawing.Color.Transparent;
            this.botaoEditarPessoa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoEditarPessoa.BackgroundImage")));
            this.botaoEditarPessoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoEditarPessoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditarPessoa.Location = new System.Drawing.Point(226, 82);
            this.botaoEditarPessoa.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarPessoa.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarPessoa.Name = "botaoEditarPessoa";
            this.botaoEditarPessoa.Size = new System.Drawing.Size(24, 24);
            this.botaoEditarPessoa.TabIndex = 44;
            this.botaoEditarPessoa.Click += new System.EventHandler(this.botaoEditarPessoa_Click);
            // 
            // txtData
            // 
            this.txtData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtData.Depth = 0;
            this.txtData.Enabled = false;
            this.txtData.Hint = "";
            this.txtData.Location = new System.Drawing.Point(3, 22);
            this.txtData.MaxLength = 32767;
            this.txtData.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtData.Name = "txtData";
            this.txtData.PasswordChar = '\0';
            this.txtData.SelectedText = "";
            this.txtData.SelectionLength = 0;
            this.txtData.SelectionStart = 0;
            this.txtData.Size = new System.Drawing.Size(217, 23);
            this.txtData.TabIndex = 45;
            this.txtData.TabStop = false;
            this.txtData.UseSystemPasswordChar = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(256, 22);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(252, 23);
            this.txtUsuario.TabIndex = 46;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNomePessoa.Depth = 0;
            this.txtNomePessoa.Enabled = false;
            this.txtNomePessoa.Hint = "";
            this.txtNomePessoa.Location = new System.Drawing.Point(3, 82);
            this.txtNomePessoa.MaxLength = 32767;
            this.txtNomePessoa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.PasswordChar = '\0';
            this.txtNomePessoa.SelectedText = "";
            this.txtNomePessoa.SelectionLength = 0;
            this.txtNomePessoa.SelectionStart = 0;
            this.txtNomePessoa.Size = new System.Drawing.Size(217, 23);
            this.txtNomePessoa.TabIndex = 47;
            this.txtNomePessoa.TabStop = false;
            this.txtNomePessoa.UseSystemPasswordChar = false;
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.botaoAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdicionar.BackgroundImage")));
            this.botaoAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.Location = new System.Drawing.Point(810, 22);
            this.botaoAdicionar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.TabIndex = 48;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // botaoRemover
            // 
            this.botaoRemover.BackColor = System.Drawing.Color.Transparent;
            this.botaoRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRemover.BackgroundImage")));
            this.botaoRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemover.Location = new System.Drawing.Point(810, 52);
            this.botaoRemover.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(24, 24);
            this.botaoRemover.TabIndex = 49;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(119, 0);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(514, 388);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 39);
            this.panel1.TabIndex = 51;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(218, 0);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 51;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // CadRegistroLivroNegro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 515);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(849, 515);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(849, 515);
            this.Name = "CadRegistroLivroNegro";
            this.Sizable = false;
            this.Text = "Registrar no livro negro";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntidades)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.RichTextBox rtbMensagem;
        private System.Windows.Forms.DataGridView dgvEntidades;
        private System.Windows.Forms.BindingSource bsEntidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEntidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoEntidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboCategoria;
        private MaterialSkin.Controls.MaterialLabel lblData;
        private MaterialSkin.Controls.MaterialLabel lblUsuario;
        private MaterialSkin.Controls.MaterialLabel lblPessoa;
        private MaterialSkin.Controls.MaterialLabel lblCategoria;
        private MaterialSkin.Controls.MaterialLabel lblEntidades;
        private MaterialSkin.Controls.MaterialLabel lblMensagem;
        private Desktop.Framework.Botoes.BotaoPessoa botaoEditarPessoa;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtData;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNomePessoa;
        private Desktop.Framework.Botoes.BotaoAdd botaoAdicionar;
        private Desktop.Framework.Botoes.BotaoRemove botaoRemover;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
    }
}
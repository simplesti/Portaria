namespace Portaria.LivroNegro
{
    partial class TabVisualizarLivroNegro
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabVisualizarLivroNegro));
            this.chkSomente30 = new System.Windows.Forms.CheckBox();
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRegistros = new System.Windows.Forms.BindingSource(this.components);
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.botaoPesquisar = new Portaria.Desktop.Framework.Botoes.BotaoPesquisar();
            this.botaoAdicionar = new Portaria.Desktop.Framework.Botoes.BotaoAdicionar();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // chkSomente30
            // 
            this.chkSomente30.AutoSize = true;
            this.chkSomente30.Checked = true;
            this.chkSomente30.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSomente30.Location = new System.Drawing.Point(25, 74);
            this.chkSomente30.Name = "chkSomente30";
            this.chkSomente30.Size = new System.Drawing.Size(167, 17);
            this.chkSomente30.TabIndex = 1;
            this.chkSomente30.Text = "Exibir somente os 30 primeiros";
            this.chkSomente30.UseVisualStyleBackColor = true;
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToResizeRows = false;
            this.dgvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistros.AutoGenerateColumns = false;
            this.dgvRegistros.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sessaoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.mensagemDataGridViewTextBoxColumn,
            this.entidadesDataGridViewTextBoxColumn,
            this.tipoEntidadeDataGridViewTextBoxColumn,
            this.descricaoEntidadeDataGridViewTextBoxColumn});
            this.dgvRegistros.DataSource = this.bsRegistros;
            this.dgvRegistros.Location = new System.Drawing.Point(25, 97);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(563, 293);
            this.dgvRegistros.TabIndex = 3;
            this.dgvRegistros.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRegistros_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // sessaoDataGridViewTextBoxColumn
            // 
            this.sessaoDataGridViewTextBoxColumn.DataPropertyName = "Sessao";
            this.sessaoDataGridViewTextBoxColumn.HeaderText = "Sessao";
            this.sessaoDataGridViewTextBoxColumn.Name = "sessaoDataGridViewTextBoxColumn";
            this.sessaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sessaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "Data";
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mensagemDataGridViewTextBoxColumn
            // 
            this.mensagemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mensagemDataGridViewTextBoxColumn.DataPropertyName = "Mensagem";
            this.mensagemDataGridViewTextBoxColumn.HeaderText = "Mensagem";
            this.mensagemDataGridViewTextBoxColumn.Name = "mensagemDataGridViewTextBoxColumn";
            this.mensagemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // entidadesDataGridViewTextBoxColumn
            // 
            this.entidadesDataGridViewTextBoxColumn.DataPropertyName = "Entidades";
            this.entidadesDataGridViewTextBoxColumn.HeaderText = "Entidades";
            this.entidadesDataGridViewTextBoxColumn.Name = "entidadesDataGridViewTextBoxColumn";
            this.entidadesDataGridViewTextBoxColumn.ReadOnly = true;
            this.entidadesDataGridViewTextBoxColumn.Visible = false;
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
            this.descricaoEntidadeDataGridViewTextBoxColumn.DataPropertyName = "DescricaoEntidade";
            this.descricaoEntidadeDataGridViewTextBoxColumn.HeaderText = "DescricaoEntidade";
            this.descricaoEntidadeDataGridViewTextBoxColumn.Name = "descricaoEntidadeDataGridViewTextBoxColumn";
            this.descricaoEntidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.descricaoEntidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsRegistros
            // 
            this.bsRegistros.DataSource = typeof(Portaria.Core.Model.RegistroLivroNegro);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(25, 48);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(563, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(22, 32);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 10;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPesquisar.AutoSize = true;
            this.botaoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisar.Image")));
            this.botaoPesquisar.Location = new System.Drawing.Point(594, 41);
            this.botaoPesquisar.MaximumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.MinimumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.TabIndex = 2;
            this.botaoPesquisar.UseVisualStyleBackColor = true;
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoAdicionar.AutoSize = true;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("botaoAdicionar.Image")));
            this.botaoAdicionar.Location = new System.Drawing.Point(594, 97);
            this.botaoAdicionar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.TabIndex = 4;
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // TabVisualizarLivroNegro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.chkSomente30);
            this.Controls.Add(this.dgvRegistros);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.botaoPesquisar);
            this.Name = "TabVisualizarLivroNegro";
            this.Size = new System.Drawing.Size(641, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkSomente30;
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private Portaria.Desktop.Framework.Botoes.BotaoPesquisar botaoPesquisar;
        private System.Windows.Forms.BindingSource bsRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEntidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoEntidadeDataGridViewTextBoxColumn;
        private Portaria.Desktop.Framework.Botoes.BotaoAdicionar botaoAdicionar;
    }
}

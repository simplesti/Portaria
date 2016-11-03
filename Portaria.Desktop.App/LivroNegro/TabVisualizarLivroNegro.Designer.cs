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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabVisualizarLivroNegro));
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mensagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsRegistros = new System.Windows.Forms.BindingSource(this.components);
            this.botaoAdd = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.txtPesquisar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkSomente30 = new MaterialSkin.Controls.MaterialCheckBox();
            this.botaoSearch = new Portaria.Desktop.Framework.Botoes.BotaoSearch();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegistros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.AllowUserToAddRows = false;
            this.dgvRegistros.AllowUserToResizeRows = false;
            this.dgvRegistros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRegistros.AutoGenerateColumns = false;
            this.dgvRegistros.BackgroundColor = System.Drawing.Color.White;
            this.dgvRegistros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRegistros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegistros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegistros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sessaoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.mensagemDataGridViewTextBoxColumn,
            this.entidadesDataGridViewTextBoxColumn,
            this.tipoEntidadeDataGridViewTextBoxColumn,
            this.descricaoEntidadeDataGridViewTextBoxColumn,
            this.Categoria});
            this.dgvRegistros.DataSource = this.bsRegistros;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegistros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegistros.Location = new System.Drawing.Point(25, 100);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.ReadOnly = true;
            this.dgvRegistros.RowHeadersVisible = false;
            this.dgvRegistros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistros.Size = new System.Drawing.Size(580, 290);
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
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // bsRegistros
            // 
            this.bsRegistros.DataSource = typeof(Portaria.Core.Model.RegistroLivroNegro);
            // 
            // botaoAdd
            // 
            this.botaoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoAdd.BackColor = System.Drawing.Color.Transparent;
            this.botaoAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdd.BackgroundImage")));
            this.botaoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdd.Location = new System.Drawing.Point(611, 100);
            this.botaoAdd.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdd.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdd.Name = "botaoAdd";
            this.botaoAdd.Size = new System.Drawing.Size(24, 24);
            this.botaoAdd.TabIndex = 11;
            this.botaoAdd.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Depth = 0;
            this.txtPesquisar.Hint = "Entre com uma informação para pesquisar";
            this.txtPesquisar.Location = new System.Drawing.Point(25, 41);
            this.txtPesquisar.Mask = "";
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.Size = new System.Drawing.Size(580, 23);
            this.txtPesquisar.TabIndex = 13;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.UseSystemPasswordChar = false;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // chkSomente30
            // 
            this.chkSomente30.AutoSize = true;
            this.chkSomente30.Depth = 0;
            this.chkSomente30.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkSomente30.Location = new System.Drawing.Point(20, 67);
            this.chkSomente30.Margin = new System.Windows.Forms.Padding(0);
            this.chkSomente30.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSomente30.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSomente30.Name = "chkSomente30";
            this.chkSomente30.Ripple = true;
            this.chkSomente30.Size = new System.Drawing.Size(214, 30);
            this.chkSomente30.TabIndex = 14;
            this.chkSomente30.Text = "Exibir somente os 30 primeiro";
            this.chkSomente30.UseVisualStyleBackColor = true;
            // 
            // botaoSearch
            // 
            this.botaoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoSearch.BackColor = System.Drawing.Color.Transparent;
            this.botaoSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoSearch.BackgroundImage")));
            this.botaoSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSearch.Location = new System.Drawing.Point(611, 40);
            this.botaoSearch.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoSearch.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoSearch.Name = "botaoSearch";
            this.botaoSearch.Size = new System.Drawing.Size(24, 24);
            this.botaoSearch.TabIndex = 15;
            this.botaoSearch.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // TabVisualizarLivroNegro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoSearch);
            this.Controls.Add(this.chkSomente30);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.botaoAdd);
            this.Controls.Add(this.dgvRegistros);
            this.Name = "TabVisualizarLivroNegro";
            this.Size = new System.Drawing.Size(641, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRegistros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.BindingSource bsRegistros;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn entidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEntidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoEntidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private Desktop.Framework.Botoes.BotaoAdd botaoAdd;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisar;
        private MaterialSkin.Controls.MaterialCheckBox chkSomente30;
        private Desktop.Framework.Botoes.BotaoSearch botaoSearch;
    }
}

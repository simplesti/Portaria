namespace Portaria
{
    partial class SelecionaEntidade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionaEntidade));
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.dgvEntidades = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoEntidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsEntidades = new System.Windows.Forms.BindingSource(this.components);
            this.lblPesquisar = new MaterialSkin.Controls.MaterialLabel();
            this.txtPesquisar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblTipo = new MaterialSkin.Controls.MaterialLabel();
            this.botaoPesquisar = new Portaria.Desktop.Framework.Botoes.BotaoSearch();
            this.chkSomente30 = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSelecionar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntidades)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.btnSelecionar);
            this.pnlConteudo.Controls.Add(this.btnCancelar);
            this.pnlConteudo.Controls.Add(this.chkSomente30);
            this.pnlConteudo.Controls.Add(this.botaoPesquisar);
            this.pnlConteudo.Controls.Add(this.lblTipo);
            this.pnlConteudo.Controls.Add(this.txtPesquisar);
            this.pnlConteudo.Controls.Add(this.lblPesquisar);
            this.pnlConteudo.Controls.Add(this.dgvEntidades);
            this.pnlConteudo.Controls.Add(this.cboTipo);
            this.pnlConteudo.Size = new System.Drawing.Size(645, 410);
            // 
            // cboTipo
            // 
            this.cboTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipo.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(391, 39);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(206, 27);
            this.cboTipo.TabIndex = 1;
            // 
            // dgvEntidades
            // 
            this.dgvEntidades.AllowUserToAddRows = false;
            this.dgvEntidades.AllowUserToResizeRows = false;
            this.dgvEntidades.AutoGenerateColumns = false;
            this.dgvEntidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEntidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvEntidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEntidades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntidades.Location = new System.Drawing.Point(16, 98);
            this.dgvEntidades.Name = "dgvEntidades";
            this.dgvEntidades.ReadOnly = true;
            this.dgvEntidades.RowHeadersVisible = false;
            this.dgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntidades.Size = new System.Drawing.Size(611, 261);
            this.dgvEntidades.TabIndex = 3;
            this.dgvEntidades.SelectionChanged += new System.EventHandler(this.dgvEntidades_SelectionChanged);
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
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Depth = 0;
            this.lblPesquisar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPesquisar.Location = new System.Drawing.Point(12, 17);
            this.lblPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(76, 19);
            this.lblPesquisar.TabIndex = 8;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Depth = 0;
            this.txtPesquisar.Hint = "";
            this.txtPesquisar.Location = new System.Drawing.Point(16, 39);
            this.txtPesquisar.Mask = "";
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.Size = new System.Drawing.Size(360, 23);
            this.txtPesquisar.TabIndex = 9;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.UseSystemPasswordChar = false;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Depth = 0;
            this.lblTipo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipo.Location = new System.Drawing.Point(388, 17);
            this.lblTipo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(121, 19);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "Tipo de Entidade";
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.botaoPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPesquisar.BackgroundImage")));
            this.botaoPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisar.Location = new System.Drawing.Point(603, 42);
            this.botaoPesquisar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoPesquisar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(24, 24);
            this.botaoPesquisar.TabIndex = 11;
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // chkSomente30
            // 
            this.chkSomente30.AutoSize = true;
            this.chkSomente30.Depth = 0;
            this.chkSomente30.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkSomente30.Location = new System.Drawing.Point(9, 65);
            this.chkSomente30.Margin = new System.Windows.Forms.Padding(0);
            this.chkSomente30.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSomente30.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSomente30.Name = "chkSomente30";
            this.chkSomente30.Ripple = true;
            this.chkSomente30.Size = new System.Drawing.Size(221, 30);
            this.chkSomente30.TabIndex = 12;
            this.chkSomente30.Text = "Exibir somente os 30 primeiros";
            this.chkSomente30.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(418, 368);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.AutoSize = true;
            this.btnSelecionar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelecionar.Depth = 0;
            this.btnSelecionar.Icon = null;
            this.btnSelecionar.Location = new System.Drawing.Point(525, 368);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelecionar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Primary = true;
            this.btnSelecionar.Size = new System.Drawing.Size(102, 36);
            this.btnSelecionar.TabIndex = 14;
            this.btnSelecionar.Text = "Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = true;
            this.btnSelecionar.Click += new System.EventHandler(this.botaoOK_Click);
            // 
            // SelecionaEntidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(647, 478);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 478);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(647, 478);
            this.Name = "SelecionaEntidade";
            this.Sizable = false;
            this.Text = "Selecionar Entidade";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsEntidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.DataGridView dgvEntidades;
        private System.Windows.Forms.BindingSource bsEntidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEntidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoEntidadeDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialLabel lblPesquisar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisar;
        private MaterialSkin.Controls.MaterialLabel lblTipo;
        private Desktop.Framework.Botoes.BotaoSearch botaoPesquisar;
        private MaterialSkin.Controls.MaterialCheckBox chkSomente30;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton btnSelecionar;
    }
}
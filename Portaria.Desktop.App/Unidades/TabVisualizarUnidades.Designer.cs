namespace Portaria
{
    partial class TabVisualizarUnidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabVisualizarUnidades));
            this.flpUnidades = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.dgvUnidadesDetalhadas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blocoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conjugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.botaoSearch = new Portaria.Desktop.Framework.Botoes.BotaoSearch();
            this.txtPesquisar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkSomente30 = new MaterialSkin.Controls.MaterialCheckBox();
            this.botaoViewMode = new Portaria.Desktop.Framework.Botoes.BotaoViewMode();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadesDetalhadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flpUnidades
            // 
            this.flpUnidades.Location = new System.Drawing.Point(14, 0);
            this.flpUnidades.Name = "flpUnidades";
            this.flpUnidades.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flpUnidades.Size = new System.Drawing.Size(654, 339);
            this.flpUnidades.TabIndex = 3;
            // 
            // pnlBase
            // 
            this.pnlBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBase.Controls.Add(this.dgvUnidadesDetalhadas);
            this.pnlBase.Controls.Add(this.flpUnidades);
            this.pnlBase.Location = new System.Drawing.Point(3, 84);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(675, 354);
            this.pnlBase.TabIndex = 5;
            // 
            // dgvUnidadesDetalhadas
            // 
            this.dgvUnidadesDetalhadas.AllowUserToAddRows = false;
            this.dgvUnidadesDetalhadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnidadesDetalhadas.AutoGenerateColumns = false;
            this.dgvUnidadesDetalhadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnidadesDetalhadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnidadesDetalhadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnidadesDetalhadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnidadesDetalhadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnidadesDetalhadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidadesDetalhadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.blocoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.proprietarioDataGridViewTextBoxColumn,
            this.conjugeDataGridViewTextBoxColumn,
            this.locatarioDataGridViewTextBoxColumn});
            this.dgvUnidadesDetalhadas.DataSource = this.unidadeBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnidadesDetalhadas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnidadesDetalhadas.Location = new System.Drawing.Point(14, 0);
            this.dgvUnidadesDetalhadas.Name = "dgvUnidadesDetalhadas";
            this.dgvUnidadesDetalhadas.ReadOnly = true;
            this.dgvUnidadesDetalhadas.RowHeadersVisible = false;
            this.dgvUnidadesDetalhadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidadesDetalhadas.Size = new System.Drawing.Size(654, 331);
            this.dgvUnidadesDetalhadas.TabIndex = 4;
            this.dgvUnidadesDetalhadas.Visible = false;
            this.dgvUnidadesDetalhadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidadesDetalhadas_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // blocoDataGridViewTextBoxColumn
            // 
            this.blocoDataGridViewTextBoxColumn.DataPropertyName = "Bloco";
            this.blocoDataGridViewTextBoxColumn.HeaderText = "Bloco";
            this.blocoDataGridViewTextBoxColumn.Name = "blocoDataGridViewTextBoxColumn";
            this.blocoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proprietarioDataGridViewTextBoxColumn
            // 
            this.proprietarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proprietarioDataGridViewTextBoxColumn.DataPropertyName = "Proprietario";
            this.proprietarioDataGridViewTextBoxColumn.HeaderText = "Proprietário";
            this.proprietarioDataGridViewTextBoxColumn.Name = "proprietarioDataGridViewTextBoxColumn";
            this.proprietarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conjugeDataGridViewTextBoxColumn
            // 
            this.conjugeDataGridViewTextBoxColumn.DataPropertyName = "Conjuge";
            this.conjugeDataGridViewTextBoxColumn.HeaderText = "Conjuge";
            this.conjugeDataGridViewTextBoxColumn.Name = "conjugeDataGridViewTextBoxColumn";
            this.conjugeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // locatarioDataGridViewTextBoxColumn
            // 
            this.locatarioDataGridViewTextBoxColumn.DataPropertyName = "Locatario";
            this.locatarioDataGridViewTextBoxColumn.HeaderText = "Locatário";
            this.locatarioDataGridViewTextBoxColumn.Name = "locatarioDataGridViewTextBoxColumn";
            this.locatarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadeBindingSource
            // 
            this.unidadeBindingSource.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Unidade);
            // 
            // botaoSearch
            // 
            this.botaoSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoSearch.BackColor = System.Drawing.Color.Transparent;
            this.botaoSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoSearch.BackgroundImage")));
            this.botaoSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSearch.Location = new System.Drawing.Point(647, 7);
            this.botaoSearch.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoSearch.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoSearch.Name = "botaoSearch";
            this.botaoSearch.Size = new System.Drawing.Size(24, 24);
            this.botaoSearch.TabIndex = 6;
            this.botaoSearch.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Depth = 0;
            this.txtPesquisar.Hint = "Entre com uma informação para pesquisar";
            this.txtPesquisar.Location = new System.Drawing.Point(17, 7);
            this.txtPesquisar.Mask = "";
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.Size = new System.Drawing.Size(624, 23);
            this.txtPesquisar.TabIndex = 7;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.UseSystemPasswordChar = false;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // chkSomente30
            // 
            this.chkSomente30.AutoSize = true;
            this.chkSomente30.Depth = 0;
            this.chkSomente30.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkSomente30.Location = new System.Drawing.Point(17, 43);
            this.chkSomente30.Margin = new System.Windows.Forms.Padding(0);
            this.chkSomente30.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSomente30.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSomente30.Name = "chkSomente30";
            this.chkSomente30.Ripple = true;
            this.chkSomente30.Size = new System.Drawing.Size(221, 30);
            this.chkSomente30.TabIndex = 8;
            this.chkSomente30.Text = "Exibir somente os 30 primeiros";
            this.chkSomente30.UseVisualStyleBackColor = true;
            // 
            // botaoViewMode
            // 
            this.botaoViewMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoViewMode.AutoSize = true;
            this.botaoViewMode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botaoViewMode.Depth = 0;
            this.botaoViewMode.Icon = ((System.Drawing.Image)(resources.GetObject("botaoViewMode.Icon")));
            this.botaoViewMode.Location = new System.Drawing.Point(510, 39);
            this.botaoViewMode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.botaoViewMode.MouseState = MaterialSkin.MouseState.OUT;
            this.botaoViewMode.Name = "botaoViewMode";
            this.botaoViewMode.Primary = false;
            this.botaoViewMode.Size = new System.Drawing.Size(131, 36);
            this.botaoViewMode.TabIndex = 9;
            this.botaoViewMode.Text = "Exibir Lista";
            this.botaoViewMode.UseVisualStyleBackColor = true;
            this.botaoViewMode.ViewList = false;
            this.botaoViewMode.Click += new System.EventHandler(this.botaoMudarVisao_Click);
            // 
            // TabVisualizarUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoViewMode);
            this.Controls.Add(this.chkSomente30);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.botaoSearch);
            this.Controls.Add(this.pnlBase);
            this.Name = "TabVisualizarUnidades";
            this.Size = new System.Drawing.Size(681, 441);
            this.pnlBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadesDetalhadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpUnidades;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.DataGridView dgvUnidadesDetalhadas;
        private System.Windows.Forms.BindingSource unidadeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blocoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conjugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatarioDataGridViewTextBoxColumn;
        private Desktop.Framework.Botoes.BotaoSearch botaoSearch;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisar;
        private MaterialSkin.Controls.MaterialCheckBox chkSomente30;
        private Desktop.Framework.Botoes.BotaoViewMode botaoViewMode;
    }
}

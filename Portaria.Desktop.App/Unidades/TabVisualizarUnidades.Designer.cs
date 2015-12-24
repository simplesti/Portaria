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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabVisualizarUnidades));
            this.flpUnidades = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSomente30 = new System.Windows.Forms.CheckBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.botaoPesquisar = new Portaria.Desktop.Framework.Botoes.BotaoPesquisar();
            this.botaoMudarVisao = new Portaria.Desktop.Framework.Botoes.BotaoMudarVisao();
            this.pnlBase = new System.Windows.Forms.Panel();
            this.dgvUnidadesDetalhadas = new System.Windows.Forms.DataGridView();
            this.unidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blocoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conjugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidadesDetalhadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // flpUnidades
            // 
            this.flpUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpUnidades.Location = new System.Drawing.Point(0, 0);
            this.flpUnidades.Name = "flpUnidades";
            this.flpUnidades.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flpUnidades.Size = new System.Drawing.Size(675, 354);
            this.flpUnidades.TabIndex = 3;
            // 
            // chkSomente30
            // 
            this.chkSomente30.AutoSize = true;
            this.chkSomente30.Checked = true;
            this.chkSomente30.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSomente30.Location = new System.Drawing.Point(55, 53);
            this.chkSomente30.Name = "chkSomente30";
            this.chkSomente30.Size = new System.Drawing.Size(167, 17);
            this.chkSomente30.TabIndex = 1;
            this.chkSomente30.Text = "Exibir somente os 30 primeiros";
            this.chkSomente30.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(0, 1);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 3;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisar.Location = new System.Drawing.Point(3, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(637, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoPesquisar.AutoSize = true;
            this.botaoPesquisar.BackColor = System.Drawing.Color.White;
            this.botaoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisar.Image")));
            this.botaoPesquisar.Location = new System.Drawing.Point(646, 10);
            this.botaoPesquisar.MaximumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.MinimumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.TabIndex = 2;
            this.botaoPesquisar.UseVisualStyleBackColor = true;
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // botaoMudarVisao
            // 
            this.botaoMudarVisao.BackColor = System.Drawing.Color.White;
            this.botaoMudarVisao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoMudarVisao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoMudarVisao.Image = ((System.Drawing.Image)(resources.GetObject("botaoMudarVisao.Image")));
            this.botaoMudarVisao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoMudarVisao.Location = new System.Drawing.Point(3, 43);
            this.botaoMudarVisao.Name = "botaoMudarVisao";
            this.botaoMudarVisao.Size = new System.Drawing.Size(46, 35);
            this.botaoMudarVisao.TabIndex = 4;
            this.botaoMudarVisao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoMudarVisao.UseVisualStyleBackColor = false;
            this.botaoMudarVisao.Click += new System.EventHandler(this.botaoMudarVisao_Click);
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
            this.dgvUnidadesDetalhadas.AutoGenerateColumns = false;
            this.dgvUnidadesDetalhadas.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvUnidadesDetalhadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidadesDetalhadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.blocoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.proprietarioDataGridViewTextBoxColumn,
            this.conjugeDataGridViewTextBoxColumn,
            this.locatarioDataGridViewTextBoxColumn});
            this.dgvUnidadesDetalhadas.DataSource = this.unidadeBindingSource;
            this.dgvUnidadesDetalhadas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnidadesDetalhadas.Location = new System.Drawing.Point(0, 0);
            this.dgvUnidadesDetalhadas.Name = "dgvUnidadesDetalhadas";
            this.dgvUnidadesDetalhadas.ReadOnly = true;
            this.dgvUnidadesDetalhadas.RowHeadersVisible = false;
            this.dgvUnidadesDetalhadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidadesDetalhadas.Size = new System.Drawing.Size(675, 354);
            this.dgvUnidadesDetalhadas.TabIndex = 4;
            this.dgvUnidadesDetalhadas.Visible = false;
            this.dgvUnidadesDetalhadas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidadesDetalhadas_CellDoubleClick);
            // 
            // unidadeBindingSource
            // 
            this.unidadeBindingSource.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Unidade);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // blocoDataGridViewTextBoxColumn
            // 
            this.blocoDataGridViewTextBoxColumn.DataPropertyName = "Bloco";
            this.blocoDataGridViewTextBoxColumn.HeaderText = "Bloco";
            this.blocoDataGridViewTextBoxColumn.Name = "blocoDataGridViewTextBoxColumn";
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "Numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Número";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            // 
            // proprietarioDataGridViewTextBoxColumn
            // 
            this.proprietarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proprietarioDataGridViewTextBoxColumn.DataPropertyName = "Proprietario";
            this.proprietarioDataGridViewTextBoxColumn.HeaderText = "Proprietário";
            this.proprietarioDataGridViewTextBoxColumn.Name = "proprietarioDataGridViewTextBoxColumn";
            // 
            // conjugeDataGridViewTextBoxColumn
            // 
            this.conjugeDataGridViewTextBoxColumn.DataPropertyName = "Conjuge";
            this.conjugeDataGridViewTextBoxColumn.HeaderText = "Conjuge";
            this.conjugeDataGridViewTextBoxColumn.Name = "conjugeDataGridViewTextBoxColumn";
            // 
            // locatarioDataGridViewTextBoxColumn
            // 
            this.locatarioDataGridViewTextBoxColumn.DataPropertyName = "Locatario";
            this.locatarioDataGridViewTextBoxColumn.HeaderText = "Locatário";
            this.locatarioDataGridViewTextBoxColumn.Name = "locatarioDataGridViewTextBoxColumn";
            // 
            // TabVisualizarUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlBase);
            this.Controls.Add(this.botaoMudarVisao);
            this.Controls.Add(this.botaoPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.chkSomente30);
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
        private System.Windows.Forms.CheckBox chkSomente30;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private Portaria.Desktop.Framework.Botoes.BotaoPesquisar botaoPesquisar;
        private Desktop.Framework.Botoes.BotaoMudarVisao botaoMudarVisao;
        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.DataGridView dgvUnidadesDetalhadas;
        private System.Windows.Forms.BindingSource unidadeBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blocoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conjugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatarioDataGridViewTextBoxColumn;
    }
}

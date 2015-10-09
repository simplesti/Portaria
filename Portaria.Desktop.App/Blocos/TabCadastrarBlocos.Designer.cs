namespace Portaria.Blocos
{
    partial class TabCadastrarBlocos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabCadastrarBlocos));
            this.botaoRemover = new Portaria.Desktop.Framework.Botoes.BotaoRemover();
            this.botaoAdicionar = new Portaria.Desktop.Framework.Botoes.BotaoAdicionar();
            this.dgvBlocos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBlocos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlocos)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoRemover
            // 
            this.botaoRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoRemover.AutoSize = true;
            this.botaoRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRemover.Image = ((System.Drawing.Image)(resources.GetObject("botaoRemover.Image")));
            this.botaoRemover.Location = new System.Drawing.Point(606, 73);
            this.botaoRemover.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(24, 24);
            this.botaoRemover.TabIndex = 5;
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoAdicionar.AutoSize = true;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("botaoAdicionar.Image")));
            this.botaoAdicionar.Location = new System.Drawing.Point(606, 43);
            this.botaoAdicionar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.TabIndex = 4;
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // dgvBlocos
            // 
            this.dgvBlocos.AllowUserToResizeRows = false;
            this.dgvBlocos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBlocos.AutoGenerateColumns = false;
            this.dgvBlocos.BackgroundColor = System.Drawing.Color.White;
            this.dgvBlocos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlocos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.unidadesDataGridViewTextBoxColumn});
            this.dgvBlocos.DataSource = this.bsBlocos;
            this.dgvBlocos.Location = new System.Drawing.Point(23, 43);
            this.dgvBlocos.Name = "dgvBlocos";
            this.dgvBlocos.ReadOnly = true;
            this.dgvBlocos.RowHeadersVisible = false;
            this.dgvBlocos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlocos.Size = new System.Drawing.Size(577, 337);
            this.dgvBlocos.TabIndex = 3;
            this.dgvBlocos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBlocos_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unidadesDataGridViewTextBoxColumn
            // 
            this.unidadesDataGridViewTextBoxColumn.DataPropertyName = "Unidades";
            this.unidadesDataGridViewTextBoxColumn.HeaderText = "Unidades";
            this.unidadesDataGridViewTextBoxColumn.Name = "unidadesDataGridViewTextBoxColumn";
            this.unidadesDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadesDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsBlocos
            // 
            this.bsBlocos.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Bloco);
            // 
            // TabCadastrarBlocos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.dgvBlocos);
            this.Name = "TabCadastrarBlocos";
            this.Size = new System.Drawing.Size(641, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlocos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Portaria.Desktop.Framework.Botoes.BotaoRemover botaoRemover;
        private Portaria.Desktop.Framework.Botoes.BotaoAdicionar botaoAdicionar;
        private System.Windows.Forms.DataGridView dgvBlocos;
        private System.Windows.Forms.BindingSource bsBlocos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesDataGridViewTextBoxColumn;
    }
}

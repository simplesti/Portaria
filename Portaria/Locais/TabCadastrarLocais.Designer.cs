namespace Portaria.Locais
{
    partial class TabCadastrarLocais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabCadastrarLocais));
            this.botaoRemover = new Portaria.Framework.Botoes.BotaoRemover();
            this.botaoAdicionar = new Portaria.Framework.Botoes.BotaoAdicionar();
            this.dgvLocais = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBlocos = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlocos)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoRemover
            // 
            this.botaoRemover.AutoSize = true;
            this.botaoRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRemover.Image = ((System.Drawing.Image)(resources.GetObject("botaoRemover.Image")));
            this.botaoRemover.Location = new System.Drawing.Point(605, 72);
            this.botaoRemover.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(24, 24);
            this.botaoRemover.TabIndex = 8;
            this.botaoRemover.UseVisualStyleBackColor = true;
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.AutoSize = true;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("botaoAdicionar.Image")));
            this.botaoAdicionar.Location = new System.Drawing.Point(605, 42);
            this.botaoAdicionar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.TabIndex = 7;
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            // 
            // dgvLocais
            // 
            this.dgvLocais.AllowUserToResizeRows = false;
            this.dgvLocais.AutoGenerateColumns = false;
            this.dgvLocais.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.unidadesDataGridViewTextBoxColumn});
            this.dgvLocais.DataSource = this.bsBlocos;
            this.dgvLocais.Location = new System.Drawing.Point(22, 42);
            this.dgvLocais.Name = "dgvLocais";
            this.dgvLocais.ReadOnly = true;
            this.dgvLocais.RowHeadersVisible = false;
            this.dgvLocais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocais.Size = new System.Drawing.Size(577, 337);
            this.dgvLocais.TabIndex = 6;
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
            // TabCadastrarLocais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.dgvLocais);
            this.Name = "TabCadastrarLocais";
            this.Size = new System.Drawing.Size(641, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlocos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.Botoes.BotaoRemover botaoRemover;
        private Framework.Botoes.BotaoAdicionar botaoAdicionar;
        private System.Windows.Forms.DataGridView dgvLocais;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsBlocos;
    }
}

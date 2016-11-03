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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabCadastrarLocais));
            this.dgvLocais = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.bsLocais = new System.Windows.Forms.BindingSource(this.components);
            this.botaoRemove = new Portaria.Desktop.Framework.Botoes.BotaoRemove();
            this.botaoAdd = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLocais
            // 
            this.dgvLocais.AllowUserToAddRows = false;
            this.dgvLocais.AllowUserToResizeRows = false;
            this.dgvLocais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLocais.AutoGenerateColumns = false;
            this.dgvLocais.BackgroundColor = System.Drawing.Color.White;
            this.dgvLocais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLocais.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvLocais.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLocais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLocais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn});
            this.dgvLocais.DataSource = this.bsLocais;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLocais.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLocais.Location = new System.Drawing.Point(25, 25);
            this.dgvLocais.Name = "dgvLocais";
            this.dgvLocais.ReadOnly = true;
            this.dgvLocais.RowHeadersVisible = false;
            this.dgvLocais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLocais.Size = new System.Drawing.Size(580, 350);
            this.dgvLocais.TabIndex = 6;
            this.dgvLocais.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLocais_CellDoubleClick);
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
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            this.fotoDataGridViewImageColumn.Visible = false;
            // 
            // bsLocais
            // 
            this.bsLocais.DataSource = typeof(Portaria.Core.Model.Cadastro.Local);
            // 
            // botaoRemove
            // 
            this.botaoRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoRemove.BackColor = System.Drawing.Color.Transparent;
            this.botaoRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRemove.BackgroundImage")));
            this.botaoRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemove.Location = new System.Drawing.Point(611, 55);
            this.botaoRemove.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemove.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemove.Name = "botaoRemove";
            this.botaoRemove.Size = new System.Drawing.Size(24, 24);
            this.botaoRemove.TabIndex = 7;
            this.botaoRemove.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // botaoAdd
            // 
            this.botaoAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoAdd.BackColor = System.Drawing.Color.Transparent;
            this.botaoAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdd.BackgroundImage")));
            this.botaoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdd.Location = new System.Drawing.Point(611, 25);
            this.botaoAdd.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdd.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdd.Name = "botaoAdd";
            this.botaoAdd.Size = new System.Drawing.Size(24, 24);
            this.botaoAdd.TabIndex = 8;
            this.botaoAdd.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // TabCadastrarLocais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoAdd);
            this.Controls.Add(this.botaoRemove);
            this.Controls.Add(this.dgvLocais);
            this.Name = "TabCadastrarLocais";
            this.Size = new System.Drawing.Size(641, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsLocais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLocais;
        private System.Windows.Forms.BindingSource bsLocais;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private Desktop.Framework.Botoes.BotaoRemove botaoRemove;
        private Desktop.Framework.Botoes.BotaoAdd botaoAdd;
    }
}

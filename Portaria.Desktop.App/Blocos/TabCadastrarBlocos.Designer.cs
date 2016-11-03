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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabCadastrarBlocos));
            this.dgvBlocos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsBlocos = new System.Windows.Forms.BindingSource(this.components);
            this.botaoAdd = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.botaoRemove = new Portaria.Desktop.Framework.Botoes.BotaoRemove();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlocos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBlocos
            // 
            this.dgvBlocos.AllowUserToAddRows = false;
            this.dgvBlocos.AllowUserToResizeRows = false;
            this.dgvBlocos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvBlocos.AutoGenerateColumns = false;
            this.dgvBlocos.BackgroundColor = System.Drawing.Color.White;
            this.dgvBlocos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBlocos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvBlocos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBlocos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBlocos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlocos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.unidadesDataGridViewTextBoxColumn});
            this.dgvBlocos.DataSource = this.bsBlocos;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBlocos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBlocos.Location = new System.Drawing.Point(25, 25);
            this.dgvBlocos.Name = "dgvBlocos";
            this.dgvBlocos.ReadOnly = true;
            this.dgvBlocos.RowHeadersVisible = false;
            this.dgvBlocos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBlocos.Size = new System.Drawing.Size(580, 350);
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
            this.botaoAdd.TabIndex = 4;
            this.botaoAdd.Click += new System.EventHandler(this.botaoAdicionar_Click);
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
            this.botaoRemove.TabIndex = 5;
            this.botaoRemove.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // TabCadastrarBlocos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoRemove);
            this.Controls.Add(this.botaoAdd);
            this.Controls.Add(this.dgvBlocos);
            this.Name = "TabCadastrarBlocos";
            this.Size = new System.Drawing.Size(641, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlocos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBlocos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBlocos;
        private System.Windows.Forms.BindingSource bsBlocos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesDataGridViewTextBoxColumn;
        private Desktop.Framework.Botoes.BotaoAdd botaoAdd;
        private Desktop.Framework.Botoes.BotaoRemove botaoRemove;
    }
}

namespace Portaria.Unidades
{
    partial class TabCadastrarUnidades
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabCadastrarUnidades));
            this.dgvUnidades = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.blocoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aparelhosGasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacoesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataAtualizacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conjugeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locatarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizadosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.animaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assinaturasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsUnidades = new System.Windows.Forms.BindingSource(this.components);
            this.botaoAdd = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.botaoRemove = new Portaria.Desktop.Framework.Botoes.BotaoRemove();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.AllowUserToAddRows = false;
            this.dgvUnidades.AllowUserToResizeRows = false;
            this.dgvUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnidades.AutoGenerateColumns = false;
            this.dgvUnidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvUnidades.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUnidades.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvUnidades.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUnidades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUnidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.blocoDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.aparelhosGasDataGridViewTextBoxColumn,
            this.observacoesDataGridViewTextBoxColumn,
            this.dataAtualizacaoDataGridViewTextBoxColumn,
            this.proprietarioDataGridViewTextBoxColumn,
            this.conjugeDataGridViewTextBoxColumn,
            this.locatarioDataGridViewTextBoxColumn,
            this.autorizadosDataGridViewTextBoxColumn,
            this.funcionariosDataGridViewTextBoxColumn,
            this.animaisDataGridViewTextBoxColumn,
            this.veiculosDataGridViewTextBoxColumn,
            this.assinaturasDataGridViewTextBoxColumn});
            this.dgvUnidades.DataSource = this.bsUnidades;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUnidades.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUnidades.Location = new System.Drawing.Point(25, 25);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.ReadOnly = true;
            this.dgvUnidades.RowHeadersVisible = false;
            this.dgvUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidades.Size = new System.Drawing.Size(580, 350);
            this.dgvUnidades.TabIndex = 6;
            this.dgvUnidades.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnidades_CellDoubleClick);
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
            this.numeroDataGridViewTextBoxColumn.HeaderText = "Numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // aparelhosGasDataGridViewTextBoxColumn
            // 
            this.aparelhosGasDataGridViewTextBoxColumn.DataPropertyName = "AparelhosGas";
            this.aparelhosGasDataGridViewTextBoxColumn.HeaderText = "AparelhosGas";
            this.aparelhosGasDataGridViewTextBoxColumn.Name = "aparelhosGasDataGridViewTextBoxColumn";
            this.aparelhosGasDataGridViewTextBoxColumn.ReadOnly = true;
            this.aparelhosGasDataGridViewTextBoxColumn.Visible = false;
            // 
            // observacoesDataGridViewTextBoxColumn
            // 
            this.observacoesDataGridViewTextBoxColumn.DataPropertyName = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.HeaderText = "Observacoes";
            this.observacoesDataGridViewTextBoxColumn.Name = "observacoesDataGridViewTextBoxColumn";
            this.observacoesDataGridViewTextBoxColumn.ReadOnly = true;
            this.observacoesDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataAtualizacaoDataGridViewTextBoxColumn
            // 
            this.dataAtualizacaoDataGridViewTextBoxColumn.DataPropertyName = "DataAtualizacao";
            this.dataAtualizacaoDataGridViewTextBoxColumn.HeaderText = "DataAtualizacao";
            this.dataAtualizacaoDataGridViewTextBoxColumn.Name = "dataAtualizacaoDataGridViewTextBoxColumn";
            this.dataAtualizacaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataAtualizacaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // proprietarioDataGridViewTextBoxColumn
            // 
            this.proprietarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.proprietarioDataGridViewTextBoxColumn.DataPropertyName = "Proprietario";
            this.proprietarioDataGridViewTextBoxColumn.HeaderText = "Proprietario";
            this.proprietarioDataGridViewTextBoxColumn.Name = "proprietarioDataGridViewTextBoxColumn";
            this.proprietarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conjugeDataGridViewTextBoxColumn
            // 
            this.conjugeDataGridViewTextBoxColumn.DataPropertyName = "Conjuge";
            this.conjugeDataGridViewTextBoxColumn.HeaderText = "Conjuge";
            this.conjugeDataGridViewTextBoxColumn.Name = "conjugeDataGridViewTextBoxColumn";
            this.conjugeDataGridViewTextBoxColumn.ReadOnly = true;
            this.conjugeDataGridViewTextBoxColumn.Visible = false;
            // 
            // locatarioDataGridViewTextBoxColumn
            // 
            this.locatarioDataGridViewTextBoxColumn.DataPropertyName = "Locatario";
            this.locatarioDataGridViewTextBoxColumn.HeaderText = "Locatario";
            this.locatarioDataGridViewTextBoxColumn.Name = "locatarioDataGridViewTextBoxColumn";
            this.locatarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.locatarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // autorizadosDataGridViewTextBoxColumn
            // 
            this.autorizadosDataGridViewTextBoxColumn.DataPropertyName = "Autorizados";
            this.autorizadosDataGridViewTextBoxColumn.HeaderText = "Autorizados";
            this.autorizadosDataGridViewTextBoxColumn.Name = "autorizadosDataGridViewTextBoxColumn";
            this.autorizadosDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorizadosDataGridViewTextBoxColumn.Visible = false;
            // 
            // funcionariosDataGridViewTextBoxColumn
            // 
            this.funcionariosDataGridViewTextBoxColumn.DataPropertyName = "Funcionarios";
            this.funcionariosDataGridViewTextBoxColumn.HeaderText = "Funcionarios";
            this.funcionariosDataGridViewTextBoxColumn.Name = "funcionariosDataGridViewTextBoxColumn";
            this.funcionariosDataGridViewTextBoxColumn.ReadOnly = true;
            this.funcionariosDataGridViewTextBoxColumn.Visible = false;
            // 
            // animaisDataGridViewTextBoxColumn
            // 
            this.animaisDataGridViewTextBoxColumn.DataPropertyName = "Animais";
            this.animaisDataGridViewTextBoxColumn.HeaderText = "Animais";
            this.animaisDataGridViewTextBoxColumn.Name = "animaisDataGridViewTextBoxColumn";
            this.animaisDataGridViewTextBoxColumn.ReadOnly = true;
            this.animaisDataGridViewTextBoxColumn.Visible = false;
            // 
            // veiculosDataGridViewTextBoxColumn
            // 
            this.veiculosDataGridViewTextBoxColumn.DataPropertyName = "Veiculos";
            this.veiculosDataGridViewTextBoxColumn.HeaderText = "Veiculos";
            this.veiculosDataGridViewTextBoxColumn.Name = "veiculosDataGridViewTextBoxColumn";
            this.veiculosDataGridViewTextBoxColumn.ReadOnly = true;
            this.veiculosDataGridViewTextBoxColumn.Visible = false;
            // 
            // assinaturasDataGridViewTextBoxColumn
            // 
            this.assinaturasDataGridViewTextBoxColumn.DataPropertyName = "Assinaturas";
            this.assinaturasDataGridViewTextBoxColumn.HeaderText = "Assinaturas";
            this.assinaturasDataGridViewTextBoxColumn.Name = "assinaturasDataGridViewTextBoxColumn";
            this.assinaturasDataGridViewTextBoxColumn.ReadOnly = true;
            this.assinaturasDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsUnidades
            // 
            this.bsUnidades.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Unidade);
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
            this.botaoAdd.TabIndex = 7;
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
            this.botaoRemove.TabIndex = 8;
            this.botaoRemove.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // TabCadastrarUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoRemove);
            this.Controls.Add(this.botaoAdd);
            this.Controls.Add(this.dgvUnidades);
            this.Name = "TabCadastrarUnidades";
            this.Size = new System.Drawing.Size(641, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUnidades;
        private System.Windows.Forms.BindingSource bsUnidades;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn blocoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aparelhosGasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacoesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataAtualizacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conjugeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locatarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorizadosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn funcionariosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn animaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assinaturasDataGridViewTextBoxColumn;
        private Desktop.Framework.Botoes.BotaoAdd botaoAdd;
        private Desktop.Framework.Botoes.BotaoRemove botaoRemove;
    }
}

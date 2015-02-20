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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabCadastrarUnidades));
            this.botaoRemover = new Portaria.Framework.Botoes.BotaoRemover();
            this.botaoAdicionar = new Portaria.Framework.Botoes.BotaoAdicionar();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnidades)).BeginInit();
            this.SuspendLayout();
            // 
            // botaoRemover
            // 
            this.botaoRemover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoRemover.AutoSize = true;
            this.botaoRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRemover.Image = ((System.Drawing.Image)(resources.GetObject("botaoRemover.Image")));
            this.botaoRemover.Location = new System.Drawing.Point(605, 71);
            this.botaoRemover.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(24, 24);
            this.botaoRemover.TabIndex = 8;
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
            this.botaoAdicionar.Location = new System.Drawing.Point(605, 41);
            this.botaoAdicionar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.TabIndex = 7;
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // dgvUnidades
            // 
            this.dgvUnidades.AllowUserToResizeRows = false;
            this.dgvUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUnidades.AutoGenerateColumns = false;
            this.dgvUnidades.BackgroundColor = System.Drawing.Color.White;
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
            this.dgvUnidades.Location = new System.Drawing.Point(22, 41);
            this.dgvUnidades.Name = "dgvUnidades";
            this.dgvUnidades.ReadOnly = true;
            this.dgvUnidades.RowHeadersVisible = false;
            this.dgvUnidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUnidades.Size = new System.Drawing.Size(577, 337);
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
            // TabCadastrarUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.dgvUnidades);
            this.Name = "TabCadastrarUnidades";
            this.Size = new System.Drawing.Size(641, 417);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnidades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Framework.Botoes.BotaoRemover botaoRemover;
        private Framework.Botoes.BotaoAdicionar botaoAdicionar;
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
    }
}

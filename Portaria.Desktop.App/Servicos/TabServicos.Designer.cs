namespace Portaria.Servicos
{
    partial class TabServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabServicos));
            this.dgvVisitantes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoServicoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.observacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsListaContatoServico = new System.Windows.Forms.BindingSource(this.components);
            this.txtPesquisa = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnPesquisar = new Portaria.Desktop.Framework.Botoes.BotaoSearch();
            this.botaoAddServico = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.lblTipoServico = new MaterialSkin.Controls.MaterialLabel();
            this.cboTipoServico = new System.Windows.Forms.ComboBox();
            this.lblPesquisar = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaContatoServico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVisitantes
            // 
            this.dgvVisitantes.AllowUserToAddRows = false;
            this.dgvVisitantes.AllowUserToDeleteRows = false;
            this.dgvVisitantes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVisitantes.AutoGenerateColumns = false;
            this.dgvVisitantes.BackgroundColor = System.Drawing.Color.White;
            this.dgvVisitantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVisitantes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVisitantes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVisitantes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVisitantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisitantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.tipoServicoDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.observacaoDataGridViewTextBoxColumn});
            this.dgvVisitantes.DataSource = this.bsListaContatoServico;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisitantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisitantes.Location = new System.Drawing.Point(42, 110);
            this.dgvVisitantes.Name = "dgvVisitantes";
            this.dgvVisitantes.RowHeadersVisible = false;
            this.dgvVisitantes.Size = new System.Drawing.Size(632, 341);
            this.dgvVisitantes.TabIndex = 0;
            this.dgvVisitantes.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvVisitantes_CellMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // tipoServicoDataGridViewTextBoxColumn
            // 
            this.tipoServicoDataGridViewTextBoxColumn.DataPropertyName = "TipoServico";
            this.tipoServicoDataGridViewTextBoxColumn.HeaderText = "Tipo de Serviço";
            this.tipoServicoDataGridViewTextBoxColumn.Name = "tipoServicoDataGridViewTextBoxColumn";
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            // 
            // observacaoDataGridViewTextBoxColumn
            // 
            this.observacaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.observacaoDataGridViewTextBoxColumn.DataPropertyName = "Observacao";
            this.observacaoDataGridViewTextBoxColumn.HeaderText = "Observação";
            this.observacaoDataGridViewTextBoxColumn.Name = "observacaoDataGridViewTextBoxColumn";
            // 
            // bsListaContatoServico
            // 
            this.bsListaContatoServico.DataSource = typeof(Portaria.Core.Model.ContatoServico);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisa.Depth = 0;
            this.txtPesquisa.Hint = "";
            this.txtPesquisa.Location = new System.Drawing.Point(42, 81);
            this.txtPesquisa.Mask = "";
            this.txtPesquisa.MaxLength = 32767;
            this.txtPesquisa.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PasswordChar = '\0';
            this.txtPesquisa.SelectedText = "";
            this.txtPesquisa.SelectionLength = 0;
            this.txtPesquisa.SelectionStart = 0;
            this.txtPesquisa.Size = new System.Drawing.Size(352, 23);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TabStop = false;
            this.txtPesquisa.UseSystemPasswordChar = false;
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisar.Location = new System.Drawing.Point(620, 80);
            this.btnPesquisar.MaximumSize = new System.Drawing.Size(24, 24);
            this.btnPesquisar.MinimumSize = new System.Drawing.Size(24, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(24, 24);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // botaoAddServico
            // 
            this.botaoAddServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoAddServico.BackColor = System.Drawing.Color.Transparent;
            this.botaoAddServico.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAddServico.BackgroundImage")));
            this.botaoAddServico.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAddServico.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAddServico.Location = new System.Drawing.Point(650, 81);
            this.botaoAddServico.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAddServico.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAddServico.Name = "botaoAddServico";
            this.botaoAddServico.Size = new System.Drawing.Size(24, 24);
            this.botaoAddServico.TabIndex = 3;
            this.botaoAddServico.Click += new System.EventHandler(this.botaoAddServico_Click);
            // 
            // lblTipoServico
            // 
            this.lblTipoServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipoServico.AutoSize = true;
            this.lblTipoServico.Depth = 0;
            this.lblTipoServico.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTipoServico.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTipoServico.Location = new System.Drawing.Point(406, 55);
            this.lblTipoServico.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTipoServico.Name = "lblTipoServico";
            this.lblTipoServico.Size = new System.Drawing.Size(113, 19);
            this.lblTipoServico.TabIndex = 40;
            this.lblTipoServico.Text = "Tipo de Serviço";
            // 
            // cboTipoServico
            // 
            this.cboTipoServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoServico.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoServico.FormattingEnabled = true;
            this.cboTipoServico.Location = new System.Drawing.Point(410, 77);
            this.cboTipoServico.Name = "cboTipoServico";
            this.cboTipoServico.Size = new System.Drawing.Size(195, 27);
            this.cboTipoServico.TabIndex = 39;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Depth = 0;
            this.lblPesquisar.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPesquisar.Location = new System.Drawing.Point(38, 55);
            this.lblPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(76, 19);
            this.lblPesquisar.TabIndex = 41;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // TabServicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.lblTipoServico);
            this.Controls.Add(this.cboTipoServico);
            this.Controls.Add(this.botaoAddServico);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.txtPesquisa);
            this.Controls.Add(this.dgvVisitantes);
            this.Name = "TabServicos";
            this.Size = new System.Drawing.Size(716, 464);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaContatoServico)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisitantes;
        private System.Windows.Forms.BindingSource bsListaContatoServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoServicoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn observacaoDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisa;
        private Desktop.Framework.Botoes.BotaoSearch btnPesquisar;
        private Desktop.Framework.Botoes.BotaoAdd botaoAddServico;
        private MaterialSkin.Controls.MaterialLabel lblTipoServico;
        private System.Windows.Forms.ComboBox cboTipoServico;
        private MaterialSkin.Controls.MaterialLabel lblPesquisar;
    }
}

namespace Portaria.Locais
{
    partial class VisReservas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisReservas));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.lblLocal = new System.Windows.Forms.Label();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.lblReservas = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsReservas = new System.Windows.Forms.BindingSource(this.components);
            this.botaoAdicionar = new Portaria.Desktop.Framework.Botoes.BotaoAdicionar();
            this.botaoRemover = new Portaria.Desktop.Framework.Botoes.BotaoRemover();
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(799, 440);
            // 
            // tlpCampos
            // 
            this.tlpCampos.ColumnCount = 3;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.62776F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.37224F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampos.Controls.Add(this.lblLocal, 0, 1);
            this.tlpCampos.Controls.Add(this.txtLocal, 0, 2);
            this.tlpCampos.Controls.Add(this.pbFoto, 0, 0);
            this.tlpCampos.Controls.Add(this.lblReservas, 0, 9);
            this.tlpCampos.Controls.Add(this.dgvReservas, 0, 10);
            this.tlpCampos.Controls.Add(this.botaoAdicionar, 2, 10);
            this.tlpCampos.Controls.Add(this.botaoRemover, 2, 11);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(0, 0);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 12;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.Size = new System.Drawing.Size(799, 440);
            this.tlpCampos.TabIndex = 2;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Location = new System.Drawing.Point(3, 156);
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(33, 13);
            this.lblLocal.TabIndex = 0;
            this.lblLocal.Text = "Local";
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.Location = new System.Drawing.Point(3, 172);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.ReadOnly = true;
            this.txtLocal.Size = new System.Drawing.Size(406, 20);
            this.txtLocal.TabIndex = 0;
            // 
            // pbFoto
            // 
            this.pbFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFoto.Location = new System.Drawing.Point(3, 3);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(406, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 12;
            this.pbFoto.TabStop = false;
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Location = new System.Drawing.Point(3, 195);
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(52, 13);
            this.lblReservas.TabIndex = 22;
            this.lblReservas.Text = "Reservas";
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservas.AutoGenerateColumns = false;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dataHoraDataGridViewTextBoxColumn,
            this.dataHoraInicioDataGridViewTextBoxColumn,
            this.dataHoraFimDataGridViewTextBoxColumn,
            this.localDataGridViewTextBoxColumn,
            this.pessoaDataGridViewTextBoxColumn,
            this.sessaoDataGridViewTextBoxColumn});
            this.tlpCampos.SetColumnSpan(this.dgvReservas, 2);
            this.dgvReservas.DataSource = this.bsReservas;
            this.dgvReservas.Location = new System.Drawing.Point(3, 211);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            this.dgvReservas.RowHeadersVisible = false;
            this.tlpCampos.SetRowSpan(this.dgvReservas, 2);
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(762, 226);
            this.dgvReservas.TabIndex = 23;
            this.dgvReservas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReservas_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "DataHora";
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "Reservado em";
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            this.dataHoraDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataHoraInicioDataGridViewTextBoxColumn
            // 
            this.dataHoraInicioDataGridViewTextBoxColumn.DataPropertyName = "DataHoraInicio";
            this.dataHoraInicioDataGridViewTextBoxColumn.HeaderText = "Início reserva";
            this.dataHoraInicioDataGridViewTextBoxColumn.Name = "dataHoraInicioDataGridViewTextBoxColumn";
            this.dataHoraInicioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataHoraFimDataGridViewTextBoxColumn
            // 
            this.dataHoraFimDataGridViewTextBoxColumn.DataPropertyName = "DataHoraFim";
            this.dataHoraFimDataGridViewTextBoxColumn.HeaderText = "Fim reserva";
            this.dataHoraFimDataGridViewTextBoxColumn.Name = "dataHoraFimDataGridViewTextBoxColumn";
            this.dataHoraFimDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // localDataGridViewTextBoxColumn
            // 
            this.localDataGridViewTextBoxColumn.DataPropertyName = "Local";
            this.localDataGridViewTextBoxColumn.HeaderText = "Local";
            this.localDataGridViewTextBoxColumn.Name = "localDataGridViewTextBoxColumn";
            this.localDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // pessoaDataGridViewTextBoxColumn
            // 
            this.pessoaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pessoaDataGridViewTextBoxColumn.DataPropertyName = "Pessoa";
            this.pessoaDataGridViewTextBoxColumn.HeaderText = "Pessoa";
            this.pessoaDataGridViewTextBoxColumn.Name = "pessoaDataGridViewTextBoxColumn";
            this.pessoaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sessaoDataGridViewTextBoxColumn
            // 
            this.sessaoDataGridViewTextBoxColumn.DataPropertyName = "Sessao";
            this.sessaoDataGridViewTextBoxColumn.HeaderText = "Sessao";
            this.sessaoDataGridViewTextBoxColumn.Name = "sessaoDataGridViewTextBoxColumn";
            this.sessaoDataGridViewTextBoxColumn.ReadOnly = true;
            this.sessaoDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsReservas
            // 
            this.bsReservas.DataSource = typeof(Portaria.Core.Model.Reserva);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.AutoSize = true;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("botaoAdicionar.Image")));
            this.botaoAdicionar.Location = new System.Drawing.Point(771, 211);
            this.botaoAdicionar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.TabIndex = 24;
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // botaoRemover
            // 
            this.botaoRemover.AutoSize = true;
            this.botaoRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoRemover.Image = ((System.Drawing.Image)(resources.GetObject("botaoRemover.Image")));
            this.botaoRemover.Location = new System.Drawing.Point(771, 241);
            this.botaoRemover.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(24, 24);
            this.botaoRemover.TabIndex = 25;
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // VisReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 503);
            this.Name = "VisReservas";
            this.Text = "CadReserva";
            this.Titulo = "Reservar Local";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.Label lblLocal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Label lblReservas;
        private System.Windows.Forms.DataGridView dgvReservas;
        private Portaria.Desktop.Framework.Botoes.BotaoAdicionar botaoAdicionar;
        private Portaria.Desktop.Framework.Botoes.BotaoRemover botaoRemover;
        private System.Windows.Forms.BindingSource bsReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessaoDataGridViewTextBoxColumn;

    }
}
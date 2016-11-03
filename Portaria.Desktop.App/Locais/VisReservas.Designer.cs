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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisReservas));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraFimDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pessoaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sessaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsReservas = new System.Windows.Forms.BindingSource(this.components);
            this.lblLocal = new MaterialSkin.Controls.MaterialLabel();
            this.txtLocal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblReservas = new MaterialSkin.Controls.MaterialLabel();
            this.botaoRemover = new Portaria.Desktop.Framework.Botoes.BotaoRemove();
            this.botaoAdicionar = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
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
            // 
            // tlpCampos
            // 
            this.tlpCampos.BackColor = System.Drawing.Color.White;
            this.tlpCampos.ColumnCount = 3;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.62776F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.37224F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampos.Controls.Add(this.pbFoto, 0, 0);
            this.tlpCampos.Controls.Add(this.dgvReservas, 0, 10);
            this.tlpCampos.Controls.Add(this.lblLocal, 0, 1);
            this.tlpCampos.Controls.Add(this.txtLocal, 0, 2);
            this.tlpCampos.Controls.Add(this.lblReservas, 0, 9);
            this.tlpCampos.Controls.Add(this.botaoRemover, 2, 11);
            this.tlpCampos.Controls.Add(this.botaoAdicionar, 2, 10);
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
            this.tlpCampos.Size = new System.Drawing.Size(838, 430);
            this.tlpCampos.TabIndex = 2;
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
            this.pbFoto.Size = new System.Drawing.Size(427, 150);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 12;
            this.pbFoto.TabStop = false;
            // 
            // dgvReservas
            // 
            this.dgvReservas.AllowUserToAddRows = false;
            this.dgvReservas.AllowUserToResizeRows = false;
            this.dgvReservas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReservas.AutoGenerateColumns = false;
            this.dgvReservas.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReservas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvReservas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReservas.Location = new System.Drawing.Point(3, 226);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservas.RowHeadersVisible = false;
            this.tlpCampos.SetRowSpan(this.dgvReservas, 2);
            this.dgvReservas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReservas.Size = new System.Drawing.Size(801, 201);
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
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Depth = 0;
            this.lblLocal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLocal.Location = new System.Drawing.Point(3, 156);
            this.lblLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(46, 19);
            this.lblLocal.TabIndex = 26;
            this.lblLocal.Text = "Local";
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.Depth = 0;
            this.txtLocal.Enabled = false;
            this.txtLocal.Hint = "";
            this.txtLocal.Location = new System.Drawing.Point(3, 178);
            this.txtLocal.Mask = "";
            this.txtLocal.MaxLength = 32767;
            this.txtLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.PasswordChar = '\0';
            this.txtLocal.SelectedText = "";
            this.txtLocal.SelectionLength = 0;
            this.txtLocal.SelectionStart = 0;
            this.txtLocal.Size = new System.Drawing.Size(427, 23);
            this.txtLocal.TabIndex = 27;
            this.txtLocal.TabStop = false;
            this.txtLocal.UseSystemPasswordChar = false;
            // 
            // lblReservas
            // 
            this.lblReservas.AutoSize = true;
            this.lblReservas.Depth = 0;
            this.lblReservas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblReservas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReservas.Location = new System.Drawing.Point(3, 204);
            this.lblReservas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblReservas.Name = "lblReservas";
            this.lblReservas.Size = new System.Drawing.Size(70, 19);
            this.lblReservas.TabIndex = 28;
            this.lblReservas.Text = "Reservas";
            // 
            // botaoRemover
            // 
            this.botaoRemover.BackColor = System.Drawing.Color.Transparent;
            this.botaoRemover.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRemover.BackgroundImage")));
            this.botaoRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemover.Location = new System.Drawing.Point(810, 256);
            this.botaoRemover.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(24, 24);
            this.botaoRemover.TabIndex = 29;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.BackColor = System.Drawing.Color.Transparent;
            this.botaoAdicionar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdicionar.BackgroundImage")));
            this.botaoAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.Location = new System.Drawing.Point(810, 226);
            this.botaoAdicionar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.TabIndex = 30;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // VisReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(849, 515);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(849, 515);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(849, 515);
            this.Name = "VisReservas";
            this.Sizable = false;
            this.Text = "Reservar Local";
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
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.BindingSource bsReservas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraFimDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pessoaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sessaoDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialLabel lblLocal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocal;
        private MaterialSkin.Controls.MaterialLabel lblReservas;
        private Desktop.Framework.Botoes.BotaoRemove botaoRemover;
        private Desktop.Framework.Botoes.BotaoAdd botaoAdicionar;
    }
}
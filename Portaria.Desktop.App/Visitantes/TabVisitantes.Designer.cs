namespace Portaria.Visitantes
{
    partial class TabVisitantes
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
            this.dgvVisitantes = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraChegadaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsListaVisitantes = new System.Windows.Forms.BindingSource(this.components);
            this.lblNome = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.bsVisitante = new System.Windows.Forms.BindingSource(this.components);
            this.rbtCPF = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtRG = new MaterialSkin.Controls.MaterialRadioButton();
            this.gbDoc = new System.Windows.Forms.GroupBox();
            this.lblDocumento = new MaterialSkin.Controls.MaterialLabel();
            this.txtDocumento = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblUnidade = new MaterialSkin.Controls.MaterialLabel();
            this.txtUnidade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnSelecionarUnidade = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNovo = new MaterialSkin.Controls.MaterialFlatButton();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.lblDtHrSaida = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaVisitantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisitante)).BeginInit();
            this.gbDoc.SuspendLayout();
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
            this.documentoDataGridViewTextBoxColumn,
            this.dataHoraChegadaDataGridViewTextBoxColumn,
            this.dataHoraSaidaDataGridViewTextBoxColumn,
            this.unidadeDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dgvVisitantes.DataSource = this.bsListaVisitantes;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVisitantes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVisitantes.Location = new System.Drawing.Point(42, 200);
            this.dgvVisitantes.Name = "dgvVisitantes";
            this.dgvVisitantes.RowHeadersVisible = false;
            this.dgvVisitantes.Size = new System.Drawing.Size(632, 261);
            this.dgvVisitantes.TabIndex = 0;
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
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.MinimumWidth = 150;
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.Width = 150;
            // 
            // dataHoraChegadaDataGridViewTextBoxColumn
            // 
            this.dataHoraChegadaDataGridViewTextBoxColumn.DataPropertyName = "DataHoraChegada";
            this.dataHoraChegadaDataGridViewTextBoxColumn.HeaderText = "Data / Hora de Chegada";
            this.dataHoraChegadaDataGridViewTextBoxColumn.Name = "dataHoraChegadaDataGridViewTextBoxColumn";
            // 
            // dataHoraSaidaDataGridViewTextBoxColumn
            // 
            this.dataHoraSaidaDataGridViewTextBoxColumn.DataPropertyName = "DataHoraSaida";
            this.dataHoraSaidaDataGridViewTextBoxColumn.HeaderText = "Data / Hora de Saída";
            this.dataHoraSaidaDataGridViewTextBoxColumn.Name = "dataHoraSaidaDataGridViewTextBoxColumn";
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            // 
            // bsListaVisitantes
            // 
            this.bsListaVisitantes.DataSource = typeof(Portaria.Core.Model.Visitante);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Depth = 0;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNome.Location = new System.Drawing.Point(38, 33);
            this.lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(50, 19);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisitante, "Nome", true));
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(42, 55);
            this.txtNome.Mask = "";
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(483, 23);
            this.txtNome.TabIndex = 2;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // bsVisitante
            // 
            this.bsVisitante.DataSource = typeof(Portaria.Core.Model.Visitante);
            // 
            // rbtCPF
            // 
            this.rbtCPF.AutoSize = true;
            this.rbtCPF.Depth = 0;
            this.rbtCPF.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtCPF.Location = new System.Drawing.Point(3, 15);
            this.rbtCPF.Margin = new System.Windows.Forms.Padding(0);
            this.rbtCPF.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtCPF.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtCPF.Name = "rbtCPF";
            this.rbtCPF.Ripple = true;
            this.rbtCPF.Size = new System.Drawing.Size(54, 30);
            this.rbtCPF.TabIndex = 4;
            this.rbtCPF.TabStop = true;
            this.rbtCPF.Text = "CPF";
            this.rbtCPF.UseVisualStyleBackColor = true;
            this.rbtCPF.CheckedChanged += new System.EventHandler(this.rbtCPF_CheckedChanged);
            // 
            // rbtRG
            // 
            this.rbtRG.AutoSize = true;
            this.rbtRG.Depth = 0;
            this.rbtRG.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtRG.Location = new System.Drawing.Point(66, 15);
            this.rbtRG.Margin = new System.Windows.Forms.Padding(0);
            this.rbtRG.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtRG.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtRG.Name = "rbtRG";
            this.rbtRG.Ripple = true;
            this.rbtRG.Size = new System.Drawing.Size(47, 30);
            this.rbtRG.TabIndex = 5;
            this.rbtRG.TabStop = true;
            this.rbtRG.Text = "RG";
            this.rbtRG.UseVisualStyleBackColor = true;
            this.rbtRG.CheckedChanged += new System.EventHandler(this.rbtRG_CheckedChanged);
            // 
            // gbDoc
            // 
            this.gbDoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDoc.Controls.Add(this.rbtRG);
            this.gbDoc.Controls.Add(this.rbtCPF);
            this.gbDoc.Location = new System.Drawing.Point(549, 22);
            this.gbDoc.Name = "gbDoc";
            this.gbDoc.Size = new System.Drawing.Size(125, 56);
            this.gbDoc.TabIndex = 6;
            this.gbDoc.TabStop = false;
            // 
            // lblDocumento
            // 
            this.lblDocumento.AutoSize = true;
            this.lblDocumento.Depth = 0;
            this.lblDocumento.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDocumento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDocumento.Location = new System.Drawing.Point(38, 81);
            this.lblDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDocumento.Name = "lblDocumento";
            this.lblDocumento.Size = new System.Drawing.Size(87, 19);
            this.lblDocumento.TabIndex = 7;
            this.lblDocumento.Text = "Documento";
            // 
            // txtDocumento
            // 
            this.txtDocumento.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDocumento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisitante, "Documento", true));
            this.txtDocumento.Depth = 0;
            this.txtDocumento.Hint = "";
            this.txtDocumento.Location = new System.Drawing.Point(42, 103);
            this.txtDocumento.Mask = "";
            this.txtDocumento.MaxLength = 32767;
            this.txtDocumento.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDocumento.Name = "txtDocumento";
            this.txtDocumento.PasswordChar = '\0';
            this.txtDocumento.SelectedText = "";
            this.txtDocumento.SelectionLength = 0;
            this.txtDocumento.SelectionStart = 0;
            this.txtDocumento.Size = new System.Drawing.Size(306, 23);
            this.txtDocumento.TabIndex = 8;
            this.txtDocumento.TabStop = false;
            this.txtDocumento.UseSystemPasswordChar = false;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(602, 149);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 9;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblUnidade
            // 
            this.lblUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Depth = 0;
            this.lblUnidade.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUnidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnidade.Location = new System.Drawing.Point(364, 81);
            this.lblUnidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(63, 19);
            this.lblUnidade.TabIndex = 10;
            this.lblUnidade.Text = "Unidade";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVisitante, "Unidade", true));
            this.txtUnidade.Depth = 0;
            this.txtUnidade.Enabled = false;
            this.txtUnidade.Hint = "";
            this.txtUnidade.Location = new System.Drawing.Point(368, 103);
            this.txtUnidade.Mask = "";
            this.txtUnidade.MaxLength = 32767;
            this.txtUnidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.PasswordChar = '\0';
            this.txtUnidade.SelectedText = "";
            this.txtUnidade.SelectionLength = 0;
            this.txtUnidade.SelectionStart = 0;
            this.txtUnidade.Size = new System.Drawing.Size(157, 23);
            this.txtUnidade.TabIndex = 11;
            this.txtUnidade.TabStop = false;
            this.txtUnidade.UseSystemPasswordChar = false;
            // 
            // btnSelecionarUnidade
            // 
            this.btnSelecionarUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelecionarUnidade.AutoSize = true;
            this.btnSelecionarUnidade.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSelecionarUnidade.Depth = 0;
            this.btnSelecionarUnidade.Icon = null;
            this.btnSelecionarUnidade.Location = new System.Drawing.Point(572, 90);
            this.btnSelecionarUnidade.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSelecionarUnidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSelecionarUnidade.Name = "btnSelecionarUnidade";
            this.btnSelecionarUnidade.Primary = false;
            this.btnSelecionarUnidade.Size = new System.Drawing.Size(102, 36);
            this.btnSelecionarUnidade.TabIndex = 12;
            this.btnSelecionarUnidade.Text = "Selecionar";
            this.btnSelecionarUnidade.UseVisualStyleBackColor = true;
            this.btnSelecionarUnidade.Click += new System.EventHandler(this.btnSelecionarUnidade_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNovo.AutoSize = true;
            this.btnNovo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNovo.Depth = 0;
            this.btnNovo.Icon = null;
            this.btnNovo.Location = new System.Drawing.Point(535, 149);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNovo.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Primary = false;
            this.btnNovo.Size = new System.Drawing.Size(59, 36);
            this.btnNovo.TabIndex = 13;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // dtInicio
            // 
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsVisitante, "DataHoraSaida", true));
            this.dtInicio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(42, 151);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(165, 26);
            this.dtInicio.TabIndex = 23;
            // 
            // lblDtHrSaida
            // 
            this.lblDtHrSaida.AutoSize = true;
            this.lblDtHrSaida.Depth = 0;
            this.lblDtHrSaida.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDtHrSaida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDtHrSaida.Location = new System.Drawing.Point(38, 129);
            this.lblDtHrSaida.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDtHrSaida.Name = "lblDtHrSaida";
            this.lblDtHrSaida.Size = new System.Drawing.Size(144, 19);
            this.lblDtHrSaida.TabIndex = 24;
            this.lblDtHrSaida.Text = "Data / hora de saída";
            // 
            // TabVisitantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblDtHrSaida);
            this.Controls.Add(this.dtInicio);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.btnSelecionarUnidade);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.lblUnidade);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtDocumento);
            this.Controls.Add(this.lblDocumento);
            this.Controls.Add(this.gbDoc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvVisitantes);
            this.Name = "TabVisitantes";
            this.Size = new System.Drawing.Size(716, 464);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsListaVisitantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVisitante)).EndInit();
            this.gbDoc.ResumeLayout(false);
            this.gbDoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVisitantes;
        private MaterialSkin.Controls.MaterialLabel lblNome;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialRadioButton rbtCPF;
        private MaterialSkin.Controls.MaterialRadioButton rbtRG;
        private System.Windows.Forms.GroupBox gbDoc;
        private MaterialSkin.Controls.MaterialLabel lblDocumento;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtDocumento;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialLabel lblUnidade;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUnidade;
        private MaterialSkin.Controls.MaterialFlatButton btnSelecionarUnidade;
        private MaterialSkin.Controls.MaterialFlatButton btnNovo;
        private System.Windows.Forms.BindingSource bsListaVisitantes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraChegadaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsVisitante;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private MaterialSkin.Controls.MaterialLabel lblDtHrSaida;
    }
}

namespace Portaria.Inicio
{
    partial class TabInicio
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabInicio));
            this.bolhaUnidades = new Portaria.Desktop.Framework.Inicio.BolhaInicio();
            this.bolhaVisitantes = new Portaria.Desktop.Framework.Inicio.BolhaInicio();
            this.bolhaReservas = new Portaria.Desktop.Framework.Inicio.BolhaInicio();
            this.bolhaServicos = new Portaria.Desktop.Framework.Inicio.BolhaInicio();
            this.bolhaReclamacoes = new Portaria.Desktop.Framework.Inicio.BolhaInicio();
            this.dgvMural = new System.Windows.Forms.DataGridView();
            this.mensagemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataHoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsMural = new System.Windows.Forms.BindingSource(this.components);
            this.txtMural = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.botaoAddMural = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMural)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMural)).BeginInit();
            this.SuspendLayout();
            // 
            // bolhaUnidades
            // 
            this.bolhaUnidades.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bolhaUnidades.BackColor = System.Drawing.Color.White;
            this.bolhaUnidades.Icone = global::Portaria.Properties.Resources.ic_location_city_white_48dp;
            this.bolhaUnidades.Location = new System.Drawing.Point(3, 3);
            this.bolhaUnidades.Name = "bolhaUnidades";
            this.bolhaUnidades.Size = new System.Drawing.Size(120, 120);
            this.bolhaUnidades.TabIndex = 0;
            this.bolhaUnidades.Texto = "Unidades";
            this.bolhaUnidades.Click += new System.EventHandler(this.bolhaUnidades_Click);
            // 
            // bolhaVisitantes
            // 
            this.bolhaVisitantes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bolhaVisitantes.BackColor = System.Drawing.Color.White;
            this.bolhaVisitantes.Icone = global::Portaria.Properties.Resources.ic_group_white_48dp;
            this.bolhaVisitantes.Location = new System.Drawing.Point(187, 3);
            this.bolhaVisitantes.Name = "bolhaVisitantes";
            this.bolhaVisitantes.Size = new System.Drawing.Size(120, 120);
            this.bolhaVisitantes.TabIndex = 1;
            this.bolhaVisitantes.Texto = "Visitantes";
            this.bolhaVisitantes.Click += new System.EventHandler(this.bolhaVisitantes_Click);
            // 
            // bolhaReservas
            // 
            this.bolhaReservas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bolhaReservas.BackColor = System.Drawing.Color.White;
            this.bolhaReservas.Icone = global::Portaria.Properties.Resources.ic_insert_invitation_white_48dp;
            this.bolhaReservas.Location = new System.Drawing.Point(371, 3);
            this.bolhaReservas.Name = "bolhaReservas";
            this.bolhaReservas.Size = new System.Drawing.Size(120, 120);
            this.bolhaReservas.TabIndex = 2;
            this.bolhaReservas.Texto = "Reservas";
            this.bolhaReservas.Click += new System.EventHandler(this.bolhaReserva_Click);
            // 
            // bolhaServicos
            // 
            this.bolhaServicos.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bolhaServicos.BackColor = System.Drawing.Color.White;
            this.bolhaServicos.Icone = global::Portaria.Properties.Resources.ic_contact_phone_white_48dp;
            this.bolhaServicos.Location = new System.Drawing.Point(555, 3);
            this.bolhaServicos.Name = "bolhaServicos";
            this.bolhaServicos.Size = new System.Drawing.Size(120, 120);
            this.bolhaServicos.TabIndex = 3;
            this.bolhaServicos.Texto = "Serviços";
            this.bolhaServicos.Click += new System.EventHandler(this.bolhaServicos_Click);
            // 
            // bolhaReclamacoes
            // 
            this.bolhaReclamacoes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bolhaReclamacoes.BackColor = System.Drawing.Color.White;
            this.bolhaReclamacoes.Icone = global::Portaria.Properties.Resources.ic_border_color_white_48dp;
            this.bolhaReclamacoes.Location = new System.Drawing.Point(739, 3);
            this.bolhaReclamacoes.Name = "bolhaReclamacoes";
            this.bolhaReclamacoes.Size = new System.Drawing.Size(120, 120);
            this.bolhaReclamacoes.TabIndex = 4;
            this.bolhaReclamacoes.Texto = "Reclamações";
            this.bolhaReclamacoes.Click += new System.EventHandler(this.bolhaLivroNegro_Click);
            // 
            // dgvMural
            // 
            this.dgvMural.AllowUserToAddRows = false;
            this.dgvMural.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMural.AutoGenerateColumns = false;
            this.dgvMural.BackgroundColor = System.Drawing.Color.White;
            this.dgvMural.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMural.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMural.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMural.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMural.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMural.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mensagemDataGridViewTextBoxColumn,
            this.dataHoraDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn});
            this.dgvMural.DataSource = this.bsMural;
            this.dgvMural.Location = new System.Drawing.Point(129, 178);
            this.dgvMural.Name = "dgvMural";
            this.dgvMural.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMural.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMural.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMural.Size = new System.Drawing.Size(604, 349);
            this.dgvMural.TabIndex = 5;
            // 
            // mensagemDataGridViewTextBoxColumn
            // 
            this.mensagemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mensagemDataGridViewTextBoxColumn.DataPropertyName = "Mensagem";
            this.mensagemDataGridViewTextBoxColumn.HeaderText = "Mensagem";
            this.mensagemDataGridViewTextBoxColumn.Name = "mensagemDataGridViewTextBoxColumn";
            this.mensagemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataHoraDataGridViewTextBoxColumn
            // 
            this.dataHoraDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataHoraDataGridViewTextBoxColumn.DataPropertyName = "DataHora";
            dataGridViewCellStyle2.Format = "g";
            dataGridViewCellStyle2.NullValue = null;
            this.dataHoraDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataHoraDataGridViewTextBoxColumn.HeaderText = "Data / Hora";
            this.dataHoraDataGridViewTextBoxColumn.Name = "dataHoraDataGridViewTextBoxColumn";
            this.dataHoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataHoraDataGridViewTextBoxColumn.Width = 112;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 86;
            // 
            // bsMural
            // 
            this.bsMural.DataSource = typeof(Portaria.Core.Model.RegistroMural);
            // 
            // txtMural
            // 
            this.txtMural.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMural.Depth = 0;
            this.txtMural.Hint = "Insira aqui uma mensagem para adicionar no mural";
            this.txtMural.Location = new System.Drawing.Point(129, 149);
            this.txtMural.Mask = "";
            this.txtMural.MaxLength = 32767;
            this.txtMural.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtMural.Name = "txtMural";
            this.txtMural.PasswordChar = '\0';
            this.txtMural.SelectedText = "";
            this.txtMural.SelectionLength = 0;
            this.txtMural.SelectionStart = 0;
            this.txtMural.Size = new System.Drawing.Size(574, 23);
            this.txtMural.TabIndex = 0;
            this.txtMural.TabStop = false;
            this.txtMural.UseSystemPasswordChar = false;
            this.txtMural.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMural_KeyPress);
            // 
            // botaoAddMural
            // 
            this.botaoAddMural.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoAddMural.BackColor = System.Drawing.Color.Transparent;
            this.botaoAddMural.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAddMural.BackgroundImage")));
            this.botaoAddMural.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAddMural.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAddMural.Location = new System.Drawing.Point(709, 148);
            this.botaoAddMural.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAddMural.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAddMural.Name = "botaoAddMural";
            this.botaoAddMural.Size = new System.Drawing.Size(24, 24);
            this.botaoAddMural.TabIndex = 7;
            this.botaoAddMural.Click += new System.EventHandler(this.botaoAddMural_Click);
            // 
            // TabInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoAddMural);
            this.Controls.Add(this.txtMural);
            this.Controls.Add(this.dgvMural);
            this.Controls.Add(this.bolhaReclamacoes);
            this.Controls.Add(this.bolhaServicos);
            this.Controls.Add(this.bolhaReservas);
            this.Controls.Add(this.bolhaVisitantes);
            this.Controls.Add(this.bolhaUnidades);
            this.Name = "TabInicio";
            this.Size = new System.Drawing.Size(862, 543);
            this.Load += new System.EventHandler(this.TabInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMural)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMural)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Desktop.Framework.Inicio.BolhaInicio bolhaUnidades;
        private Desktop.Framework.Inicio.BolhaInicio bolhaVisitantes;
        private Desktop.Framework.Inicio.BolhaInicio bolhaReservas;
        private Desktop.Framework.Inicio.BolhaInicio bolhaServicos;
        private Desktop.Framework.Inicio.BolhaInicio bolhaReclamacoes;
        private System.Windows.Forms.DataGridView dgvMural;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtMural;
        private Desktop.Framework.Botoes.BotaoAdd botaoAddMural;
        private System.Windows.Forms.BindingSource bsMural;
        private System.Windows.Forms.DataGridViewTextBoxColumn mensagemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataHoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
    }
}

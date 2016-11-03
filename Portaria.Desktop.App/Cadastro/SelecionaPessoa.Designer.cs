namespace Portaria.Cadastro
{
    partial class SelecionaPessoa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionaPessoa));
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPessoas = new System.Windows.Forms.BindingSource(this.components);
            this.txtPesquisar = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.botaoSearch1 = new Portaria.Desktop.Framework.Botoes.BotaoSearch();
            this.chkSomente30 = new MaterialSkin.Controls.MaterialCheckBox();
            this.botaoAdd1 = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnOK = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.btnOK);
            this.pnlConteudo.Controls.Add(this.btnCancelar);
            this.pnlConteudo.Controls.Add(this.botaoAdd1);
            this.pnlConteudo.Controls.Add(this.chkSomente30);
            this.pnlConteudo.Controls.Add(this.botaoSearch1);
            this.pnlConteudo.Controls.Add(this.txtPesquisar);
            this.pnlConteudo.Controls.Add(this.dgvPessoas);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 66);
            this.pnlConteudo.Size = new System.Drawing.Size(687, 399);
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToAddRows = false;
            this.dgvPessoas.AllowUserToDeleteRows = false;
            this.dgvPessoas.AllowUserToResizeRows = false;
            this.dgvPessoas.AutoGenerateColumns = false;
            this.dgvPessoas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPessoas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPessoas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPessoas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPessoas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn});
            this.dgvPessoas.DataSource = this.bsPessoas;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPessoas.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPessoas.Location = new System.Drawing.Point(16, 95);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.RowHeadersVisible = false;
            this.dgvPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoas.Size = new System.Drawing.Size(630, 253);
            this.dgvPessoas.TabIndex = 3;
            this.dgvPessoas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPessoas_CellDoubleClick);
            this.dgvPessoas.SelectionChanged += new System.EventHandler(this.dgvPessoas_SelectionChanged);
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
            // cPFDataGridViewTextBoxColumn
            // 
            this.cPFDataGridViewTextBoxColumn.DataPropertyName = "CPF";
            this.cPFDataGridViewTextBoxColumn.HeaderText = "CPF";
            this.cPFDataGridViewTextBoxColumn.Name = "cPFDataGridViewTextBoxColumn";
            this.cPFDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rGDataGridViewTextBoxColumn
            // 
            this.rGDataGridViewTextBoxColumn.DataPropertyName = "RG";
            this.rGDataGridViewTextBoxColumn.HeaderText = "RG";
            this.rGDataGridViewTextBoxColumn.Name = "rGDataGridViewTextBoxColumn";
            this.rGDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bsPessoas
            // 
            this.bsPessoas.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Pessoa);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Depth = 0;
            this.txtPesquisar.Hint = "Pesquisar Pessoa";
            this.txtPesquisar.Location = new System.Drawing.Point(16, 36);
            this.txtPesquisar.Mask = "";
            this.txtPesquisar.MaxLength = 32767;
            this.txtPesquisar.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionLength = 0;
            this.txtPesquisar.SelectionStart = 0;
            this.txtPesquisar.Size = new System.Drawing.Size(600, 23);
            this.txtPesquisar.TabIndex = 8;
            this.txtPesquisar.TabStop = false;
            this.txtPesquisar.UseSystemPasswordChar = false;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // botaoSearch1
            // 
            this.botaoSearch1.BackColor = System.Drawing.Color.Transparent;
            this.botaoSearch1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoSearch1.BackgroundImage")));
            this.botaoSearch1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoSearch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSearch1.Location = new System.Drawing.Point(622, 36);
            this.botaoSearch1.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoSearch1.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoSearch1.Name = "botaoSearch1";
            this.botaoSearch1.Size = new System.Drawing.Size(24, 24);
            this.botaoSearch1.TabIndex = 9;
            this.botaoSearch1.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // chkSomente30
            // 
            this.chkSomente30.AutoSize = true;
            this.chkSomente30.Depth = 0;
            this.chkSomente30.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkSomente30.Location = new System.Drawing.Point(11, 62);
            this.chkSomente30.Margin = new System.Windows.Forms.Padding(0);
            this.chkSomente30.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkSomente30.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkSomente30.Name = "chkSomente30";
            this.chkSomente30.Ripple = true;
            this.chkSomente30.Size = new System.Drawing.Size(221, 30);
            this.chkSomente30.TabIndex = 10;
            this.chkSomente30.Text = "Exibir somente os 30 primeiros";
            this.chkSomente30.UseVisualStyleBackColor = true;
            // 
            // botaoAdd1
            // 
            this.botaoAdd1.BackColor = System.Drawing.Color.Transparent;
            this.botaoAdd1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdd1.BackgroundImage")));
            this.botaoAdd1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAdd1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdd1.Location = new System.Drawing.Point(653, 95);
            this.botaoAdd1.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdd1.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdd1.Name = "botaoAdd1";
            this.botaoAdd1.Size = new System.Drawing.Size(24, 24);
            this.botaoAdd1.TabIndex = 11;
            this.botaoAdd1.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(482, 357);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.Depth = 0;
            this.btnOK.Icon = null;
            this.btnOK.Location = new System.Drawing.Point(581, 357);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = true;
            this.btnOK.Size = new System.Drawing.Size(102, 36);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "Selecionar";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.botaoOK_Click);
            // 
            // SelecionaPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(687, 465);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(687, 465);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(687, 465);
            this.Name = "SelecionaPessoa";
            this.Sizable = false;
            this.Text = "Selecionar Pessoa";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.BindingSource bsPessoas;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inadimplenteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPesquisar;
        private Desktop.Framework.Botoes.BotaoSearch botaoSearch1;
        private MaterialSkin.Controls.MaterialCheckBox chkSomente30;
        private MaterialSkin.Controls.MaterialFlatButton btnOK;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private Desktop.Framework.Botoes.BotaoAdd botaoAdd1;
    }
}
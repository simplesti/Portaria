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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionaPessoa));
            this.botaoPesquisar = new Portaria.Framework.Botoes.BotaoPesquisar();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.dgvPessoas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneResidencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grauParentescoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inadimplenteDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.fotoDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.veiculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reservasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPessoas = new System.Windows.Forms.BindingSource(this.components);
            this.chkSomente30 = new System.Windows.Forms.CheckBox();
            this.botaoAdicionar = new Portaria.Framework.Botoes.BotaoAdicionar();
            this.botaoOK = new Portaria.Framework.Botoes.BotaoOK();
            this.botaoCancelar = new Portaria.Framework.Botoes.BotaoCancelar();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoas)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.botaoCancelar);
            this.pnlConteudo.Controls.Add(this.botaoOK);
            this.pnlConteudo.Controls.Add(this.botaoAdicionar);
            this.pnlConteudo.Controls.Add(this.chkSomente30);
            this.pnlConteudo.Controls.Add(this.dgvPessoas);
            this.pnlConteudo.Controls.Add(this.txtPesquisar);
            this.pnlConteudo.Controls.Add(this.lblPesquisar);
            this.pnlConteudo.Controls.Add(this.botaoPesquisar);
            this.pnlConteudo.Size = new System.Drawing.Size(667, 392);
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.AutoSize = true;
            this.botaoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisar.Image")));
            this.botaoPesquisar.Location = new System.Drawing.Point(622, 29);
            this.botaoPesquisar.MaximumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.MinimumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.TabIndex = 2;
            this.botaoPesquisar.UseVisualStyleBackColor = true;
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(12, 20);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 1;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(15, 36);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(593, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // dgvPessoas
            // 
            this.dgvPessoas.AllowUserToResizeRows = false;
            this.dgvPessoas.AutoGenerateColumns = false;
            this.dgvPessoas.BackgroundColor = System.Drawing.Color.White;
            this.dgvPessoas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.foneResidencialDataGridViewTextBoxColumn,
            this.foneComercialDataGridViewTextBoxColumn,
            this.foneCelularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.grauParentescoDataGridViewTextBoxColumn,
            this.inadimplenteDataGridViewCheckBoxColumn,
            this.fotoDataGridViewImageColumn,
            this.veiculosDataGridViewTextBoxColumn,
            this.unidadesDataGridViewTextBoxColumn,
            this.reservasDataGridViewTextBoxColumn});
            this.dgvPessoas.DataSource = this.bsPessoas;
            this.dgvPessoas.Location = new System.Drawing.Point(15, 85);
            this.dgvPessoas.Name = "dgvPessoas";
            this.dgvPessoas.ReadOnly = true;
            this.dgvPessoas.RowHeadersVisible = false;
            this.dgvPessoas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoas.Size = new System.Drawing.Size(593, 241);
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
            // foneResidencialDataGridViewTextBoxColumn
            // 
            this.foneResidencialDataGridViewTextBoxColumn.DataPropertyName = "FoneResidencial";
            this.foneResidencialDataGridViewTextBoxColumn.HeaderText = "FoneResidencial";
            this.foneResidencialDataGridViewTextBoxColumn.Name = "foneResidencialDataGridViewTextBoxColumn";
            this.foneResidencialDataGridViewTextBoxColumn.ReadOnly = true;
            this.foneResidencialDataGridViewTextBoxColumn.Visible = false;
            // 
            // foneComercialDataGridViewTextBoxColumn
            // 
            this.foneComercialDataGridViewTextBoxColumn.DataPropertyName = "FoneComercial";
            this.foneComercialDataGridViewTextBoxColumn.HeaderText = "FoneComercial";
            this.foneComercialDataGridViewTextBoxColumn.Name = "foneComercialDataGridViewTextBoxColumn";
            this.foneComercialDataGridViewTextBoxColumn.ReadOnly = true;
            this.foneComercialDataGridViewTextBoxColumn.Visible = false;
            // 
            // foneCelularDataGridViewTextBoxColumn
            // 
            this.foneCelularDataGridViewTextBoxColumn.DataPropertyName = "FoneCelular";
            this.foneCelularDataGridViewTextBoxColumn.HeaderText = "FoneCelular";
            this.foneCelularDataGridViewTextBoxColumn.Name = "foneCelularDataGridViewTextBoxColumn";
            this.foneCelularDataGridViewTextBoxColumn.ReadOnly = true;
            this.foneCelularDataGridViewTextBoxColumn.Visible = false;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Visible = false;
            // 
            // grauParentescoDataGridViewTextBoxColumn
            // 
            this.grauParentescoDataGridViewTextBoxColumn.DataPropertyName = "GrauParentesco";
            this.grauParentescoDataGridViewTextBoxColumn.HeaderText = "GrauParentesco";
            this.grauParentescoDataGridViewTextBoxColumn.Name = "grauParentescoDataGridViewTextBoxColumn";
            this.grauParentescoDataGridViewTextBoxColumn.ReadOnly = true;
            this.grauParentescoDataGridViewTextBoxColumn.Visible = false;
            // 
            // inadimplenteDataGridViewCheckBoxColumn
            // 
            this.inadimplenteDataGridViewCheckBoxColumn.DataPropertyName = "Inadimplente";
            this.inadimplenteDataGridViewCheckBoxColumn.HeaderText = "Inadimplente";
            this.inadimplenteDataGridViewCheckBoxColumn.Name = "inadimplenteDataGridViewCheckBoxColumn";
            this.inadimplenteDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn
            // 
            this.fotoDataGridViewImageColumn.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn.Name = "fotoDataGridViewImageColumn";
            this.fotoDataGridViewImageColumn.ReadOnly = true;
            this.fotoDataGridViewImageColumn.Visible = false;
            // 
            // veiculosDataGridViewTextBoxColumn
            // 
            this.veiculosDataGridViewTextBoxColumn.DataPropertyName = "Veiculos";
            this.veiculosDataGridViewTextBoxColumn.HeaderText = "Veiculos";
            this.veiculosDataGridViewTextBoxColumn.Name = "veiculosDataGridViewTextBoxColumn";
            this.veiculosDataGridViewTextBoxColumn.ReadOnly = true;
            this.veiculosDataGridViewTextBoxColumn.Visible = false;
            // 
            // unidadesDataGridViewTextBoxColumn
            // 
            this.unidadesDataGridViewTextBoxColumn.DataPropertyName = "Unidades";
            this.unidadesDataGridViewTextBoxColumn.HeaderText = "Unidades";
            this.unidadesDataGridViewTextBoxColumn.Name = "unidadesDataGridViewTextBoxColumn";
            this.unidadesDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadesDataGridViewTextBoxColumn.Visible = false;
            // 
            // reservasDataGridViewTextBoxColumn
            // 
            this.reservasDataGridViewTextBoxColumn.DataPropertyName = "Reservas";
            this.reservasDataGridViewTextBoxColumn.HeaderText = "Reservas";
            this.reservasDataGridViewTextBoxColumn.Name = "reservasDataGridViewTextBoxColumn";
            this.reservasDataGridViewTextBoxColumn.ReadOnly = true;
            this.reservasDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsPessoas
            // 
            this.bsPessoas.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Pessoa);
            // 
            // chkSomente30
            // 
            this.chkSomente30.AutoSize = true;
            this.chkSomente30.Checked = true;
            this.chkSomente30.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSomente30.Location = new System.Drawing.Point(15, 62);
            this.chkSomente30.Name = "chkSomente30";
            this.chkSomente30.Size = new System.Drawing.Size(167, 17);
            this.chkSomente30.TabIndex = 1;
            this.chkSomente30.Text = "Exibir somente os 30 primeiros";
            this.chkSomente30.UseVisualStyleBackColor = true;
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.AutoSize = true;
            this.botaoAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAdicionar.Image = ((System.Drawing.Image)(resources.GetObject("botaoAdicionar.Image")));
            this.botaoAdicionar.Location = new System.Drawing.Point(622, 85);
            this.botaoAdicionar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionar.TabIndex = 4;
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // botaoOK
            // 
            this.botaoOK.BackColor = System.Drawing.Color.White;
            this.botaoOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoOK.Image = ((System.Drawing.Image)(resources.GetObject("botaoOK.Image")));
            this.botaoOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoOK.Location = new System.Drawing.Point(402, 337);
            this.botaoOK.Name = "botaoOK";
            this.botaoOK.Size = new System.Drawing.Size(100, 35);
            this.botaoOK.TabIndex = 5;
            this.botaoOK.Text = "OK";
            this.botaoOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoOK.UseVisualStyleBackColor = false;
            this.botaoOK.Click += new System.EventHandler(this.botaoOK_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(508, 337);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 35);
            this.botaoCancelar.TabIndex = 6;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // SelecionaPessoa
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(673, 455);
            this.MaximumSize = new System.Drawing.Size(673, 455);
            this.MinimumSize = new System.Drawing.Size(673, 455);
            this.Name = "SelecionaPessoa";
            this.Text = "SelecionaPessoa";
            this.Titulo = "Selecionar Pessoa";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Framework.Botoes.BotaoPesquisar botaoPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.DataGridView dgvPessoas;
        private System.Windows.Forms.CheckBox chkSomente30;
        private Framework.Botoes.BotaoAdicionar botaoAdicionar;
        private System.Windows.Forms.BindingSource bsPessoas;
        private Framework.Botoes.BotaoOK botaoOK;
        private Framework.Botoes.BotaoCancelar botaoCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneResidencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneComercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grauParentescoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inadimplenteDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reservasDataGridViewTextBoxColumn;
    }
}
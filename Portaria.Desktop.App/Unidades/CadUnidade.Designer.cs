namespace Portaria
{
    partial class CadUnidade
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadUnidade));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.txtAssinaturas = new System.Windows.Forms.TextBox();
            this.dgvAutorizadas = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneResidencialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneComercialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneCelularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grauParentescoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.veiculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsPessoasAutorizadas = new System.Windows.Forms.BindingSource(this.components);
            this.dgvFuncionarios = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.documentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorizadaSemPresencaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.frequenciaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioEntradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horarioSaidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.unidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsFuncionarios = new System.Windows.Forms.BindingSource(this.components);
            this.dgvVeiculos = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fotoDataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.unidadeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proprietarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsVeiculo = new System.Windows.Forms.BindingSource(this.components);
            this.txtAnimais = new System.Windows.Forms.TextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.txtGas = new System.Windows.Forms.TextBox();
            this.cboBloco = new System.Windows.Forms.ComboBox();
            this.lblNumero = new MaterialSkin.Controls.MaterialLabel();
            this.lblUltimaAtualizacao = new MaterialSkin.Controls.MaterialLabel();
            this.lblObs = new MaterialSkin.Controls.MaterialLabel();
            this.lblDtAtualizacao = new MaterialSkin.Controls.MaterialLabel();
            this.txtNumero = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblBloco = new MaterialSkin.Controls.MaterialLabel();
            this.lblLocatario = new MaterialSkin.Controls.MaterialLabel();
            this.txtLocatario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.botaoEditarLocatario = new Portaria.Desktop.Framework.Botoes.BotaoPessoa();
            this.lblProprietario = new MaterialSkin.Controls.MaterialLabel();
            this.lblConjuge = new MaterialSkin.Controls.MaterialLabel();
            this.txtProprietario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.botaoEditarProprietario = new Portaria.Desktop.Framework.Botoes.BotaoPessoa();
            this.txtConjuge = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.botaoEditarConjuge = new Portaria.Desktop.Framework.Botoes.BotaoPessoa();
            this.botaoAddPessoaAut = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.botaoAddVeiculo = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.botaoRemovePessoaAut = new Portaria.Desktop.Framework.Botoes.BotaoRemove();
            this.botaoRemoveVeiculo = new Portaria.Desktop.Framework.Botoes.BotaoRemove();
            this.botaoAddFunc = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.botaoRemoveFunc = new Portaria.Desktop.Framework.Botoes.BotaoRemove();
            this.lblFunc = new MaterialSkin.Controls.MaterialLabel();
            this.lblAutorizadas = new MaterialSkin.Controls.MaterialLabel();
            this.lblVeiculos = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lblAssinaturas = new MaterialSkin.Controls.MaterialLabel();
            this.lblGas = new MaterialSkin.Controls.MaterialLabel();
            this.chkInadimplente = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnEmailCorrespondencia = new MaterialSkin.Controls.MaterialFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoasAutorizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculo)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(934, 564);
            // 
            // tlpCampos
            // 
            this.tlpCampos.BackColor = System.Drawing.Color.White;
            this.tlpCampos.ColumnCount = 6;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 458F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlpCampos.Controls.Add(this.txtAssinaturas, 0, 15);
            this.tlpCampos.Controls.Add(this.dgvAutorizadas, 0, 7);
            this.tlpCampos.Controls.Add(this.dgvFuncionarios, 4, 7);
            this.tlpCampos.Controls.Add(this.dgvVeiculos, 0, 11);
            this.tlpCampos.Controls.Add(this.txtAnimais, 4, 11);
            this.tlpCampos.Controls.Add(this.txtObs, 4, 1);
            this.tlpCampos.Controls.Add(this.txtGas, 4, 15);
            this.tlpCampos.Controls.Add(this.cboBloco, 0, 3);
            this.tlpCampos.Controls.Add(this.lblNumero, 0, 0);
            this.tlpCampos.Controls.Add(this.lblUltimaAtualizacao, 2, 0);
            this.tlpCampos.Controls.Add(this.lblObs, 4, 0);
            this.tlpCampos.Controls.Add(this.lblDtAtualizacao, 2, 1);
            this.tlpCampos.Controls.Add(this.txtNumero, 0, 1);
            this.tlpCampos.Controls.Add(this.lblBloco, 0, 2);
            this.tlpCampos.Controls.Add(this.lblLocatario, 2, 2);
            this.tlpCampos.Controls.Add(this.txtLocatario, 2, 3);
            this.tlpCampos.Controls.Add(this.botaoEditarLocatario, 3, 3);
            this.tlpCampos.Controls.Add(this.lblProprietario, 0, 4);
            this.tlpCampos.Controls.Add(this.lblConjuge, 2, 4);
            this.tlpCampos.Controls.Add(this.txtProprietario, 0, 5);
            this.tlpCampos.Controls.Add(this.botaoEditarProprietario, 1, 5);
            this.tlpCampos.Controls.Add(this.txtConjuge, 2, 5);
            this.tlpCampos.Controls.Add(this.botaoEditarConjuge, 3, 5);
            this.tlpCampos.Controls.Add(this.botaoAddPessoaAut, 3, 7);
            this.tlpCampos.Controls.Add(this.botaoAddVeiculo, 3, 11);
            this.tlpCampos.Controls.Add(this.botaoRemovePessoaAut, 3, 8);
            this.tlpCampos.Controls.Add(this.botaoRemoveVeiculo, 3, 12);
            this.tlpCampos.Controls.Add(this.botaoAddFunc, 5, 7);
            this.tlpCampos.Controls.Add(this.botaoRemoveFunc, 5, 8);
            this.tlpCampos.Controls.Add(this.lblFunc, 4, 6);
            this.tlpCampos.Controls.Add(this.lblAutorizadas, 0, 6);
            this.tlpCampos.Controls.Add(this.lblVeiculos, 0, 10);
            this.tlpCampos.Controls.Add(this.materialLabel1, 4, 10);
            this.tlpCampos.Controls.Add(this.lblAssinaturas, 0, 14);
            this.tlpCampos.Controls.Add(this.lblGas, 4, 14);
            this.tlpCampos.Controls.Add(this.chkInadimplente, 2, 17);
            this.tlpCampos.Controls.Add(this.btnEmailCorrespondencia, 0, 17);
            this.tlpCampos.Controls.Add(this.panel1, 4, 17);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(0, 0);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 19;
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCampos.Size = new System.Drawing.Size(934, 564);
            this.tlpCampos.TabIndex = 0;
            // 
            // txtAssinaturas
            // 
            this.txtAssinaturas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCampos.SetColumnSpan(this.txtAssinaturas, 3);
            this.txtAssinaturas.Location = new System.Drawing.Point(3, 399);
            this.txtAssinaturas.Multiline = true;
            this.txtAssinaturas.Name = "txtAssinaturas";
            this.txtAssinaturas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAssinaturas.Size = new System.Drawing.Size(410, 100);
            this.txtAssinaturas.TabIndex = 14;
            // 
            // dgvAutorizadas
            // 
            this.dgvAutorizadas.AllowUserToAddRows = false;
            this.dgvAutorizadas.AllowUserToDeleteRows = false;
            this.dgvAutorizadas.AllowUserToResizeRows = false;
            this.dgvAutorizadas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAutorizadas.AutoGenerateColumns = false;
            this.dgvAutorizadas.BackgroundColor = System.Drawing.Color.White;
            this.dgvAutorizadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAutorizadas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAutorizadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutorizadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAutorizadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutorizadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cPFDataGridViewTextBoxColumn,
            this.rGDataGridViewTextBoxColumn,
            this.foneResidencialDataGridViewTextBoxColumn,
            this.foneComercialDataGridViewTextBoxColumn,
            this.foneCelularDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.grauParentescoDataGridViewTextBoxColumn,
            this.veiculosDataGridViewTextBoxColumn,
            this.unidadesDataGridViewTextBoxColumn});
            this.tlpCampos.SetColumnSpan(this.dgvAutorizadas, 3);
            this.dgvAutorizadas.DataSource = this.bsPessoasAutorizadas;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAutorizadas.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutorizadas.Location = new System.Drawing.Point(3, 173);
            this.dgvAutorizadas.Name = "dgvAutorizadas";
            this.dgvAutorizadas.ReadOnly = true;
            this.dgvAutorizadas.RowHeadersVisible = false;
            this.tlpCampos.SetRowSpan(this.dgvAutorizadas, 2);
            this.dgvAutorizadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutorizadas.Size = new System.Drawing.Size(410, 96);
            this.dgvAutorizadas.TabIndex = 4;
            this.dgvAutorizadas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAutorizadas_CellMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 2;
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
            // bsPessoasAutorizadas
            // 
            this.bsPessoasAutorizadas.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Pessoa);
            // 
            // dgvFuncionarios
            // 
            this.dgvFuncionarios.AllowUserToAddRows = false;
            this.dgvFuncionarios.AllowUserToDeleteRows = false;
            this.dgvFuncionarios.AllowUserToResizeRows = false;
            this.dgvFuncionarios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFuncionarios.AutoGenerateColumns = false;
            this.dgvFuncionarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvFuncionarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvFuncionarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvFuncionarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFuncionarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFuncionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFuncionarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nomeDataGridViewTextBoxColumn1,
            this.foneDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.documentoDataGridViewTextBoxColumn,
            this.autorizadaSemPresencaDataGridViewCheckBoxColumn,
            this.frequenciaDataGridViewTextBoxColumn,
            this.horarioEntradaDataGridViewTextBoxColumn,
            this.horarioSaidaDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn1,
            this.unidadeDataGridViewTextBoxColumn});
            this.dgvFuncionarios.DataSource = this.bsFuncionarios;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFuncionarios.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFuncionarios.Location = new System.Drawing.Point(449, 173);
            this.dgvFuncionarios.Name = "dgvFuncionarios";
            this.dgvFuncionarios.ReadOnly = true;
            this.dgvFuncionarios.RowHeadersVisible = false;
            this.tlpCampos.SetRowSpan(this.dgvFuncionarios, 2);
            this.dgvFuncionarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFuncionarios.Size = new System.Drawing.Size(452, 96);
            this.dgvFuncionarios.TabIndex = 7;
            this.dgvFuncionarios.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFuncionarios_CellMouseDoubleClick);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn1
            // 
            this.nomeDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn1.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn1.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn1.Name = "nomeDataGridViewTextBoxColumn1";
            this.nomeDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // foneDataGridViewTextBoxColumn
            // 
            this.foneDataGridViewTextBoxColumn.DataPropertyName = "Fone";
            this.foneDataGridViewTextBoxColumn.HeaderText = "Fone";
            this.foneDataGridViewTextBoxColumn.Name = "foneDataGridViewTextBoxColumn";
            this.foneDataGridViewTextBoxColumn.ReadOnly = true;
            this.foneDataGridViewTextBoxColumn.Visible = false;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "Descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // documentoDataGridViewTextBoxColumn
            // 
            this.documentoDataGridViewTextBoxColumn.DataPropertyName = "Documento";
            this.documentoDataGridViewTextBoxColumn.HeaderText = "Documento";
            this.documentoDataGridViewTextBoxColumn.Name = "documentoDataGridViewTextBoxColumn";
            this.documentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // autorizadaSemPresencaDataGridViewCheckBoxColumn
            // 
            this.autorizadaSemPresencaDataGridViewCheckBoxColumn.DataPropertyName = "AutorizadaSemPresenca";
            this.autorizadaSemPresencaDataGridViewCheckBoxColumn.HeaderText = "Autorizado";
            this.autorizadaSemPresencaDataGridViewCheckBoxColumn.Name = "autorizadaSemPresencaDataGridViewCheckBoxColumn";
            this.autorizadaSemPresencaDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // frequenciaDataGridViewTextBoxColumn
            // 
            this.frequenciaDataGridViewTextBoxColumn.DataPropertyName = "Frequencia";
            this.frequenciaDataGridViewTextBoxColumn.HeaderText = "Frequencia";
            this.frequenciaDataGridViewTextBoxColumn.Name = "frequenciaDataGridViewTextBoxColumn";
            this.frequenciaDataGridViewTextBoxColumn.ReadOnly = true;
            this.frequenciaDataGridViewTextBoxColumn.Visible = false;
            // 
            // horarioEntradaDataGridViewTextBoxColumn
            // 
            this.horarioEntradaDataGridViewTextBoxColumn.DataPropertyName = "HorarioEntrada";
            this.horarioEntradaDataGridViewTextBoxColumn.HeaderText = "HorarioEntrada";
            this.horarioEntradaDataGridViewTextBoxColumn.Name = "horarioEntradaDataGridViewTextBoxColumn";
            this.horarioEntradaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioEntradaDataGridViewTextBoxColumn.Visible = false;
            // 
            // horarioSaidaDataGridViewTextBoxColumn
            // 
            this.horarioSaidaDataGridViewTextBoxColumn.DataPropertyName = "HorarioSaida";
            this.horarioSaidaDataGridViewTextBoxColumn.HeaderText = "HorarioSaida";
            this.horarioSaidaDataGridViewTextBoxColumn.Name = "horarioSaidaDataGridViewTextBoxColumn";
            this.horarioSaidaDataGridViewTextBoxColumn.ReadOnly = true;
            this.horarioSaidaDataGridViewTextBoxColumn.Visible = false;
            // 
            // fotoDataGridViewImageColumn1
            // 
            this.fotoDataGridViewImageColumn1.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn1.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn1.Name = "fotoDataGridViewImageColumn1";
            this.fotoDataGridViewImageColumn1.ReadOnly = true;
            this.fotoDataGridViewImageColumn1.Visible = false;
            // 
            // unidadeDataGridViewTextBoxColumn
            // 
            this.unidadeDataGridViewTextBoxColumn.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn.Name = "unidadeDataGridViewTextBoxColumn";
            this.unidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsFuncionarios
            // 
            this.bsFuncionarios.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Funcionario);
            // 
            // dgvVeiculos
            // 
            this.dgvVeiculos.AllowUserToAddRows = false;
            this.dgvVeiculos.AllowUserToDeleteRows = false;
            this.dgvVeiculos.AllowUserToResizeRows = false;
            this.dgvVeiculos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVeiculos.AutoGenerateColumns = false;
            this.dgvVeiculos.BackgroundColor = System.Drawing.Color.White;
            this.dgvVeiculos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVeiculos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVeiculos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVeiculos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVeiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVeiculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.nomeDataGridViewTextBoxColumn2,
            this.placaDataGridViewTextBoxColumn,
            this.corDataGridViewTextBoxColumn,
            this.fotoDataGridViewImageColumn2,
            this.unidadeDataGridViewTextBoxColumn1,
            this.proprietarioDataGridViewTextBoxColumn});
            this.tlpCampos.SetColumnSpan(this.dgvVeiculos, 3);
            this.dgvVeiculos.DataSource = this.bsVeiculo;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVeiculos.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvVeiculos.Location = new System.Drawing.Point(3, 294);
            this.dgvVeiculos.Name = "dgvVeiculos";
            this.dgvVeiculos.ReadOnly = true;
            this.dgvVeiculos.RowHeadersVisible = false;
            this.tlpCampos.SetRowSpan(this.dgvVeiculos, 2);
            this.dgvVeiculos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVeiculos.Size = new System.Drawing.Size(410, 80);
            this.dgvVeiculos.TabIndex = 10;
            this.dgvVeiculos.DoubleClick += new System.EventHandler(this.dgvVeiculos_DoubleClick);
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idDataGridViewTextBoxColumn2.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn2
            // 
            this.nomeDataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn2.Name = "nomeDataGridViewTextBoxColumn2";
            this.nomeDataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // placaDataGridViewTextBoxColumn
            // 
            this.placaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.placaDataGridViewTextBoxColumn.DataPropertyName = "Placa";
            this.placaDataGridViewTextBoxColumn.HeaderText = "Placa";
            this.placaDataGridViewTextBoxColumn.Name = "placaDataGridViewTextBoxColumn";
            this.placaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // corDataGridViewTextBoxColumn
            // 
            this.corDataGridViewTextBoxColumn.DataPropertyName = "Cor";
            this.corDataGridViewTextBoxColumn.HeaderText = "Cor";
            this.corDataGridViewTextBoxColumn.Name = "corDataGridViewTextBoxColumn";
            this.corDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fotoDataGridViewImageColumn2
            // 
            this.fotoDataGridViewImageColumn2.DataPropertyName = "Foto";
            this.fotoDataGridViewImageColumn2.HeaderText = "Foto";
            this.fotoDataGridViewImageColumn2.Name = "fotoDataGridViewImageColumn2";
            this.fotoDataGridViewImageColumn2.ReadOnly = true;
            this.fotoDataGridViewImageColumn2.Visible = false;
            // 
            // unidadeDataGridViewTextBoxColumn1
            // 
            this.unidadeDataGridViewTextBoxColumn1.DataPropertyName = "Unidade";
            this.unidadeDataGridViewTextBoxColumn1.HeaderText = "Unidade";
            this.unidadeDataGridViewTextBoxColumn1.Name = "unidadeDataGridViewTextBoxColumn1";
            this.unidadeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.unidadeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // proprietarioDataGridViewTextBoxColumn
            // 
            this.proprietarioDataGridViewTextBoxColumn.DataPropertyName = "Proprietario";
            this.proprietarioDataGridViewTextBoxColumn.HeaderText = "Proprietario";
            this.proprietarioDataGridViewTextBoxColumn.Name = "proprietarioDataGridViewTextBoxColumn";
            this.proprietarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.proprietarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // bsVeiculo
            // 
            this.bsVeiculo.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Veiculo);
            // 
            // txtAnimais
            // 
            this.txtAnimais.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAnimais.Location = new System.Drawing.Point(449, 294);
            this.txtAnimais.Multiline = true;
            this.txtAnimais.Name = "txtAnimais";
            this.tlpCampos.SetRowSpan(this.txtAnimais, 2);
            this.txtAnimais.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtAnimais.Size = new System.Drawing.Size(452, 80);
            this.txtAnimais.TabIndex = 13;
            // 
            // txtObs
            // 
            this.txtObs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtObs.Location = new System.Drawing.Point(449, 22);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.tlpCampos.SetRowSpan(this.txtObs, 4);
            this.txtObs.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObs.Size = new System.Drawing.Size(452, 59);
            this.txtObs.TabIndex = 3;
            // 
            // txtGas
            // 
            this.txtGas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGas.Location = new System.Drawing.Point(449, 399);
            this.txtGas.Multiline = true;
            this.txtGas.Name = "txtGas";
            this.txtGas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGas.Size = new System.Drawing.Size(452, 100);
            this.txtGas.TabIndex = 15;
            // 
            // cboBloco
            // 
            this.cboBloco.Enabled = false;
            this.cboBloco.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBloco.FormattingEnabled = true;
            this.cboBloco.Location = new System.Drawing.Point(3, 70);
            this.cboBloco.Name = "cboBloco";
            this.cboBloco.Size = new System.Drawing.Size(121, 27);
            this.cboBloco.TabIndex = 35;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Depth = 0;
            this.lblNumero.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumero.Location = new System.Drawing.Point(3, 0);
            this.lblNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(63, 19);
            this.lblNumero.TabIndex = 38;
            this.lblNumero.Text = "Número";
            // 
            // lblUltimaAtualizacao
            // 
            this.lblUltimaAtualizacao.AutoSize = true;
            this.lblUltimaAtualizacao.Depth = 0;
            this.lblUltimaAtualizacao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUltimaAtualizacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUltimaAtualizacao.Location = new System.Drawing.Point(226, 0);
            this.lblUltimaAtualizacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUltimaAtualizacao.Name = "lblUltimaAtualizacao";
            this.lblUltimaAtualizacao.Size = new System.Drawing.Size(134, 19);
            this.lblUltimaAtualizacao.TabIndex = 39;
            this.lblUltimaAtualizacao.Text = "Ultima atualização";
            // 
            // lblObs
            // 
            this.lblObs.AutoSize = true;
            this.lblObs.Depth = 0;
            this.lblObs.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblObs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblObs.Location = new System.Drawing.Point(449, 0);
            this.lblObs.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblObs.Name = "lblObs";
            this.lblObs.Size = new System.Drawing.Size(96, 19);
            this.lblObs.TabIndex = 40;
            this.lblObs.Text = "Observações";
            // 
            // lblDtAtualizacao
            // 
            this.lblDtAtualizacao.AutoSize = true;
            this.lblDtAtualizacao.Depth = 0;
            this.lblDtAtualizacao.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDtAtualizacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDtAtualizacao.Location = new System.Drawing.Point(226, 19);
            this.lblDtAtualizacao.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDtAtualizacao.Name = "lblDtAtualizacao";
            this.lblDtAtualizacao.Size = new System.Drawing.Size(85, 19);
            this.lblDtAtualizacao.TabIndex = 41;
            this.lblDtAtualizacao.Text = "00/00/0000";
            // 
            // txtNumero
            // 
            this.txtNumero.Depth = 0;
            this.txtNumero.Enabled = false;
            this.txtNumero.Hint = "";
            this.txtNumero.Location = new System.Drawing.Point(3, 22);
            this.txtNumero.Mask = "";
            this.txtNumero.MaxLength = 32767;
            this.txtNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.PasswordChar = '\0';
            this.txtNumero.SelectedText = "";
            this.txtNumero.SelectionLength = 0;
            this.txtNumero.SelectionStart = 0;
            this.txtNumero.Size = new System.Drawing.Size(75, 23);
            this.txtNumero.TabIndex = 42;
            this.txtNumero.TabStop = false;
            this.txtNumero.UseSystemPasswordChar = false;
            // 
            // lblBloco
            // 
            this.lblBloco.AutoSize = true;
            this.lblBloco.Depth = 0;
            this.lblBloco.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBloco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBloco.Location = new System.Drawing.Point(3, 48);
            this.lblBloco.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBloco.Name = "lblBloco";
            this.lblBloco.Size = new System.Drawing.Size(48, 19);
            this.lblBloco.TabIndex = 43;
            this.lblBloco.Text = "Bloco";
            // 
            // lblLocatario
            // 
            this.lblLocatario.AutoSize = true;
            this.lblLocatario.Depth = 0;
            this.lblLocatario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLocatario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLocatario.Location = new System.Drawing.Point(226, 48);
            this.lblLocatario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLocatario.Name = "lblLocatario";
            this.lblLocatario.Size = new System.Drawing.Size(73, 19);
            this.lblLocatario.TabIndex = 44;
            this.lblLocatario.Text = "Locatário";
            // 
            // txtLocatario
            // 
            this.txtLocatario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocatario.Depth = 0;
            this.txtLocatario.Enabled = false;
            this.txtLocatario.Hint = "";
            this.txtLocatario.Location = new System.Drawing.Point(226, 70);
            this.txtLocatario.Mask = "";
            this.txtLocatario.MaxLength = 32767;
            this.txtLocatario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocatario.Name = "txtLocatario";
            this.txtLocatario.PasswordChar = '\0';
            this.txtLocatario.SelectedText = "";
            this.txtLocatario.SelectionLength = 0;
            this.txtLocatario.SelectionStart = 0;
            this.txtLocatario.Size = new System.Drawing.Size(187, 23);
            this.txtLocatario.TabIndex = 45;
            this.txtLocatario.TabStop = false;
            this.txtLocatario.UseSystemPasswordChar = false;
            // 
            // botaoEditarLocatario
            // 
            this.botaoEditarLocatario.BackColor = System.Drawing.Color.Transparent;
            this.botaoEditarLocatario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoEditarLocatario.BackgroundImage")));
            this.botaoEditarLocatario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoEditarLocatario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditarLocatario.Location = new System.Drawing.Point(419, 70);
            this.botaoEditarLocatario.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarLocatario.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarLocatario.Name = "botaoEditarLocatario";
            this.botaoEditarLocatario.Size = new System.Drawing.Size(24, 24);
            this.botaoEditarLocatario.TabIndex = 46;
            this.botaoEditarLocatario.Click += new System.EventHandler(this.botaoEditarLocatario_Click);
            // 
            // lblProprietario
            // 
            this.lblProprietario.AutoSize = true;
            this.lblProprietario.Depth = 0;
            this.lblProprietario.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblProprietario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblProprietario.Location = new System.Drawing.Point(3, 102);
            this.lblProprietario.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblProprietario.Name = "lblProprietario";
            this.lblProprietario.Size = new System.Drawing.Size(88, 19);
            this.lblProprietario.TabIndex = 47;
            this.lblProprietario.Text = "Proprietário";
            // 
            // lblConjuge
            // 
            this.lblConjuge.AutoSize = true;
            this.lblConjuge.Depth = 0;
            this.lblConjuge.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblConjuge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConjuge.Location = new System.Drawing.Point(226, 102);
            this.lblConjuge.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConjuge.Name = "lblConjuge";
            this.lblConjuge.Size = new System.Drawing.Size(64, 19);
            this.lblConjuge.TabIndex = 48;
            this.lblConjuge.Text = "Cônjuge";
            // 
            // txtProprietario
            // 
            this.txtProprietario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProprietario.Depth = 0;
            this.txtProprietario.Hint = "";
            this.txtProprietario.Location = new System.Drawing.Point(3, 124);
            this.txtProprietario.Mask = "";
            this.txtProprietario.MaxLength = 32767;
            this.txtProprietario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.PasswordChar = '\0';
            this.txtProprietario.SelectedText = "";
            this.txtProprietario.SelectionLength = 0;
            this.txtProprietario.SelectionStart = 0;
            this.txtProprietario.Size = new System.Drawing.Size(187, 23);
            this.txtProprietario.TabIndex = 49;
            this.txtProprietario.TabStop = false;
            this.txtProprietario.UseSystemPasswordChar = false;
            // 
            // botaoEditarProprietario
            // 
            this.botaoEditarProprietario.BackColor = System.Drawing.Color.Transparent;
            this.botaoEditarProprietario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoEditarProprietario.BackgroundImage")));
            this.botaoEditarProprietario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoEditarProprietario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditarProprietario.Location = new System.Drawing.Point(196, 124);
            this.botaoEditarProprietario.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarProprietario.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarProprietario.Name = "botaoEditarProprietario";
            this.botaoEditarProprietario.Size = new System.Drawing.Size(24, 24);
            this.botaoEditarProprietario.TabIndex = 50;
            this.botaoEditarProprietario.Click += new System.EventHandler(this.botaoEditarProprietario_Click);
            // 
            // txtConjuge
            // 
            this.txtConjuge.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConjuge.Depth = 0;
            this.txtConjuge.Enabled = false;
            this.txtConjuge.Hint = "";
            this.txtConjuge.Location = new System.Drawing.Point(226, 124);
            this.txtConjuge.Mask = "";
            this.txtConjuge.MaxLength = 32767;
            this.txtConjuge.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtConjuge.Name = "txtConjuge";
            this.txtConjuge.PasswordChar = '\0';
            this.txtConjuge.SelectedText = "";
            this.txtConjuge.SelectionLength = 0;
            this.txtConjuge.SelectionStart = 0;
            this.txtConjuge.Size = new System.Drawing.Size(187, 23);
            this.txtConjuge.TabIndex = 51;
            this.txtConjuge.TabStop = false;
            this.txtConjuge.UseSystemPasswordChar = false;
            // 
            // botaoEditarConjuge
            // 
            this.botaoEditarConjuge.BackColor = System.Drawing.Color.Transparent;
            this.botaoEditarConjuge.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoEditarConjuge.BackgroundImage")));
            this.botaoEditarConjuge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoEditarConjuge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditarConjuge.Location = new System.Drawing.Point(419, 124);
            this.botaoEditarConjuge.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarConjuge.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarConjuge.Name = "botaoEditarConjuge";
            this.botaoEditarConjuge.Size = new System.Drawing.Size(24, 24);
            this.botaoEditarConjuge.TabIndex = 52;
            this.botaoEditarConjuge.Click += new System.EventHandler(this.botaoEditarConjuge_Click);
            // 
            // botaoAddPessoaAut
            // 
            this.botaoAddPessoaAut.BackColor = System.Drawing.Color.Transparent;
            this.botaoAddPessoaAut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAddPessoaAut.BackgroundImage")));
            this.botaoAddPessoaAut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAddPessoaAut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAddPessoaAut.Location = new System.Drawing.Point(419, 173);
            this.botaoAddPessoaAut.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAddPessoaAut.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAddPessoaAut.Name = "botaoAddPessoaAut";
            this.botaoAddPessoaAut.Size = new System.Drawing.Size(24, 24);
            this.botaoAddPessoaAut.TabIndex = 53;
            this.botaoAddPessoaAut.Click += new System.EventHandler(this.btnAddAutorizada_Click);
            // 
            // botaoAddVeiculo
            // 
            this.botaoAddVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.botaoAddVeiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAddVeiculo.BackgroundImage")));
            this.botaoAddVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAddVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAddVeiculo.Location = new System.Drawing.Point(419, 294);
            this.botaoAddVeiculo.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAddVeiculo.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAddVeiculo.Name = "botaoAddVeiculo";
            this.botaoAddVeiculo.Size = new System.Drawing.Size(24, 24);
            this.botaoAddVeiculo.TabIndex = 54;
            this.botaoAddVeiculo.Click += new System.EventHandler(this.btnAddVeiculo_Click);
            // 
            // botaoRemovePessoaAut
            // 
            this.botaoRemovePessoaAut.BackColor = System.Drawing.Color.Transparent;
            this.botaoRemovePessoaAut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRemovePessoaAut.BackgroundImage")));
            this.botaoRemovePessoaAut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoRemovePessoaAut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemovePessoaAut.Location = new System.Drawing.Point(419, 203);
            this.botaoRemovePessoaAut.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemovePessoaAut.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemovePessoaAut.Name = "botaoRemovePessoaAut";
            this.botaoRemovePessoaAut.Size = new System.Drawing.Size(24, 24);
            this.botaoRemovePessoaAut.TabIndex = 55;
            this.botaoRemovePessoaAut.Click += new System.EventHandler(this.btnRemAutorizada_Click);
            // 
            // botaoRemoveVeiculo
            // 
            this.botaoRemoveVeiculo.BackColor = System.Drawing.Color.Transparent;
            this.botaoRemoveVeiculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRemoveVeiculo.BackgroundImage")));
            this.botaoRemoveVeiculo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoRemoveVeiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemoveVeiculo.Location = new System.Drawing.Point(419, 324);
            this.botaoRemoveVeiculo.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemoveVeiculo.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemoveVeiculo.Name = "botaoRemoveVeiculo";
            this.botaoRemoveVeiculo.Size = new System.Drawing.Size(24, 24);
            this.botaoRemoveVeiculo.TabIndex = 56;
            this.botaoRemoveVeiculo.Click += new System.EventHandler(this.btnRemVeiculo_Click);
            // 
            // botaoAddFunc
            // 
            this.botaoAddFunc.BackColor = System.Drawing.Color.Transparent;
            this.botaoAddFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAddFunc.BackgroundImage")));
            this.botaoAddFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAddFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAddFunc.Location = new System.Drawing.Point(907, 173);
            this.botaoAddFunc.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAddFunc.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAddFunc.Name = "botaoAddFunc";
            this.botaoAddFunc.Size = new System.Drawing.Size(24, 24);
            this.botaoAddFunc.TabIndex = 57;
            this.botaoAddFunc.Click += new System.EventHandler(this.btnAddFuncionario_Click);
            // 
            // botaoRemoveFunc
            // 
            this.botaoRemoveFunc.BackColor = System.Drawing.Color.Transparent;
            this.botaoRemoveFunc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoRemoveFunc.BackgroundImage")));
            this.botaoRemoveFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoRemoveFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoRemoveFunc.Location = new System.Drawing.Point(907, 203);
            this.botaoRemoveFunc.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoRemoveFunc.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoRemoveFunc.Name = "botaoRemoveFunc";
            this.botaoRemoveFunc.Size = new System.Drawing.Size(24, 24);
            this.botaoRemoveFunc.TabIndex = 58;
            this.botaoRemoveFunc.Click += new System.EventHandler(this.btnRemFuncionario_Click);
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Depth = 0;
            this.lblFunc.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFunc.Location = new System.Drawing.Point(449, 151);
            this.lblFunc.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(96, 19);
            this.lblFunc.TabIndex = 59;
            this.lblFunc.Text = "Funcionários";
            // 
            // lblAutorizadas
            // 
            this.lblAutorizadas.AutoSize = true;
            this.lblAutorizadas.Depth = 0;
            this.lblAutorizadas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAutorizadas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAutorizadas.Location = new System.Drawing.Point(3, 151);
            this.lblAutorizadas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAutorizadas.Name = "lblAutorizadas";
            this.lblAutorizadas.Size = new System.Drawing.Size(151, 19);
            this.lblAutorizadas.TabIndex = 60;
            this.lblAutorizadas.Text = "Pessoas Autorizadas";
            // 
            // lblVeiculos
            // 
            this.lblVeiculos.AutoSize = true;
            this.lblVeiculos.Depth = 0;
            this.lblVeiculos.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblVeiculos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVeiculos.Location = new System.Drawing.Point(3, 272);
            this.lblVeiculos.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVeiculos.Name = "lblVeiculos";
            this.lblVeiculos.Size = new System.Drawing.Size(68, 19);
            this.lblVeiculos.TabIndex = 61;
            this.lblVeiculos.Text = "Veículos";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(449, 272);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(150, 19);
            this.materialLabel1.TabIndex = 62;
            this.materialLabel1.Text = "Animais Domésticos";
            // 
            // lblAssinaturas
            // 
            this.lblAssinaturas.AutoSize = true;
            this.tlpCampos.SetColumnSpan(this.lblAssinaturas, 3);
            this.lblAssinaturas.Depth = 0;
            this.lblAssinaturas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblAssinaturas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAssinaturas.Location = new System.Drawing.Point(3, 377);
            this.lblAssinaturas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAssinaturas.Name = "lblAssinaturas";
            this.lblAssinaturas.Size = new System.Drawing.Size(208, 19);
            this.lblAssinaturas.TabIndex = 63;
            this.lblAssinaturas.Text = "Assinaturas (Revista / Jornal)";
            // 
            // lblGas
            // 
            this.lblGas.AutoSize = true;
            this.lblGas.Depth = 0;
            this.lblGas.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblGas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblGas.Location = new System.Drawing.Point(449, 377);
            this.lblGas.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblGas.Name = "lblGas";
            this.lblGas.Size = new System.Drawing.Size(283, 19);
            this.lblGas.TabIndex = 64;
            this.lblGas.Text = "Aparelhos que não utilizam o gás central";
            // 
            // chkInadimplente
            // 
            this.chkInadimplente.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.chkInadimplente.AutoSize = true;
            this.chkInadimplente.Depth = 0;
            this.chkInadimplente.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkInadimplente.Location = new System.Drawing.Point(306, 511);
            this.chkInadimplente.Margin = new System.Windows.Forms.Padding(0);
            this.chkInadimplente.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkInadimplente.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkInadimplente.Name = "chkInadimplente";
            this.chkInadimplente.Ripple = true;
            this.chkInadimplente.Size = new System.Drawing.Size(110, 30);
            this.chkInadimplente.TabIndex = 65;
            this.chkInadimplente.Text = "Inadimplente";
            this.chkInadimplente.UseVisualStyleBackColor = true;
            // 
            // btnEmailCorrespondencia
            // 
            this.btnEmailCorrespondencia.AutoSize = true;
            this.btnEmailCorrespondencia.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpCampos.SetColumnSpan(this.btnEmailCorrespondencia, 2);
            this.btnEmailCorrespondencia.Depth = 0;
            this.btnEmailCorrespondencia.Icon = null;
            this.btnEmailCorrespondencia.Location = new System.Drawing.Point(4, 508);
            this.btnEmailCorrespondencia.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmailCorrespondencia.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmailCorrespondencia.Name = "btnEmailCorrespondencia";
            this.btnEmailCorrespondencia.Primary = false;
            this.btnEmailCorrespondencia.Size = new System.Drawing.Size(212, 36);
            this.btnEmailCorrespondencia.TabIndex = 66;
            this.btnEmailCorrespondencia.Text = "Aviso de Correspondência";
            this.btnEmailCorrespondencia.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Location = new System.Drawing.Point(449, 505);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 41);
            this.panel1.TabIndex = 67;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(281, 3);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.AutoSize = true;
            this.btnSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnSalvar.Depth = 0;
            this.btnSalvar.Icon = null;
            this.btnSalvar.Location = new System.Drawing.Point(380, 3);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // CadUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(936, 643);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(936, 643);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(936, 643);
            this.Name = "CadUnidade";
            this.Sizable = false;
            this.Text = "Cadastro de Unidade";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutorizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPessoasAutorizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsFuncionarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVeiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.TextBox txtGas;
        private System.Windows.Forms.DataGridView dgvFuncionarios;
        private System.Windows.Forms.DataGridView dgvAutorizadas;
        private System.Windows.Forms.TextBox txtAnimais;
        private System.Windows.Forms.TextBox txtAssinaturas;
        private System.Windows.Forms.DataGridView dgvVeiculos;
        private System.Windows.Forms.BindingSource bsPessoasAutorizadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneResidencialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneComercialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneCelularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn grauParentescoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn veiculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadesDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsFuncionarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn foneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn documentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn autorizadaSemPresencaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn frequenciaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioEntradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horarioSaidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource bsVeiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn placaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn corDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn fotoDataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn unidadeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn proprietarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cboBloco;
        private MaterialSkin.Controls.MaterialLabel lblNumero;
        private MaterialSkin.Controls.MaterialLabel lblUltimaAtualizacao;
        private MaterialSkin.Controls.MaterialLabel lblObs;
        private MaterialSkin.Controls.MaterialLabel lblDtAtualizacao;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNumero;
        private MaterialSkin.Controls.MaterialLabel lblBloco;
        private MaterialSkin.Controls.MaterialLabel lblLocatario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocatario;
        private Desktop.Framework.Botoes.BotaoPessoa botaoEditarLocatario;
        private MaterialSkin.Controls.MaterialLabel lblProprietario;
        private MaterialSkin.Controls.MaterialLabel lblConjuge;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProprietario;
        private Desktop.Framework.Botoes.BotaoPessoa botaoEditarProprietario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtConjuge;
        private Desktop.Framework.Botoes.BotaoPessoa botaoEditarConjuge;
        private Desktop.Framework.Botoes.BotaoAdd botaoAddPessoaAut;
        private Desktop.Framework.Botoes.BotaoAdd botaoAddVeiculo;
        private Desktop.Framework.Botoes.BotaoRemove botaoRemovePessoaAut;
        private Desktop.Framework.Botoes.BotaoRemove botaoRemoveVeiculo;
        private Desktop.Framework.Botoes.BotaoAdd botaoAddFunc;
        private Desktop.Framework.Botoes.BotaoRemove botaoRemoveFunc;
        private MaterialSkin.Controls.MaterialLabel lblFunc;
        private MaterialSkin.Controls.MaterialLabel lblAutorizadas;
        private MaterialSkin.Controls.MaterialLabel lblVeiculos;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel lblAssinaturas;
        private MaterialSkin.Controls.MaterialLabel lblGas;
        private MaterialSkin.Controls.MaterialCheckBox chkInadimplente;
        private MaterialSkin.Controls.MaterialFlatButton btnEmailCorrespondencia;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
    }
}

namespace Portaria.Locais
{
    partial class CadReserva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadReserva));
            this.tlpCampos = new System.Windows.Forms.TableLayoutPanel();
            this.dtInicio = new System.Windows.Forms.DateTimePicker();
            this.bsReserva = new System.Windows.Forms.BindingSource(this.components);
            this.dtFim = new System.Windows.Forms.DateTimePicker();
            this.lblLocal = new MaterialSkin.Controls.MaterialLabel();
            this.txtLocal = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblInicio = new MaterialSkin.Controls.MaterialLabel();
            this.lblFim = new MaterialSkin.Controls.MaterialLabel();
            this.lblSolicitante = new MaterialSkin.Controls.MaterialLabel();
            this.txtSolicitante = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.botaoEditarSolicitante = new Portaria.Desktop.Framework.Botoes.BotaoPessoa();
            this.lblUnidade = new MaterialSkin.Controls.MaterialLabel();
            this.txtUnidade = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.botaoPesquisarUnidade = new Portaria.Desktop.Framework.Botoes.BotaoSearch();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlConteudo.SuspendLayout();
            this.tlpCampos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReserva)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tlpCampos);
            this.pnlConteudo.Size = new System.Drawing.Size(615, 258);
            // 
            // tlpCampos
            // 
            this.tlpCampos.BackColor = System.Drawing.Color.White;
            this.tlpCampos.ColumnCount = 3;
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCampos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCampos.Controls.Add(this.dtInicio, 0, 4);
            this.tlpCampos.Controls.Add(this.dtFim, 2, 4);
            this.tlpCampos.Controls.Add(this.lblLocal, 0, 1);
            this.tlpCampos.Controls.Add(this.txtLocal, 0, 2);
            this.tlpCampos.Controls.Add(this.lblInicio, 0, 3);
            this.tlpCampos.Controls.Add(this.lblFim, 2, 3);
            this.tlpCampos.Controls.Add(this.lblSolicitante, 0, 11);
            this.tlpCampos.Controls.Add(this.txtSolicitante, 0, 12);
            this.tlpCampos.Controls.Add(this.botaoEditarSolicitante, 1, 12);
            this.tlpCampos.Controls.Add(this.lblUnidade, 0, 13);
            this.tlpCampos.Controls.Add(this.txtUnidade, 0, 14);
            this.tlpCampos.Controls.Add(this.botaoPesquisarUnidade, 1, 14);
            this.tlpCampos.Controls.Add(this.panel1, 2, 15);
            this.tlpCampos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCampos.Location = new System.Drawing.Point(0, 0);
            this.tlpCampos.Name = "tlpCampos";
            this.tlpCampos.RowCount = 16;
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
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tlpCampos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpCampos.Size = new System.Drawing.Size(615, 258);
            this.tlpCampos.TabIndex = 2;
            // 
            // dtInicio
            // 
            this.dtInicio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtInicio.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsReserva, "DataHoraInicio", true));
            this.dtInicio.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtInicio.Location = new System.Drawing.Point(3, 70);
            this.dtInicio.Name = "dtInicio";
            this.dtInicio.Size = new System.Drawing.Size(286, 26);
            this.dtInicio.TabIndex = 22;
            this.dtInicio.ValueChanged += new System.EventHandler(this.dtInicio_ValueChanged);
            // 
            // bsReserva
            // 
            this.bsReserva.DataSource = typeof(Portaria.Core.Model.Reserva);
            // 
            // dtFim
            // 
            this.dtFim.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtFim.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtFim.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsReserva, "DataHoraFim", true));
            this.dtFim.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFim.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFim.Location = new System.Drawing.Point(325, 70);
            this.dtFim.Name = "dtFim";
            this.dtFim.Size = new System.Drawing.Size(287, 26);
            this.dtFim.TabIndex = 23;
            // 
            // lblLocal
            // 
            this.lblLocal.AutoSize = true;
            this.lblLocal.Depth = 0;
            this.lblLocal.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLocal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLocal.Location = new System.Drawing.Point(3, 0);
            this.lblLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLocal.Name = "lblLocal";
            this.lblLocal.Size = new System.Drawing.Size(46, 19);
            this.lblLocal.TabIndex = 32;
            this.lblLocal.Text = "Local";
            // 
            // txtLocal
            // 
            this.txtLocal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLocal.Depth = 0;
            this.txtLocal.Enabled = false;
            this.txtLocal.Hint = "";
            this.txtLocal.Location = new System.Drawing.Point(3, 22);
            this.txtLocal.MaxLength = 32767;
            this.txtLocal.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.PasswordChar = '\0';
            this.txtLocal.SelectedText = "";
            this.txtLocal.SelectionLength = 0;
            this.txtLocal.SelectionStart = 0;
            this.txtLocal.Size = new System.Drawing.Size(286, 23);
            this.txtLocal.TabIndex = 33;
            this.txtLocal.TabStop = false;
            this.txtLocal.UseSystemPasswordChar = false;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Depth = 0;
            this.lblInicio.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblInicio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblInicio.Location = new System.Drawing.Point(3, 48);
            this.lblInicio.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(46, 19);
            this.lblInicio.TabIndex = 34;
            this.lblInicio.Text = "Início";
            // 
            // lblFim
            // 
            this.lblFim.AutoSize = true;
            this.lblFim.Depth = 0;
            this.lblFim.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblFim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFim.Location = new System.Drawing.Point(325, 48);
            this.lblFim.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFim.Name = "lblFim";
            this.lblFim.Size = new System.Drawing.Size(34, 19);
            this.lblFim.TabIndex = 35;
            this.lblFim.Text = "Fim";
            // 
            // lblSolicitante
            // 
            this.lblSolicitante.AutoSize = true;
            this.lblSolicitante.Depth = 0;
            this.lblSolicitante.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSolicitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSolicitante.Location = new System.Drawing.Point(3, 99);
            this.lblSolicitante.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSolicitante.Name = "lblSolicitante";
            this.lblSolicitante.Size = new System.Drawing.Size(81, 19);
            this.lblSolicitante.TabIndex = 36;
            this.lblSolicitante.Text = "Solicitante";
            // 
            // txtSolicitante
            // 
            this.txtSolicitante.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSolicitante.Depth = 0;
            this.txtSolicitante.Hint = "";
            this.txtSolicitante.Location = new System.Drawing.Point(3, 121);
            this.txtSolicitante.MaxLength = 32767;
            this.txtSolicitante.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSolicitante.Name = "txtSolicitante";
            this.txtSolicitante.PasswordChar = '\0';
            this.txtSolicitante.SelectedText = "";
            this.txtSolicitante.SelectionLength = 0;
            this.txtSolicitante.SelectionStart = 0;
            this.txtSolicitante.Size = new System.Drawing.Size(286, 23);
            this.txtSolicitante.TabIndex = 37;
            this.txtSolicitante.TabStop = false;
            this.txtSolicitante.UseSystemPasswordChar = false;
            // 
            // botaoEditarSolicitante
            // 
            this.botaoEditarSolicitante.BackColor = System.Drawing.Color.Transparent;
            this.botaoEditarSolicitante.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoEditarSolicitante.BackgroundImage")));
            this.botaoEditarSolicitante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoEditarSolicitante.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditarSolicitante.Location = new System.Drawing.Point(295, 121);
            this.botaoEditarSolicitante.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarSolicitante.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoEditarSolicitante.Name = "botaoEditarSolicitante";
            this.botaoEditarSolicitante.Size = new System.Drawing.Size(24, 24);
            this.botaoEditarSolicitante.TabIndex = 38;
            this.botaoEditarSolicitante.Click += new System.EventHandler(this.botaoEditarSolicitante_Click);
            // 
            // lblUnidade
            // 
            this.lblUnidade.AutoSize = true;
            this.lblUnidade.Depth = 0;
            this.lblUnidade.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUnidade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUnidade.Location = new System.Drawing.Point(3, 148);
            this.lblUnidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUnidade.Name = "lblUnidade";
            this.lblUnidade.Size = new System.Drawing.Size(63, 19);
            this.lblUnidade.TabIndex = 39;
            this.lblUnidade.Text = "Unidade";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUnidade.Depth = 0;
            this.txtUnidade.Enabled = false;
            this.txtUnidade.Hint = "";
            this.txtUnidade.Location = new System.Drawing.Point(3, 170);
            this.txtUnidade.MaxLength = 32767;
            this.txtUnidade.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.PasswordChar = '\0';
            this.txtUnidade.SelectedText = "";
            this.txtUnidade.SelectionLength = 0;
            this.txtUnidade.SelectionStart = 0;
            this.txtUnidade.Size = new System.Drawing.Size(286, 23);
            this.txtUnidade.TabIndex = 40;
            this.txtUnidade.TabStop = false;
            this.txtUnidade.UseSystemPasswordChar = false;
            // 
            // botaoPesquisarUnidade
            // 
            this.botaoPesquisarUnidade.BackColor = System.Drawing.Color.Transparent;
            this.botaoPesquisarUnidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPesquisarUnidade.BackgroundImage")));
            this.botaoPesquisarUnidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoPesquisarUnidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisarUnidade.Location = new System.Drawing.Point(295, 170);
            this.botaoPesquisarUnidade.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoPesquisarUnidade.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoPesquisarUnidade.Name = "botaoPesquisarUnidade";
            this.botaoPesquisarUnidade.Size = new System.Drawing.Size(24, 24);
            this.botaoPesquisarUnidade.TabIndex = 41;
            this.botaoPesquisarUnidade.Click += new System.EventHandler(this.botaoPesquisarUnidade_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.botaoSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(325, 200);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 55);
            this.panel1.TabIndex = 42;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.AutoSize = true;
            this.botaoSalvar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.botaoSalvar.Depth = 0;
            this.botaoSalvar.Icon = null;
            this.botaoSalvar.Location = new System.Drawing.Point(215, 16);
            this.botaoSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.botaoSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Primary = true;
            this.botaoSalvar.Size = new System.Drawing.Size(72, 36);
            this.botaoSalvar.TabIndex = 0;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(116, 16);
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
            // CadReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(621, 329);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(621, 329);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(621, 329);
            this.Name = "CadReserva";
            this.Sizable = false;
            this.Text = "Cadastro de Reserva";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpCampos.ResumeLayout(false);
            this.tlpCampos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReserva)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpCampos;
        private System.Windows.Forms.DateTimePicker dtInicio;
        private System.Windows.Forms.DateTimePicker dtFim;
        private System.Windows.Forms.BindingSource bsReserva;
        private MaterialSkin.Controls.MaterialLabel lblLocal;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtLocal;
        private MaterialSkin.Controls.MaterialLabel lblInicio;
        private MaterialSkin.Controls.MaterialLabel lblFim;
        private MaterialSkin.Controls.MaterialLabel lblSolicitante;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSolicitante;
        private Desktop.Framework.Botoes.BotaoPessoa botaoEditarSolicitante;
        private MaterialSkin.Controls.MaterialLabel lblUnidade;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUnidade;
        private Desktop.Framework.Botoes.BotaoSearch botaoPesquisarUnidade;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialFlatButton botaoSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
    }
}
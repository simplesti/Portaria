namespace Portaria
{
    partial class SelecionaEntidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelecionaEntidade));
            this.botaoPesquisar = new Portaria.Framework.Botoes.BotaoPesquisar();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cboTipo = new System.Windows.Forms.ComboBox();
            this.botaoCancelar = new Portaria.Framework.Botoes.BotaoCancelar();
            this.botaoOK = new Portaria.Framework.Botoes.BotaoOK();
            this.chkSomente30 = new System.Windows.Forms.CheckBox();
            this.dgvEntidades = new System.Windows.Forms.DataGridView();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.botaoCancelar);
            this.pnlConteudo.Controls.Add(this.botaoOK);
            this.pnlConteudo.Controls.Add(this.chkSomente30);
            this.pnlConteudo.Controls.Add(this.dgvEntidades);
            this.pnlConteudo.Controls.Add(this.cboTipo);
            this.pnlConteudo.Controls.Add(this.lblTipo);
            this.pnlConteudo.Controls.Add(this.txtPesquisar);
            this.pnlConteudo.Controls.Add(this.lblPesquisar);
            this.pnlConteudo.Controls.Add(this.botaoPesquisar);
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.AutoSize = true;
            this.botaoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisar.Image")));
            this.botaoPesquisar.Location = new System.Drawing.Point(583, 41);
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
            this.lblPesquisar.Location = new System.Drawing.Point(19, 32);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 1;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(22, 48);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(357, 20);
            this.txtPesquisar.TabIndex = 0;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(382, 32);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(87, 13);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de entidade";
            // 
            // cboTipo
            // 
            this.cboTipo.FormattingEnabled = true;
            this.cboTipo.Location = new System.Drawing.Point(385, 48);
            this.cboTipo.Name = "cboTipo";
            this.cboTipo.Size = new System.Drawing.Size(192, 21);
            this.cboTipo.TabIndex = 1;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(515, 349);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 35);
            this.botaoCancelar.TabIndex = 5;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoOK
            // 
            this.botaoOK.BackColor = System.Drawing.Color.White;
            this.botaoOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoOK.Image = ((System.Drawing.Image)(resources.GetObject("botaoOK.Image")));
            this.botaoOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoOK.Location = new System.Drawing.Point(409, 349);
            this.botaoOK.Name = "botaoOK";
            this.botaoOK.Size = new System.Drawing.Size(100, 35);
            this.botaoOK.TabIndex = 4;
            this.botaoOK.Text = "OK";
            this.botaoOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoOK.UseVisualStyleBackColor = false;
            this.botaoOK.Click += new System.EventHandler(this.botaoOK_Click);
            // 
            // chkSomente30
            // 
            this.chkSomente30.AutoSize = true;
            this.chkSomente30.Checked = true;
            this.chkSomente30.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSomente30.Location = new System.Drawing.Point(22, 74);
            this.chkSomente30.Name = "chkSomente30";
            this.chkSomente30.Size = new System.Drawing.Size(167, 17);
            this.chkSomente30.TabIndex = 7;
            this.chkSomente30.Text = "Exibir somente os 30 primeiros";
            this.chkSomente30.UseVisualStyleBackColor = true;
            // 
            // dgvEntidades
            // 
            this.dgvEntidades.AllowUserToResizeRows = false;
            this.dgvEntidades.BackgroundColor = System.Drawing.Color.White;
            this.dgvEntidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntidades.Location = new System.Drawing.Point(22, 97);
            this.dgvEntidades.Name = "dgvEntidades";
            this.dgvEntidades.ReadOnly = true;
            this.dgvEntidades.RowHeadersVisible = false;
            this.dgvEntidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntidades.Size = new System.Drawing.Size(593, 241);
            this.dgvEntidades.TabIndex = 3;
            this.dgvEntidades.SelectionChanged += new System.EventHandler(this.dgvEntidades_SelectionChanged);
            // 
            // SelecionaEntidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 480);
            this.Name = "SelecionaEntidade";
            this.Text = "SelecionaEntidade";
            this.Titulo = "Selecionar Entidade";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtPesquisar;
        private System.Windows.Forms.Label lblPesquisar;
        private Framework.Botoes.BotaoPesquisar botaoPesquisar;
        private System.Windows.Forms.ComboBox cboTipo;
        private System.Windows.Forms.Label lblTipo;
        private Framework.Botoes.BotaoCancelar botaoCancelar;
        private Framework.Botoes.BotaoOK botaoOK;
        private System.Windows.Forms.CheckBox chkSomente30;
        private System.Windows.Forms.DataGridView dgvEntidades;
    }
}
namespace Portaria.ConfiguradorBD
{
    partial class ConfiguradorBancoDados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguradorBancoDados));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBase = new System.Windows.Forms.TableLayoutPanel();
            this.lblBase = new System.Windows.Forms.Label();
            this.cboBaseDados = new System.Windows.Forms.ComboBox();
            this.botaoAdicionarBase = new Portaria.Desktop.Framework.Botoes.BotaoAdicionar();
            this.lblTipoServidor = new System.Windows.Forms.Label();
            this.cboTIpoServidor = new System.Windows.Forms.ComboBox();
            this.lblEnderecoServidor = new System.Windows.Forms.Label();
            this.lblUsuarioServidor = new System.Windows.Forms.Label();
            this.lblSenhaServidor = new System.Windows.Forms.Label();
            this.txtEnderecoServidor = new System.Windows.Forms.TextBox();
            this.txtUsuarioServidor = new System.Windows.Forms.TextBox();
            this.txtSenhaServidor = new System.Windows.Forms.TextBox();
            this.botaoTestarConexao = new Portaria.Desktop.Framework.Botoes.BotaoTestarConexao();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.botaoSalvar = new Portaria.Desktop.Framework.Botoes.BotaoSalvar();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpBase.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(478, 30);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Portaria Digital - Configurador de Banco de Dados";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tlpBase, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblTipoServidor, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboTIpoServidor, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblEnderecoServidor, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUsuarioServidor, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSenhaServidor, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtEnderecoServidor, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtUsuarioServidor, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtSenhaServidor, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.botaoTestarConexao, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 54);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 72F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 245);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // tlpBase
            // 
            this.tlpBase.ColumnCount = 2;
            this.tableLayoutPanel1.SetColumnSpan(this.tlpBase, 2);
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBase.Controls.Add(this.lblBase, 0, 0);
            this.tlpBase.Controls.Add(this.cboBaseDados, 0, 1);
            this.tlpBase.Controls.Add(this.botaoAdicionarBase, 1, 1);
            this.tlpBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBase.Location = new System.Drawing.Point(3, 123);
            this.tlpBase.Name = "tlpBase";
            this.tlpBase.RowCount = 2;
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBase.Size = new System.Drawing.Size(574, 47);
            this.tlpBase.TabIndex = 11;
            this.tlpBase.Visible = false;
            // 
            // lblBase
            // 
            this.lblBase.AutoSize = true;
            this.lblBase.Location = new System.Drawing.Point(3, 0);
            this.lblBase.Name = "lblBase";
            this.lblBase.Size = new System.Drawing.Size(78, 13);
            this.lblBase.TabIndex = 0;
            this.lblBase.Text = "Base de dados";
            // 
            // cboBaseDados
            // 
            this.cboBaseDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBaseDados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaseDados.FormattingEnabled = true;
            this.cboBaseDados.Location = new System.Drawing.Point(3, 19);
            this.cboBaseDados.Name = "cboBaseDados";
            this.cboBaseDados.Size = new System.Drawing.Size(281, 21);
            this.cboBaseDados.TabIndex = 1;
            // 
            // botaoAdicionarBase
            // 
            this.botaoAdicionarBase.AutoSize = true;
            this.botaoAdicionarBase.BackColor = System.Drawing.Color.White;
            this.botaoAdicionarBase.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdicionarBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAdicionarBase.Image = ((System.Drawing.Image)(resources.GetObject("botaoAdicionarBase.Image")));
            this.botaoAdicionarBase.Location = new System.Drawing.Point(290, 16);
            this.botaoAdicionarBase.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionarBase.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdicionarBase.Name = "botaoAdicionarBase";
            this.botaoAdicionarBase.Size = new System.Drawing.Size(24, 24);
            this.botaoAdicionarBase.TabIndex = 2;
            this.botaoAdicionarBase.UseVisualStyleBackColor = false;
            this.botaoAdicionarBase.Click += new System.EventHandler(this.botaoAdicionarBase_Click);
            // 
            // lblTipoServidor
            // 
            this.lblTipoServidor.AutoSize = true;
            this.lblTipoServidor.Location = new System.Drawing.Point(3, 0);
            this.lblTipoServidor.Name = "lblTipoServidor";
            this.lblTipoServidor.Size = new System.Drawing.Size(86, 13);
            this.lblTipoServidor.TabIndex = 0;
            this.lblTipoServidor.Text = "Tipo  de servidor";
            // 
            // cboTIpoServidor
            // 
            this.cboTIpoServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTIpoServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTIpoServidor.FormattingEnabled = true;
            this.cboTIpoServidor.Location = new System.Drawing.Point(3, 16);
            this.cboTIpoServidor.Name = "cboTIpoServidor";
            this.cboTIpoServidor.Size = new System.Drawing.Size(284, 21);
            this.cboTIpoServidor.TabIndex = 1;
            // 
            // lblEnderecoServidor
            // 
            this.lblEnderecoServidor.AutoSize = true;
            this.lblEnderecoServidor.Location = new System.Drawing.Point(293, 0);
            this.lblEnderecoServidor.Name = "lblEnderecoServidor";
            this.lblEnderecoServidor.Size = new System.Drawing.Size(108, 13);
            this.lblEnderecoServidor.TabIndex = 2;
            this.lblEnderecoServidor.Text = "Endereço do servidor";
            // 
            // lblUsuarioServidor
            // 
            this.lblUsuarioServidor.AutoSize = true;
            this.lblUsuarioServidor.Location = new System.Drawing.Point(3, 40);
            this.lblUsuarioServidor.Name = "lblUsuarioServidor";
            this.lblUsuarioServidor.Size = new System.Drawing.Size(98, 13);
            this.lblUsuarioServidor.TabIndex = 3;
            this.lblUsuarioServidor.Text = "Usuário do servidor";
            // 
            // lblSenhaServidor
            // 
            this.lblSenhaServidor.AutoSize = true;
            this.lblSenhaServidor.Location = new System.Drawing.Point(293, 40);
            this.lblSenhaServidor.Name = "lblSenhaServidor";
            this.lblSenhaServidor.Size = new System.Drawing.Size(93, 13);
            this.lblSenhaServidor.TabIndex = 4;
            this.lblSenhaServidor.Text = "Senha do servidor";
            // 
            // txtEnderecoServidor
            // 
            this.txtEnderecoServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnderecoServidor.Location = new System.Drawing.Point(293, 16);
            this.txtEnderecoServidor.Name = "txtEnderecoServidor";
            this.txtEnderecoServidor.Size = new System.Drawing.Size(284, 20);
            this.txtEnderecoServidor.TabIndex = 5;
            // 
            // txtUsuarioServidor
            // 
            this.txtUsuarioServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioServidor.Location = new System.Drawing.Point(3, 56);
            this.txtUsuarioServidor.Name = "txtUsuarioServidor";
            this.txtUsuarioServidor.Size = new System.Drawing.Size(284, 20);
            this.txtUsuarioServidor.TabIndex = 6;
            // 
            // txtSenhaServidor
            // 
            this.txtSenhaServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaServidor.Location = new System.Drawing.Point(293, 56);
            this.txtSenhaServidor.Name = "txtSenhaServidor";
            this.txtSenhaServidor.PasswordChar = '*';
            this.txtSenhaServidor.Size = new System.Drawing.Size(284, 20);
            this.txtSenhaServidor.TabIndex = 7;
            // 
            // botaoTestarConexao
            // 
            this.botaoTestarConexao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoTestarConexao.BackColor = System.Drawing.Color.White;
            this.botaoTestarConexao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoTestarConexao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoTestarConexao.Image = ((System.Drawing.Image)(resources.GetObject("botaoTestarConexao.Image")));
            this.botaoTestarConexao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoTestarConexao.Location = new System.Drawing.Point(442, 82);
            this.botaoTestarConexao.Name = "botaoTestarConexao";
            this.botaoTestarConexao.Size = new System.Drawing.Size(135, 35);
            this.botaoTestarConexao.TabIndex = 8;
            this.botaoTestarConexao.Text = "Testar Conexão";
            this.botaoTestarConexao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoTestarConexao.UseVisualStyleBackColor = false;
            this.botaoTestarConexao.Click += new System.EventHandler(this.botaoTestarConexao_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botaoCancelar);
            this.panel1.Controls.Add(this.botaoSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(293, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 66);
            this.panel1.TabIndex = 12;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(72, 12);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 35);
            this.botaoCancelar.TabIndex = 4;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.BackColor = System.Drawing.Color.White;
            this.botaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoSalvar.Location = new System.Drawing.Point(178, 12);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(100, 35);
            this.botaoSalvar.TabIndex = 3;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Visible = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // ConfiguradorBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 322);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ConfiguradorBancoDados";
            this.Text = "Portaria Digital - Configurador do banco de dados";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tlpBase.ResumeLayout(false);
            this.tlpBase.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTipoServidor;
        private System.Windows.Forms.ComboBox cboTIpoServidor;
        private System.Windows.Forms.Label lblEnderecoServidor;
        private System.Windows.Forms.Label lblUsuarioServidor;
        private System.Windows.Forms.Label lblSenhaServidor;
        private System.Windows.Forms.TextBox txtEnderecoServidor;
        private System.Windows.Forms.TextBox txtUsuarioServidor;
        private System.Windows.Forms.TextBox txtSenhaServidor;
        private Desktop.Framework.Botoes.BotaoTestarConexao botaoTestarConexao;
        private System.Windows.Forms.TableLayoutPanel tlpBase;
        private System.Windows.Forms.Label lblBase;
        private System.Windows.Forms.ComboBox cboBaseDados;
        private Desktop.Framework.Botoes.BotaoAdicionar botaoAdicionarBase;
        private System.Windows.Forms.Panel panel1;
        private Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private Desktop.Framework.Botoes.BotaoSalvar botaoSalvar;
    }
}


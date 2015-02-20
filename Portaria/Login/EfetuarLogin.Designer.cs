namespace Portaria.Login
{
    partial class EfetuarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EfetuarLogin));
            this.tlpConteudo = new System.Windows.Forms.TableLayoutPanel();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.botaoOK = new Portaria.Framework.Botoes.BotaoOK();
            this.botaoCancelar = new Portaria.Framework.Botoes.BotaoCancelar();
            this.pnlConteudo.SuspendLayout();
            this.tlpConteudo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.pnlConteudo.Controls.Add(this.tlpConteudo);
            this.pnlConteudo.Size = new System.Drawing.Size(530, 254);
            // 
            // tlpConteudo
            // 
            this.tlpConteudo.ColumnCount = 2;
            this.tlpConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 342F));
            this.tlpConteudo.Controls.Add(this.lblBemVindo, 0, 0);
            this.tlpConteudo.Controls.Add(this.lblUsuario, 0, 1);
            this.tlpConteudo.Controls.Add(this.lblSenha, 0, 2);
            this.tlpConteudo.Controls.Add(this.txtUsuario, 1, 1);
            this.tlpConteudo.Controls.Add(this.txtSenha, 1, 2);
            this.tlpConteudo.Controls.Add(this.pnlBotoes, 0, 3);
            this.tlpConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConteudo.Location = new System.Drawing.Point(0, 0);
            this.tlpConteudo.Name = "tlpConteudo";
            this.tlpConteudo.RowCount = 4;
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.34177F));
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.tlpConteudo.Size = new System.Drawing.Size(530, 254);
            this.tlpConteudo.TabIndex = 0;
            // 
            // lblBemVindo
            // 
            this.tlpConteudo.SetColumnSpan(this.lblBemVindo, 2);
            this.lblBemVindo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(3, 0);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(524, 116);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem vindo ao Portaria Digital!";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(139, 122);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(144, 148);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 2;
            this.lblSenha.Text = "Senha:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(191, 119);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(198, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(191, 145);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(198, 20);
            this.txtSenha.TabIndex = 1;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // pnlBotoes
            // 
            this.tlpConteudo.SetColumnSpan(this.pnlBotoes, 2);
            this.pnlBotoes.Controls.Add(this.botaoOK);
            this.pnlBotoes.Controls.Add(this.botaoCancelar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotoes.Location = new System.Drawing.Point(3, 171);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(524, 80);
            this.pnlBotoes.TabIndex = 5;
            // 
            // botaoOK
            // 
            this.botaoOK.BackColor = System.Drawing.Color.White;
            this.botaoOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoOK.Image = ((System.Drawing.Image)(resources.GetObject("botaoOK.Image")));
            this.botaoOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoOK.Location = new System.Drawing.Point(159, 23);
            this.botaoOK.Name = "botaoOK";
            this.botaoOK.Size = new System.Drawing.Size(100, 35);
            this.botaoOK.TabIndex = 0;
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
            this.botaoCancelar.Location = new System.Drawing.Point(265, 23);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 35);
            this.botaoCancelar.TabIndex = 1;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // EfetuarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 317);
            this.MaximumSize = new System.Drawing.Size(536, 317);
            this.MinimumSize = new System.Drawing.Size(536, 317);
            this.Name = "EfetuarLogin";
            this.Text = "EfetuarLogin";
            this.Titulo = "Efetuar Login";
            this.pnlConteudo.ResumeLayout(false);
            this.tlpConteudo.ResumeLayout(false);
            this.tlpConteudo.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpConteudo;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Panel pnlBotoes;
        private Framework.Botoes.BotaoOK botaoOK;
        private Framework.Botoes.BotaoCancelar botaoCancelar;
    }
}
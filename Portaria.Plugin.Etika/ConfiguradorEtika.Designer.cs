namespace Portaria.Plugin.Etika
{
    partial class ConfiguradorEtika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguradorEtika));
            this.tlpConteudo = new System.Windows.Forms.TableLayoutPanel();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.botaoSalvar = new Portaria.Desktop.Framework.Botoes.BotaoSalvar();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.tlpConteudo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpConteudo
            // 
            this.tlpConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpConteudo.ColumnCount = 1;
            this.tlpConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConteudo.Controls.Add(this.txtUsuario, 0, 3);
            this.tlpConteudo.Controls.Add(this.txtSenha, 0, 5);
            this.tlpConteudo.Controls.Add(this.label2, 0, 2);
            this.tlpConteudo.Controls.Add(this.label3, 0, 4);
            this.tlpConteudo.Controls.Add(this.pnlBotoes, 0, 6);
            this.tlpConteudo.Location = new System.Drawing.Point(12, 12);
            this.tlpConteudo.Name = "tlpConteudo";
            this.tlpConteudo.RowCount = 7;
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConteudo.Size = new System.Drawing.Size(418, 171);
            this.tlpConteudo.TabIndex = 0;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuario.Location = new System.Drawing.Point(3, 16);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(412, 20);
            this.txtUsuario.TabIndex = 1;
            // 
            // txtSenha
            // 
            this.txtSenha.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenha.Location = new System.Drawing.Point(3, 55);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(412, 20);
            this.txtSenha.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Usuário";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha";
            // 
            // pnlBotoes
            // 
            this.pnlBotoes.Controls.Add(this.botaoSalvar);
            this.pnlBotoes.Controls.Add(this.botaoCancelar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotoes.Location = new System.Drawing.Point(3, 81);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(412, 87);
            this.pnlBotoes.TabIndex = 6;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoSalvar.BackColor = System.Drawing.Color.White;
            this.botaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoSalvar.Location = new System.Drawing.Point(203, 49);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(100, 35);
            this.botaoSalvar.TabIndex = 1;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(309, 49);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 35);
            this.botaoCancelar.TabIndex = 0;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // ConfiguradorEtika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 195);
            this.Controls.Add(this.tlpConteudo);
            this.Name = "ConfiguradorEtika";
            this.Text = "ConfiguradorEtika";
            this.tlpConteudo.ResumeLayout(false);
            this.tlpConteudo.PerformLayout();
            this.pnlBotoes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpConteudo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlBotoes;
        private Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private Desktop.Framework.Botoes.BotaoSalvar botaoSalvar;
    }
}
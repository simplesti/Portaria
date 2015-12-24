namespace Portaria.Unidades
{
    partial class EnviarCorrespondencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EnviarCorrespondencia));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTituloEmail = new System.Windows.Forms.Label();
            this.txtTituloEmail = new System.Windows.Forms.TextBox();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.lblMensagem = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoOK = new Portaria.Desktop.Framework.Botoes.BotaoOK();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.pnlConteudo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tableLayoutPanel1);
            this.pnlConteudo.Size = new System.Drawing.Size(763, 296);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblTituloEmail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTituloEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMensagem, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblMensagem, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(763, 296);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTituloEmail
            // 
            this.lblTituloEmail.AutoSize = true;
            this.lblTituloEmail.Location = new System.Drawing.Point(3, 0);
            this.lblTituloEmail.Name = "lblTituloEmail";
            this.lblTituloEmail.Size = new System.Drawing.Size(78, 13);
            this.lblTituloEmail.TabIndex = 0;
            this.lblTituloEmail.Text = "Titulo do e-mail";
            // 
            // txtTituloEmail
            // 
            this.txtTituloEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTituloEmail.Location = new System.Drawing.Point(3, 16);
            this.txtTituloEmail.Name = "txtTituloEmail";
            this.txtTituloEmail.Size = new System.Drawing.Size(757, 20);
            this.txtTituloEmail.TabIndex = 1;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensagem.Location = new System.Drawing.Point(3, 55);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(757, 179);
            this.txtMensagem.TabIndex = 2;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Location = new System.Drawing.Point(3, 39);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(59, 13);
            this.lblMensagem.TabIndex = 3;
            this.lblMensagem.Text = "Mensagem";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botaoCancelar);
            this.panel1.Controls.Add(this.botaoOK);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 240);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 53);
            this.panel1.TabIndex = 4;
            // 
            // botaoOK
            // 
            this.botaoOK.BackColor = System.Drawing.Color.White;
            this.botaoOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoOK.Image = ((System.Drawing.Image)(resources.GetObject("botaoOK.Image")));
            this.botaoOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoOK.Location = new System.Drawing.Point(651, 12);
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
            this.botaoCancelar.Location = new System.Drawing.Point(545, 12);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 35);
            this.botaoCancelar.TabIndex = 1;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // EnviarCorrespondencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 359);
            this.ConfiguracoesUsuarioVisivel = true;
            this.Name = "EnviarCorrespondencia";
            this.Text = "EnviarCorrespondencia";
            this.Titulo = "Aviso de Correspondência";
            this.pnlConteudo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblTituloEmail;
        private System.Windows.Forms.TextBox txtTituloEmail;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Label lblMensagem;
        private System.Windows.Forms.Panel panel1;
        private Desktop.Framework.Botoes.BotaoOK botaoOK;
        private Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
    }
}
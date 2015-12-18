﻿namespace Portaria.Desktop.Framework.Forms
{
    partial class FormBaseWindow
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
            this.tlpFundo = new System.Windows.Forms.TableLayoutPanel();
            this.tlpCabecalho = new System.Windows.Forms.TableLayoutPanel();
            this.Minimizar = new System.Windows.Forms.PictureBox();
            this.Icone = new System.Windows.Forms.PictureBox();
            this.Fechar = new System.Windows.Forms.PictureBox();
            this.Maximizar = new System.Windows.Forms.PictureBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.ConfiguracoesUsuario = new System.Windows.Forms.PictureBox();
            this.pnlFundo = new System.Windows.Forms.Panel();
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.tlpFundo.SuspendLayout();
            this.tlpCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfiguracoesUsuario)).BeginInit();
            this.pnlFundo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpFundo
            // 
            this.tlpFundo.ColumnCount = 1;
            this.tlpFundo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFundo.Controls.Add(this.tlpCabecalho, 0, 0);
            this.tlpFundo.Controls.Add(this.pnlFundo, 0, 1);
            this.tlpFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFundo.Location = new System.Drawing.Point(0, 0);
            this.tlpFundo.Name = "tlpFundo";
            this.tlpFundo.RowCount = 2;
            this.tlpFundo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpFundo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFundo.Size = new System.Drawing.Size(769, 480);
            this.tlpFundo.TabIndex = 0;
            this.tlpFundo.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tlpCabecalho
            // 
            this.tlpCabecalho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tlpCabecalho.AutoSize = true;
            this.tlpCabecalho.ColumnCount = 6;
            this.tlpCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCabecalho.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpCabecalho.Controls.Add(this.Minimizar, 3, 0);
            this.tlpCabecalho.Controls.Add(this.Icone, 0, 0);
            this.tlpCabecalho.Controls.Add(this.Fechar, 5, 0);
            this.tlpCabecalho.Controls.Add(this.Maximizar, 4, 0);
            this.tlpCabecalho.Controls.Add(this.lblTitulo, 1, 0);
            this.tlpCabecalho.Controls.Add(this.ConfiguracoesUsuario, 2, 0);
            this.tlpCabecalho.Location = new System.Drawing.Point(3, 3);
            this.tlpCabecalho.Name = "tlpCabecalho";
            this.tlpCabecalho.RowCount = 1;
            this.tlpCabecalho.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpCabecalho.Size = new System.Drawing.Size(763, 51);
            this.tlpCabecalho.TabIndex = 0;
            this.tlpCabecalho.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseDown);
            this.tlpCabecalho.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseMove);
            this.tlpCabecalho.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseUp);
            // 
            // Minimizar
            // 
            this.Minimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimizar.Image = global::Portaria.Desktop.Framework.Properties.Resources.min_blue;
            this.Minimizar.Location = new System.Drawing.Point(613, 3);
            this.Minimizar.Name = "Minimizar";
            this.Minimizar.Size = new System.Drawing.Size(45, 45);
            this.Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Minimizar.TabIndex = 2;
            this.Minimizar.TabStop = false;
            this.Minimizar.Click += new System.EventHandler(this.Minimizar_Click);
            // 
            // Icone
            // 
            this.Icone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icone.Image = global::Portaria.Desktop.Framework.Properties.Resources.revision_enterprise_3d;
            this.Icone.Location = new System.Drawing.Point(3, 3);
            this.Icone.Name = "Icone";
            this.Icone.Size = new System.Drawing.Size(45, 45);
            this.Icone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Icone.TabIndex = 4;
            this.Icone.TabStop = false;
            this.Icone.Click += new System.EventHandler(this.Icone_Click);
            // 
            // Fechar
            // 
            this.Fechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Fechar.Image = global::Portaria.Desktop.Framework.Properties.Resources.close_blue;
            this.Fechar.Location = new System.Drawing.Point(715, 3);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(45, 45);
            this.Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Fechar.TabIndex = 0;
            this.Fechar.TabStop = false;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Maximizar
            // 
            this.Maximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Maximizar.Image = global::Portaria.Desktop.Framework.Properties.Resources.max_blue;
            this.Maximizar.Location = new System.Drawing.Point(664, 3);
            this.Maximizar.Name = "Maximizar";
            this.Maximizar.Size = new System.Drawing.Size(45, 45);
            this.Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Maximizar.TabIndex = 5;
            this.Maximizar.TabStop = false;
            this.Maximizar.Click += new System.EventHandler(this.Maximizar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(54, 10);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(65, 30);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseDown);
            this.lblTitulo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseMove);
            this.lblTitulo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseUp);
            // 
            // ConfiguracoesUsuario
            // 
            this.ConfiguracoesUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfiguracoesUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfiguracoesUsuario.Image = global::Portaria.Desktop.Framework.Properties.Resources.blue_config;
            this.ConfiguracoesUsuario.Location = new System.Drawing.Point(591, 27);
            this.ConfiguracoesUsuario.Margin = new System.Windows.Forms.Padding(3, 3, 3, 8);
            this.ConfiguracoesUsuario.Name = "ConfiguracoesUsuario";
            this.ConfiguracoesUsuario.Size = new System.Drawing.Size(16, 16);
            this.ConfiguracoesUsuario.TabIndex = 6;
            this.ConfiguracoesUsuario.TabStop = false;
            this.ConfiguracoesUsuario.Click += new System.EventHandler(this.botaoConfig_Click);
            // 
            // pnlFundo
            // 
            this.pnlFundo.Controls.Add(this.pnlConteudo);
            this.pnlFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFundo.Location = new System.Drawing.Point(3, 60);
            this.pnlFundo.Name = "pnlFundo";
            this.pnlFundo.Size = new System.Drawing.Size(763, 417);
            this.pnlFundo.TabIndex = 1;
            this.pnlFundo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseDown);
            this.pnlFundo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseMove);
            this.pnlFundo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.tableLayoutPanel2_MouseUp);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 0);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(763, 417);
            this.pnlConteudo.TabIndex = 0;
            // 
            // FormBaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 480);
            this.Controls.Add(this.tlpFundo);
            this.Name = "FormBaseWindow";
            this.Text = "p";
            this.tlpFundo.ResumeLayout(false);
            this.tlpFundo.PerformLayout();
            this.tlpCabecalho.ResumeLayout(false);
            this.tlpCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Icone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Fechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfiguracoesUsuario)).EndInit();
            this.pnlFundo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.TableLayoutPanel tlpCabecalho;
        public System.Windows.Forms.PictureBox Fechar;
        public System.Windows.Forms.PictureBox Minimizar;
        public System.Windows.Forms.Label lblTitulo;
        public System.Windows.Forms.Panel pnlFundo;
        public System.Windows.Forms.TableLayoutPanel tlpFundo;
        public System.Windows.Forms.Panel pnlConteudo;
        private System.Windows.Forms.PictureBox Icone;
        private System.Windows.Forms.PictureBox Maximizar;
        private System.Windows.Forms.PictureBox ConfiguracoesUsuario;

    }
}
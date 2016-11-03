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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtMensagem = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTituloEmail = new MaterialSkin.Controls.MaterialLabel();
            this.txtTituloEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.lblMensagem = new MaterialSkin.Controls.MaterialLabel();
            this.btnEnviarEmail = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlConteudo.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tableLayoutPanel1);
            this.pnlConteudo.Size = new System.Drawing.Size(764, 298);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtMensagem, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblTituloEmail, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTituloEmail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMensagem, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 185F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 298);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtMensagem
            // 
            this.txtMensagem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMensagem.Location = new System.Drawing.Point(3, 70);
            this.txtMensagem.Multiline = true;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.Size = new System.Drawing.Size(758, 179);
            this.txtMensagem.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnEnviarEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 255);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(758, 40);
            this.panel1.TabIndex = 4;
            // 
            // lblTituloEmail
            // 
            this.lblTituloEmail.AutoSize = true;
            this.lblTituloEmail.Depth = 0;
            this.lblTituloEmail.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTituloEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTituloEmail.Location = new System.Drawing.Point(3, 0);
            this.lblTituloEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTituloEmail.Name = "lblTituloEmail";
            this.lblTituloEmail.Size = new System.Drawing.Size(115, 19);
            this.lblTituloEmail.TabIndex = 5;
            this.lblTituloEmail.Text = "Titulo do E-mail";
            // 
            // txtTituloEmail
            // 
            this.txtTituloEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTituloEmail.Depth = 0;
            this.txtTituloEmail.Hint = "";
            this.txtTituloEmail.Location = new System.Drawing.Point(3, 22);
            this.txtTituloEmail.MaxLength = 32767;
            this.txtTituloEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtTituloEmail.Name = "txtTituloEmail";
            this.txtTituloEmail.PasswordChar = '\0';
            this.txtTituloEmail.SelectedText = "";
            this.txtTituloEmail.SelectionLength = 0;
            this.txtTituloEmail.SelectionStart = 0;
            this.txtTituloEmail.Size = new System.Drawing.Size(758, 23);
            this.txtTituloEmail.TabIndex = 6;
            this.txtTituloEmail.TabStop = false;
            this.txtTituloEmail.UseSystemPasswordChar = false;
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Depth = 0;
            this.lblMensagem.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblMensagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMensagem.Location = new System.Drawing.Point(3, 48);
            this.lblMensagem.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(83, 19);
            this.lblMensagem.TabIndex = 7;
            this.lblMensagem.Text = "Mensagem";
            // 
            // btnEnviarEmail
            // 
            this.btnEnviarEmail.AutoSize = true;
            this.btnEnviarEmail.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEnviarEmail.Depth = 0;
            this.btnEnviarEmail.Icon = null;
            this.btnEnviarEmail.Location = new System.Drawing.Point(689, 1);
            this.btnEnviarEmail.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEnviarEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarEmail.Name = "btnEnviarEmail";
            this.btnEnviarEmail.Primary = true;
            this.btnEnviarEmail.Size = new System.Drawing.Size(69, 36);
            this.btnEnviarEmail.TabIndex = 0;
            this.btnEnviarEmail.Text = "Enviar";
            this.btnEnviarEmail.UseVisualStyleBackColor = true;
            this.btnEnviarEmail.Click += new System.EventHandler(this.botaoOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(590, 1);
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
            // EnviarCorrespondencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(788, 386);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(788, 386);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(788, 386);
            this.Name = "EnviarCorrespondencia";
            this.Sizable = false;
            this.Text = "Aviso de Correspondência";
            this.pnlConteudo.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtMensagem;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialLabel lblTituloEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtTituloEmail;
        private MaterialSkin.Controls.MaterialLabel lblMensagem;
        private MaterialSkin.Controls.MaterialFlatButton btnEnviarEmail;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
    }
}
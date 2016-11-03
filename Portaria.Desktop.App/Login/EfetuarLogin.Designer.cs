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
            this.lblBemVindo = new MaterialSkin.Controls.MaterialLabel();
            this.pnlBotoes = new System.Windows.Forms.Panel();
            this.btnLogar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.tlpConteudo = new System.Windows.Forms.TableLayoutPanel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtSenha = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.pnlConteudo.SuspendLayout();
            this.pnlBotoes.SuspendLayout();
            this.tlpConteudo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlConteudo.Controls.Add(this.tlpConteudo);
            this.pnlConteudo.Location = new System.Drawing.Point(-2, 68);
            this.pnlConteudo.Size = new System.Drawing.Size(553, 273);
            // 
            // lblBemVindo
            // 
            this.tlpConteudo.SetColumnSpan(this.lblBemVindo, 2);
            this.lblBemVindo.Depth = 0;
            this.lblBemVindo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBemVindo.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBemVindo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBemVindo.Location = new System.Drawing.Point(3, 0);
            this.lblBemVindo.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(547, 89);
            this.lblBemVindo.TabIndex = 0;
            this.lblBemVindo.Text = "Bem vindo ao Portaria Digial!";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlBotoes
            // 
            this.tlpConteudo.SetColumnSpan(this.pnlBotoes, 2);
            this.pnlBotoes.Controls.Add(this.materialDivider1);
            this.pnlBotoes.Controls.Add(this.btnCancelar);
            this.pnlBotoes.Controls.Add(this.btnLogar);
            this.pnlBotoes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotoes.Location = new System.Drawing.Point(3, 188);
            this.pnlBotoes.Name = "pnlBotoes";
            this.pnlBotoes.Size = new System.Drawing.Size(547, 82);
            this.pnlBotoes.TabIndex = 5;
            // 
            // btnLogar
            // 
            this.btnLogar.AutoSize = true;
            this.btnLogar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLogar.Depth = 0;
            this.btnLogar.Icon = null;
            this.btnLogar.Location = new System.Drawing.Point(470, 43);
            this.btnLogar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLogar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogar.Name = "btnLogar";
            this.btnLogar.Primary = true;
            this.btnLogar.Size = new System.Drawing.Size(73, 36);
            this.btnLogar.TabIndex = 0;
            this.btnLogar.Text = "Entrar";
            this.btnLogar.UseVisualStyleBackColor = true;
            this.btnLogar.Click += new System.EventHandler(this.botaoOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(371, 43);
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
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(0, 33);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(551, 1);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider";
            // 
            // tlpConteudo
            // 
            this.tlpConteudo.BackColor = System.Drawing.Color.White;
            this.tlpConteudo.ColumnCount = 2;
            this.tlpConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpConteudo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 379F));
            this.tlpConteudo.Controls.Add(this.pnlBotoes, 0, 5);
            this.tlpConteudo.Controls.Add(this.lblBemVindo, 0, 0);
            this.tlpConteudo.Controls.Add(this.txtUsuario, 1, 2);
            this.tlpConteudo.Controls.Add(this.txtSenha, 1, 4);
            this.tlpConteudo.Controls.Add(this.materialLabel1, 1, 1);
            this.tlpConteudo.Controls.Add(this.materialLabel2, 1, 3);
            this.tlpConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpConteudo.Location = new System.Drawing.Point(0, 0);
            this.tlpConteudo.Name = "tlpConteudo";
            this.tlpConteudo.RowCount = 6;
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.34177F));
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tlpConteudo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpConteudo.Size = new System.Drawing.Size(553, 273);
            this.tlpConteudo.TabIndex = 0;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(177, 137);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(50, 19);
            this.materialLabel2.TabIndex = 7;
            this.materialLabel2.Text = "Senha";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(177, 89);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(61, 19);
            this.materialLabel1.TabIndex = 6;
            this.materialLabel1.Text = "Usuário";
            // 
            // txtSenha
            // 
            this.txtSenha.Depth = 0;
            this.txtSenha.Hint = "";
            this.txtSenha.Location = new System.Drawing.Point(177, 159);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.SelectedText = "";
            this.txtSenha.SelectionLength = 0;
            this.txtSenha.SelectionStart = 0;
            this.txtSenha.Size = new System.Drawing.Size(198, 23);
            this.txtSenha.TabIndex = 2;
            this.txtSenha.TabStop = false;
            this.txtSenha.UseSystemPasswordChar = false;
            this.txtSenha.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSenha_KeyPress);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Depth = 0;
            this.txtUsuario.Hint = "";
            this.txtUsuario.Location = new System.Drawing.Point(177, 111);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.SelectionLength = 0;
            this.txtUsuario.SelectionStart = 0;
            this.txtUsuario.Size = new System.Drawing.Size(198, 23);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.TabStop = false;
            this.txtUsuario.UseSystemPasswordChar = false;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // EfetuarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(551, 343);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(551, 343);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(551, 343);
            this.Name = "EfetuarLogin";
            this.Sizable = false;
            this.Text = "Efetuar Login";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlBotoes.ResumeLayout(false);
            this.pnlBotoes.PerformLayout();
            this.tlpConteudo.ResumeLayout(false);
            this.tlpConteudo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpConteudo;
        private System.Windows.Forms.Panel pnlBotoes;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton btnLogar;
        private MaterialSkin.Controls.MaterialLabel lblBemVindo;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuario;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenha;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
    }
}
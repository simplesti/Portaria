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
            this.cboTipoServidor = new System.Windows.Forms.ComboBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtEnderecoServidor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtUsuarioServidor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtSenhaServidor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnTestar = new MaterialSkin.Controls.MaterialFlatButton();
            this.cboBaseDados = new System.Windows.Forms.ComboBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.botaoAdd = new Portaria.Desktop.Framework.Botoes.BotaoAdd();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // cboTipoServidor
            // 
            this.cboTipoServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoServidor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboTipoServidor.FormattingEnabled = true;
            this.cboTipoServidor.Location = new System.Drawing.Point(12, 94);
            this.cboTipoServidor.Name = "cboTipoServidor";
            this.cboTipoServidor.Size = new System.Drawing.Size(283, 26);
            this.cboTipoServidor.TabIndex = 20;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(8, 72);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(118, 19);
            this.materialLabel1.TabIndex = 25;
            this.materialLabel1.Text = "Tipo de Servidor";
            // 
            // txtEnderecoServidor
            // 
            this.txtEnderecoServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnderecoServidor.Depth = 0;
            this.txtEnderecoServidor.Hint = "";
            this.txtEnderecoServidor.Location = new System.Drawing.Point(16, 158);
            this.txtEnderecoServidor.MaxLength = 32767;
            this.txtEnderecoServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEnderecoServidor.Name = "txtEnderecoServidor";
            this.txtEnderecoServidor.PasswordChar = '\0';
            this.txtEnderecoServidor.SelectedText = "";
            this.txtEnderecoServidor.SelectionLength = 0;
            this.txtEnderecoServidor.SelectionStart = 0;
            this.txtEnderecoServidor.Size = new System.Drawing.Size(279, 23);
            this.txtEnderecoServidor.TabIndex = 26;
            this.txtEnderecoServidor.TabStop = false;
            this.txtEnderecoServidor.UseSystemPasswordChar = false;
            // 
            // txtUsuarioServidor
            // 
            this.txtUsuarioServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsuarioServidor.Depth = 0;
            this.txtUsuarioServidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtUsuarioServidor.Hint = "";
            this.txtUsuarioServidor.Location = new System.Drawing.Point(16, 206);
            this.txtUsuarioServidor.MaxLength = 32767;
            this.txtUsuarioServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtUsuarioServidor.Name = "txtUsuarioServidor";
            this.txtUsuarioServidor.PasswordChar = '\0';
            this.txtUsuarioServidor.SelectedText = "";
            this.txtUsuarioServidor.SelectionLength = 0;
            this.txtUsuarioServidor.SelectionStart = 0;
            this.txtUsuarioServidor.Size = new System.Drawing.Size(279, 23);
            this.txtUsuarioServidor.TabIndex = 27;
            this.txtUsuarioServidor.TabStop = false;
            this.txtUsuarioServidor.UseSystemPasswordChar = false;
            // 
            // txtSenhaServidor
            // 
            this.txtSenhaServidor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSenhaServidor.Depth = 0;
            this.txtSenhaServidor.Hint = "";
            this.txtSenhaServidor.Location = new System.Drawing.Point(301, 158);
            this.txtSenhaServidor.MaxLength = 32767;
            this.txtSenhaServidor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtSenhaServidor.Name = "txtSenhaServidor";
            this.txtSenhaServidor.PasswordChar = '\0';
            this.txtSenhaServidor.SelectedText = "";
            this.txtSenhaServidor.SelectionLength = 0;
            this.txtSenhaServidor.SelectionStart = 0;
            this.txtSenhaServidor.Size = new System.Drawing.Size(290, 23);
            this.txtSenhaServidor.TabIndex = 28;
            this.txtSenhaServidor.TabStop = false;
            this.txtSenhaServidor.UseSystemPasswordChar = false;
            // 
            // btnTestar
            // 
            this.btnTestar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTestar.AutoSize = true;
            this.btnTestar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnTestar.Depth = 0;
            this.btnTestar.Icon = null;
            this.btnTestar.Location = new System.Drawing.Point(274, 281);
            this.btnTestar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnTestar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnTestar.Name = "btnTestar";
            this.btnTestar.Primary = false;
            this.btnTestar.Size = new System.Drawing.Size(138, 36);
            this.btnTestar.TabIndex = 29;
            this.btnTestar.Text = "Testar Conexão";
            this.btnTestar.UseVisualStyleBackColor = true;
            this.btnTestar.Click += new System.EventHandler(this.botaoTestarConexao_Click);
            // 
            // cboBaseDados
            // 
            this.cboBaseDados.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cboBaseDados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBaseDados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cboBaseDados.FormattingEnabled = true;
            this.cboBaseDados.Location = new System.Drawing.Point(301, 94);
            this.cboBaseDados.Name = "cboBaseDados";
            this.cboBaseDados.Size = new System.Drawing.Size(262, 26);
            this.cboBaseDados.TabIndex = 21;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(297, 72);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(109, 19);
            this.materialLabel2.TabIndex = 23;
            this.materialLabel2.Text = "Base de Dados";
            // 
            // botaoAdd
            // 
            this.botaoAdd.BackColor = System.Drawing.Color.Transparent;
            this.botaoAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoAdd.BackgroundImage")));
            this.botaoAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoAdd.Location = new System.Drawing.Point(567, 94);
            this.botaoAdd.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoAdd.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoAdd.Name = "botaoAdd";
            this.botaoAdd.Size = new System.Drawing.Size(24, 24);
            this.botaoAdd.TabIndex = 24;
            this.botaoAdd.Click += new System.EventHandler(this.botaoAdicionarBase_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(420, 281);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 22;
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
            this.btnSalvar.Location = new System.Drawing.Point(519, 281);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(12, 136);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(151, 19);
            this.materialLabel3.TabIndex = 30;
            this.materialLabel3.Text = "Endereço do servidor";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(12, 184);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(61, 19);
            this.materialLabel4.TabIndex = 31;
            this.materialLabel4.Text = "Usuário";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(297, 136);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(50, 19);
            this.materialLabel5.TabIndex = 32;
            this.materialLabel5.Text = "Senha";
            // 
            // ConfiguradorBancoDados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(603, 332);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.cboTipoServidor);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtEnderecoServidor);
            this.Controls.Add(this.txtUsuarioServidor);
            this.Controls.Add(this.txtSenhaServidor);
            this.Controls.Add(this.btnTestar);
            this.Controls.Add(this.cboBaseDados);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.botaoAdd);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(603, 332);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(603, 332);
            this.Name = "ConfiguradorBancoDados";
            this.Sizable = false;
            this.Text = "Portaria Digital - Configurador do banco de dados";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoServidor;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtEnderecoServidor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtUsuarioServidor;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtSenhaServidor;
        private MaterialSkin.Controls.MaterialFlatButton btnTestar;
        private System.Windows.Forms.ComboBox cboBaseDados;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Desktop.Framework.Botoes.BotaoAdd botaoAdd;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
    }
}


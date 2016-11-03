namespace Portaria.Cadastro
{
    partial class CadVeiculo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadVeiculo));
            this.bsVeiculo = new System.Windows.Forms.BindingSource(this.components);
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNome = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCor = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPlaca = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.txtProprietario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnSalvar = new MaterialSkin.Controls.MaterialFlatButton();
            this.botaoPessoa1 = new Portaria.Desktop.Framework.Botoes.BotaoPessoa();
            this.pnlConteudo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlConteudo.BackColor = System.Drawing.Color.White;
            this.pnlConteudo.Controls.Add(this.botaoPessoa1);
            this.pnlConteudo.Controls.Add(this.btnSalvar);
            this.pnlConteudo.Controls.Add(this.btnCancelar);
            this.pnlConteudo.Controls.Add(this.txtProprietario);
            this.pnlConteudo.Controls.Add(this.materialLabel4);
            this.pnlConteudo.Controls.Add(this.txtPlaca);
            this.pnlConteudo.Controls.Add(this.materialLabel3);
            this.pnlConteudo.Controls.Add(this.txtCor);
            this.pnlConteudo.Controls.Add(this.materialLabel2);
            this.pnlConteudo.Controls.Add(this.txtNome);
            this.pnlConteudo.Controls.Add(this.materialLabel1);
            this.pnlConteudo.Controls.Add(this.pbFoto);
            this.pnlConteudo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlConteudo.Size = new System.Drawing.Size(403, 443);
            // 
            // bsVeiculo
            // 
            this.bsVeiculo.DataSource = typeof(Portaria.Core.Model.CadastroMorador.Veiculo);
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFoto.Location = new System.Drawing.Point(3, 3);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(244, 161);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFoto.TabIndex = 36;
            this.pbFoto.TabStop = false;
            this.pbFoto.Click += new System.EventHandler(this.pbFoto_Click);
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(3, 167);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(142, 19);
            this.materialLabel1.TabIndex = 40;
            this.materialLabel1.Text = "Modelo - Fabricante";
            // 
            // txtNome
            // 
            this.txtNome.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVeiculo, "Nome", true));
            this.txtNome.Depth = 0;
            this.txtNome.Hint = "";
            this.txtNome.Location = new System.Drawing.Point(7, 189);
            this.txtNome.MaxLength = 32767;
            this.txtNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.Size = new System.Drawing.Size(352, 23);
            this.txtNome.TabIndex = 41;
            this.txtNome.TabStop = false;
            this.txtNome.UseSystemPasswordChar = false;
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(3, 215);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(33, 19);
            this.materialLabel2.TabIndex = 42;
            this.materialLabel2.Text = "Cor";
            // 
            // txtCor
            // 
            this.txtCor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVeiculo, "Cor", true));
            this.txtCor.Depth = 0;
            this.txtCor.Hint = "";
            this.txtCor.Location = new System.Drawing.Point(7, 237);
            this.txtCor.MaxLength = 32767;
            this.txtCor.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCor.Name = "txtCor";
            this.txtCor.PasswordChar = '\0';
            this.txtCor.SelectedText = "";
            this.txtCor.SelectionLength = 0;
            this.txtCor.SelectionStart = 0;
            this.txtCor.Size = new System.Drawing.Size(352, 23);
            this.txtCor.TabIndex = 43;
            this.txtCor.TabStop = false;
            this.txtCor.UseSystemPasswordChar = false;
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(3, 263);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(46, 19);
            this.materialLabel3.TabIndex = 44;
            this.materialLabel3.Text = "Placa";
            // 
            // txtPlaca
            // 
            this.txtPlaca.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVeiculo, "Placa", true));
            this.txtPlaca.Depth = 0;
            this.txtPlaca.Hint = "";
            this.txtPlaca.Location = new System.Drawing.Point(7, 285);
            this.txtPlaca.MaxLength = 32767;
            this.txtPlaca.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtPlaca.Name = "txtPlaca";
            this.txtPlaca.PasswordChar = '\0';
            this.txtPlaca.SelectedText = "";
            this.txtPlaca.SelectionLength = 0;
            this.txtPlaca.SelectionStart = 0;
            this.txtPlaca.Size = new System.Drawing.Size(352, 23);
            this.txtPlaca.TabIndex = 45;
            this.txtPlaca.TabStop = false;
            this.txtPlaca.UseSystemPasswordChar = false;
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(3, 311);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(88, 19);
            this.materialLabel4.TabIndex = 46;
            this.materialLabel4.Text = "Proprietário";
            // 
            // txtProprietario
            // 
            this.txtProprietario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsVeiculo, "Proprietario", true));
            this.txtProprietario.Depth = 0;
            this.txtProprietario.Enabled = false;
            this.txtProprietario.Hint = "";
            this.txtProprietario.Location = new System.Drawing.Point(7, 333);
            this.txtProprietario.MaxLength = 32767;
            this.txtProprietario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProprietario.Name = "txtProprietario";
            this.txtProprietario.PasswordChar = '\0';
            this.txtProprietario.SelectedText = "";
            this.txtProprietario.SelectionLength = 0;
            this.txtProprietario.SelectionStart = 0;
            this.txtProprietario.Size = new System.Drawing.Size(352, 23);
            this.txtProprietario.TabIndex = 47;
            this.txtProprietario.TabStop = false;
            this.txtProprietario.UseSystemPasswordChar = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(228, 401);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 48;
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
            this.btnSalvar.Location = new System.Drawing.Point(327, 401);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnSalvar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Primary = true;
            this.btnSalvar.Size = new System.Drawing.Size(72, 36);
            this.btnSalvar.TabIndex = 49;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoPessoa1
            // 
            this.botaoPessoa1.BackColor = System.Drawing.Color.Transparent;
            this.botaoPessoa1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("botaoPessoa1.BackgroundImage")));
            this.botaoPessoa1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoPessoa1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPessoa1.Location = new System.Drawing.Point(365, 332);
            this.botaoPessoa1.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoPessoa1.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoPessoa1.Name = "botaoPessoa1";
            this.botaoPessoa1.Size = new System.Drawing.Size(24, 24);
            this.botaoPessoa1.TabIndex = 50;
            this.botaoPessoa1.Click += new System.EventHandler(this.btnEditarProprietario_Click);
            // 
            // CadVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(403, 510);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(403, 489);
            this.Name = "CadVeiculo";
            this.Sizable = false;
            this.Text = "Cadastro de Veículo";
            this.pnlConteudo.ResumeLayout(false);
            this.pnlConteudo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsVeiculo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bsVeiculo;
        private System.Windows.Forms.PictureBox pbFoto;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtCor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtPlaca;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialFlatButton btnSalvar;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtProprietario;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private Desktop.Framework.Botoes.BotaoPessoa botaoPessoa1;
    }
}
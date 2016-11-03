namespace Portaria.Biometria
{
    partial class PortariaBiometriaVerificar
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
            this.Picture = new System.Windows.Forms.PictureBox();
            this.StatusText = new System.Windows.Forms.TextBox();
            this.lblVerificarBiometria = new MaterialSkin.Controls.MaterialLabel();
            this.Prompt = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.btnOK = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCancelar = new MaterialSkin.Controls.MaterialFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Picture
            // 
            this.Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Picture.BackColor = System.Drawing.SystemColors.Window;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Picture.Location = new System.Drawing.Point(11, 131);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(244, 221);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 12;
            this.Picture.TabStop = false;
            // 
            // StatusText
            // 
            this.StatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusText.BackColor = System.Drawing.SystemColors.Window;
            this.StatusText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.StatusText.Location = new System.Drawing.Point(265, 200);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(311, 152);
            this.StatusText.TabIndex = 16;
            // 
            // lblVerificarBiometria
            // 
            this.lblVerificarBiometria.Depth = 0;
            this.lblVerificarBiometria.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblVerificarBiometria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblVerificarBiometria.Location = new System.Drawing.Point(11, 77);
            this.lblVerificarBiometria.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblVerificarBiometria.Name = "lblVerificarBiometria";
            this.lblVerificarBiometria.Size = new System.Drawing.Size(565, 26);
            this.lblVerificarBiometria.TabIndex = 20;
            this.lblVerificarBiometria.Text = "Verificar biometría de <pessoa>";
            this.lblVerificarBiometria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Prompt
            // 
            this.Prompt.Depth = 0;
            this.Prompt.Enabled = false;
            this.Prompt.Hint = "";
            this.Prompt.Location = new System.Drawing.Point(265, 152);
            this.Prompt.MaxLength = 32767;
            this.Prompt.MouseState = MaterialSkin.MouseState.HOVER;
            this.Prompt.Name = "Prompt";
            this.Prompt.PasswordChar = '\0';
            this.Prompt.SelectedText = "";
            this.Prompt.SelectionLength = 0;
            this.Prompt.SelectionStart = 0;
            this.Prompt.Size = new System.Drawing.Size(262, 23);
            this.Prompt.TabIndex = 23;
            this.Prompt.TabStop = false;
            this.Prompt.UseSystemPasswordChar = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(261, 131);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(80, 19);
            this.materialLabel1.TabIndex = 22;
            this.materialLabel1.Text = "Instruções";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(261, 178);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(116, 19);
            this.materialLabel2.TabIndex = 24;
            this.materialLabel2.Text = "Estado do leitor";
            // 
            // btnOK
            // 
            this.btnOK.AutoSize = true;
            this.btnOK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnOK.Depth = 0;
            this.btnOK.Icon = null;
            this.btnOK.Location = new System.Drawing.Point(537, 361);
            this.btnOK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnOK.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnOK.Name = "btnOK";
            this.btnOK.Primary = true;
            this.btnOK.Size = new System.Drawing.Size(39, 36);
            this.btnOK.TabIndex = 25;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.botaoOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.AutoSize = true;
            this.btnCancelar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancelar.Depth = 0;
            this.btnCancelar.Icon = null;
            this.btnCancelar.Location = new System.Drawing.Point(438, 361);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCancelar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Primary = false;
            this.btnCancelar.Size = new System.Drawing.Size(91, 36);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // PortariaBiometriaVerificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 406);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.lblVerificarBiometria);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(this.Picture);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(589, 406);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(589, 406);
            this.Name = "PortariaBiometriaVerificar";
            this.Sizable = false;
            this.Load += new System.EventHandler(this.PortariaBiometriaVerificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Picture;
        private System.Windows.Forms.TextBox StatusText;
        private MaterialSkin.Controls.MaterialLabel lblVerificarBiometria;
        private MaterialSkin.Controls.MaterialSingleLineTextField Prompt;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialFlatButton btnOK;
        private MaterialSkin.Controls.MaterialFlatButton btnCancelar;
    }
}
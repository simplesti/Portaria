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
            System.Windows.Forms.Label PromptLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortariaBiometriaVerificar));
            System.Windows.Forms.Label StatusLabel;
            this.lblVerificarBiometria = new System.Windows.Forms.Label();
            this.Prompt = new System.Windows.Forms.TextBox();
            this.Picture = new System.Windows.Forms.PictureBox();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.botaoOK = new Portaria.Desktop.Framework.Botoes.BotaoOK();
            this.StatusText = new System.Windows.Forms.TextBox();
            PromptLabel = new System.Windows.Forms.Label();
            StatusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // PromptLabel
            // 
            PromptLabel.AutoSize = true;
            PromptLabel.Location = new System.Drawing.Point(279, 42);
            PromptLabel.Name = "PromptLabel";
            PromptLabel.Size = new System.Drawing.Size(51, 13);
            PromptLabel.TabIndex = 13;
            PromptLabel.Text = "Instrução";
            // 
            // lblVerificarBiometria
            // 
            this.lblVerificarBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificarBiometria.Location = new System.Drawing.Point(8, 9);
            this.lblVerificarBiometria.Name = "lblVerificarBiometria";
            this.lblVerificarBiometria.Size = new System.Drawing.Size(569, 23);
            this.lblVerificarBiometria.TabIndex = 0;
            this.lblVerificarBiometria.Text = "Verificar biometría de <pessoa>";
            this.lblVerificarBiometria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Prompt
            // 
            this.Prompt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Prompt.Location = new System.Drawing.Point(282, 58);
            this.Prompt.Name = "Prompt";
            this.Prompt.ReadOnly = true;
            this.Prompt.Size = new System.Drawing.Size(296, 20);
            this.Prompt.TabIndex = 14;
            // 
            // Picture
            // 
            this.Picture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Picture.BackColor = System.Drawing.SystemColors.Window;
            this.Picture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Picture.Location = new System.Drawing.Point(13, 42);
            this.Picture.Name = "Picture";
            this.Picture.Size = new System.Drawing.Size(248, 288);
            this.Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Picture.TabIndex = 12;
            this.Picture.TabStop = false;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(477, 368);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 35);
            this.botaoCancelar.TabIndex = 18;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // botaoOK
            // 
            this.botaoOK.BackColor = System.Drawing.Color.White;
            this.botaoOK.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoOK.Enabled = false;
            this.botaoOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoOK.Image = ((System.Drawing.Image)(resources.GetObject("botaoOK.Image")));
            this.botaoOK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoOK.Location = new System.Drawing.Point(371, 368);
            this.botaoOK.Name = "botaoOK";
            this.botaoOK.Size = new System.Drawing.Size(100, 35);
            this.botaoOK.TabIndex = 19;
            this.botaoOK.Text = "OK";
            this.botaoOK.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoOK.UseVisualStyleBackColor = false;
            this.botaoOK.Click += new System.EventHandler(this.botaoOK_Click);
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new System.Drawing.Point(279, 95);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new System.Drawing.Size(37, 13);
            StatusLabel.TabIndex = 15;
            StatusLabel.Text = "Status";
            // 
            // StatusText
            // 
            this.StatusText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusText.BackColor = System.Drawing.SystemColors.Window;
            this.StatusText.Location = new System.Drawing.Point(282, 111);
            this.StatusText.Multiline = true;
            this.StatusText.Name = "StatusText";
            this.StatusText.ReadOnly = true;
            this.StatusText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusText.Size = new System.Drawing.Size(296, 219);
            this.StatusText.TabIndex = 16;
            // 
            // PortariaBiometriaVerificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 415);
            this.Controls.Add(this.botaoOK);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.StatusText);
            this.Controls.Add(StatusLabel);
            this.Controls.Add(this.Prompt);
            this.Controls.Add(PromptLabel);
            this.Controls.Add(this.Picture);
            this.Controls.Add(this.lblVerificarBiometria);
            this.MinimumSize = new System.Drawing.Size(284, 261);
            this.Name = "PortariaBiometriaVerificar";
            this.Text = "PortariaBiometria";
            this.Load += new System.EventHandler(this.PortariaBiometriaVerificar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerificarBiometria;
        private System.Windows.Forms.TextBox Prompt;
        private System.Windows.Forms.PictureBox Picture;
        private Portaria.Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private Portaria.Desktop.Framework.Botoes.BotaoOK botaoOK;
        private System.Windows.Forms.TextBox StatusText;
    }
}
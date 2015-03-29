namespace Portaria.Biometria
{
    partial class PortariaBiometria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortariaBiometria));
            this.lblVerificarBiometria = new System.Windows.Forms.Label();
            this.pbBio = new System.Windows.Forms.PictureBox();
            this.botaoCancelar = new Portaria.Framework.Botoes.BotaoCancelar();
            this.lblVerificado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVerificarBiometria
            // 
            this.lblVerificarBiometria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificarBiometria.Location = new System.Drawing.Point(12, 9);
            this.lblVerificarBiometria.Name = "lblVerificarBiometria";
            this.lblVerificarBiometria.Size = new System.Drawing.Size(260, 50);
            this.lblVerificarBiometria.TabIndex = 0;
            this.lblVerificarBiometria.Text = "Verificar biometría de <pessoa>";
            this.lblVerificarBiometria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbBio
            // 
            this.pbBio.Image = global::Portaria.Biometria.Properties.Resources.icon_biometria;
            this.pbBio.Location = new System.Drawing.Point(93, 62);
            this.pbBio.Name = "pbBio";
            this.pbBio.Size = new System.Drawing.Size(99, 101);
            this.pbBio.TabIndex = 1;
            this.pbBio.TabStop = false;
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(172, 214);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 35);
            this.botaoCancelar.TabIndex = 2;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // lblVerificado
            // 
            this.lblVerificado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificado.ForeColor = System.Drawing.Color.Green;
            this.lblVerificado.Location = new System.Drawing.Point(16, 166);
            this.lblVerificado.Name = "lblVerificado";
            this.lblVerificado.Size = new System.Drawing.Size(256, 45);
            this.lblVerificado.TabIndex = 3;
            this.lblVerificado.Text = "Verificado!";
            this.lblVerificado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PortariaBiometria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblVerificado);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.pbBio);
            this.Controls.Add(this.lblVerificarBiometria);
            this.MaximumSize = new System.Drawing.Size(284, 261);
            this.MinimumSize = new System.Drawing.Size(284, 261);
            this.Name = "PortariaBiometria";
            this.Text = "PortariaBiometria";
            ((System.ComponentModel.ISupportInitialize)(this.pbBio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblVerificarBiometria;
        private System.Windows.Forms.PictureBox pbBio;
        private Framework.Botoes.BotaoCancelar botaoCancelar;
        private System.Windows.Forms.Label lblVerificado;
    }
}
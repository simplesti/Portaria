namespace Portaria.ControleAcessoBiometrico
{
    partial class ConfigurarTimerCache
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
            this.lblTempoCache = new System.Windows.Forms.Label();
            this.mtbTempoCache = new System.Windows.Forms.MaskedTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTempoCache
            // 
            this.lblTempoCache.AutoSize = true;
            this.lblTempoCache.Location = new System.Drawing.Point(13, 16);
            this.lblTempoCache.Name = "lblTempoCache";
            this.lblTempoCache.Size = new System.Drawing.Size(220, 13);
            this.lblTempoCache.TabIndex = 0;
            this.lblTempoCache.Text = "Tempo de atualização do cache de pessoas:";
            // 
            // mtbTempoCache
            // 
            this.mtbTempoCache.Location = new System.Drawing.Point(239, 13);
            this.mtbTempoCache.Mask = "00000";
            this.mtbTempoCache.Name = "mtbTempoCache";
            this.mtbTempoCache.Size = new System.Drawing.Size(100, 20);
            this.mtbTempoCache.TabIndex = 1;
            this.mtbTempoCache.ValidatingType = typeof(int);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(247, 39);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(144, 43);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(97, 39);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(144, 43);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Location = new System.Drawing.Point(345, 16);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(46, 13);
            this.lblMinutos.TabIndex = 4;
            this.lblMinutos.Text = "minutos.";
            // 
            // ConfigurarTimerCache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 94);
            this.ControlBox = false;
            this.Controls.Add(this.lblMinutos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.mtbTempoCache);
            this.Controls.Add(this.lblTempoCache);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(406, 94);
            this.MinimumSize = new System.Drawing.Size(406, 94);
            this.Name = "ConfigurarTimerCache";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configurar Timer Cache";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTempoCache;
        private System.Windows.Forms.MaskedTextBox mtbTempoCache;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblMinutos;
    }
}
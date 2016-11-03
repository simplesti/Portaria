namespace Portaria.Desktop.Framework.Forms
{
    partial class MaterialPortariaFormWindow
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
            this.pnlConteudo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlConteudo.BackColor = System.Drawing.Color.Transparent;
            this.pnlConteudo.Location = new System.Drawing.Point(0, 67);
            this.pnlConteudo.Name = "pnlConteudo";
            this.pnlConteudo.Size = new System.Drawing.Size(838, 430);
            this.pnlConteudo.TabIndex = 15;
            // 
            // MaterialPortariaFormWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 496);
            this.Controls.Add(this.pnlConteudo);
            this.Name = "MaterialPortariaFormWindow";
            this.Text = "MaterialPortariaFormWindow";
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Panel pnlConteudo;
    }
}
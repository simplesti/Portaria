namespace Portaria.Desktop.Framework.Locais
{
    partial class LocalItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNome.Depth = 0;
            this.lblNome.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(1, 1);
            this.lblNome.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(198, 98);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "?";
            this.lblNome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            this.lblNome.MouseEnter += new System.EventHandler(this.lblNome_MouseEnter);
            this.lblNome.MouseLeave += new System.EventHandler(this.lblNome_MouseLeave);
            // 
            // LocalItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNome);
            this.Name = "LocalItem";
            this.Size = new System.Drawing.Size(200, 100);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblNome;
    }
}

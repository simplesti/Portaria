namespace Portaria.Desktop.Framework.Inicio
{
    partial class BolhaInicio
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
            this.pic = new System.Windows.Forms.PictureBox();
            this.lblTexto = new MaterialSkin.Controls.MaterialLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // pic
            // 
            this.pic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic.BackColor = System.Drawing.Color.Transparent;
            this.pic.Location = new System.Drawing.Point(36, 18);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(48, 48);
            this.pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Click += new System.EventHandler(this.pic_Click);
            this.pic.MouseEnter += new System.EventHandler(this.lblTexto_MouseEnter);
            this.pic.MouseLeave += new System.EventHandler(this.lblTexto_MouseLeave);
            // 
            // lblTexto
            // 
            this.lblTexto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTexto.BackColor = System.Drawing.Color.Transparent;
            this.lblTexto.Depth = 0;
            this.lblTexto.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblTexto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTexto.Location = new System.Drawing.Point(3, 69);
            this.lblTexto.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(114, 44);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Texto";
            this.lblTexto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTexto.Click += new System.EventHandler(this.lblTexto_Click);
            this.lblTexto.MouseEnter += new System.EventHandler(this.lblTexto_MouseEnter);
            this.lblTexto.MouseLeave += new System.EventHandler(this.lblTexto_MouseLeave);
            // 
            // BolhaInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pic);
            this.Controls.Add(this.lblTexto);
            this.Name = "BolhaInicio";
            this.Size = new System.Drawing.Size(120, 120);
            this.MouseEnter += new System.EventHandler(this.lblTexto_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lblTexto_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel lblTexto;
        private System.Windows.Forms.PictureBox pic;
    }
}

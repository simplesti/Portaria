namespace Portaria
{
    partial class TabVisualizarUnidades
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
            this.flpUnidades = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flpUnidades
            // 
            this.flpUnidades.Dock = System.Windows.Forms.DockStyle.Top;
            this.flpUnidades.Location = new System.Drawing.Point(0, 0);
            this.flpUnidades.Name = "flpUnidades";
            this.flpUnidades.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flpUnidades.Size = new System.Drawing.Size(634, 351);
            this.flpUnidades.TabIndex = 1;
            // 
            // TabVisualizarUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.flpUnidades);
            this.Name = "TabVisualizarUnidades";
            this.Size = new System.Drawing.Size(634, 417);
            this.Load += new System.EventHandler(this.TabVisualizarUnidades_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpUnidades;
    }
}

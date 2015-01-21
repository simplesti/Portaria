namespace Portaria
{
    partial class Principal
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
            this.tpUnidades = new System.Windows.Forms.TabPage();
            this.tabVisualizarUnidades = new Portaria.TabVisualizarUnidades();
            this.tpBlocos = new System.Windows.Forms.TabPage();
            this.tabVisualizarBlocos1 = new Portaria.TabVisualizarBlocos();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpUnidades.SuspendLayout();
            this.tpBlocos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpUnidades);
            this.tabControl.Controls.Add(this.tpBlocos);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Size = new System.Drawing.Size(659, 417);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(659, 417);
            // 
            // tpUnidades
            // 
            this.tpUnidades.Controls.Add(this.tabVisualizarUnidades);
            this.tpUnidades.Location = new System.Drawing.Point(4, 22);
            this.tpUnidades.Name = "tpUnidades";
            this.tpUnidades.Padding = new System.Windows.Forms.Padding(3);
            this.tpUnidades.Size = new System.Drawing.Size(651, 391);
            this.tpUnidades.TabIndex = 0;
            this.tpUnidades.Text = "Unidades";
            this.tpUnidades.UseVisualStyleBackColor = true;
            // 
            // tabVisualizarUnidades
            // 
            this.tabVisualizarUnidades.BackColor = System.Drawing.Color.White;
            this.tabVisualizarUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarUnidades.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarUnidades.Name = "tabVisualizarUnidades";
            this.tabVisualizarUnidades.Size = new System.Drawing.Size(645, 385);
            this.tabVisualizarUnidades.TabIndex = 0;
            // 
            // tpBlocos
            // 
            this.tpBlocos.Controls.Add(this.tabVisualizarBlocos1);
            this.tpBlocos.Location = new System.Drawing.Point(4, 22);
            this.tpBlocos.Name = "tpBlocos";
            this.tpBlocos.Padding = new System.Windows.Forms.Padding(3);
            this.tpBlocos.Size = new System.Drawing.Size(651, 391);
            this.tpBlocos.TabIndex = 1;
            this.tpBlocos.Text = "Blocos";
            this.tpBlocos.UseVisualStyleBackColor = true;
            // 
            // tabVisualizarBlocos1
            // 
            this.tabVisualizarBlocos1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarBlocos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarBlocos1.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarBlocos1.Name = "tabVisualizarBlocos1";
            this.tabVisualizarBlocos1.Size = new System.Drawing.Size(645, 385);
            this.tabVisualizarBlocos1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 391);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reserva de Locais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 391);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 480);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Titulo = "Portaria Digital";
            this.tabControl.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tpUnidades.ResumeLayout(false);
            this.tpBlocos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpUnidades;
        private TabVisualizarUnidades tabVisualizarUnidades;
        private System.Windows.Forms.TabPage tpBlocos;
        private TabVisualizarBlocos tabVisualizarBlocos1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}


namespace Portaria.Framework.Unidades
{
    partial class UnidadeItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnidadeItem));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblNumero = new System.Windows.Forms.Label();
            this.botaoEditar1 = new Portaria.Framework.Botoes.BotaoEditar();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.14286F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblNumero, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.botaoEditar1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(3, 20);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(25, 29);
            this.lblNumero.TabIndex = 0;
            this.lblNumero.Text = "?";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // botaoEditar1
            // 
            this.botaoEditar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.botaoEditar1.AutoSize = true;
            this.botaoEditar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditar1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEditar1.Image = ((System.Drawing.Image)(resources.GetObject("botaoEditar1.Image")));
            this.botaoEditar1.Location = new System.Drawing.Point(123, 23);
            this.botaoEditar1.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoEditar1.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoEditar1.Name = "botaoEditar1";
            this.botaoEditar1.Size = new System.Drawing.Size(24, 24);
            this.botaoEditar1.TabIndex = 2;
            this.botaoEditar1.UseVisualStyleBackColor = true;
            this.botaoEditar1.Click += new System.EventHandler(this.botaoEditar1_Click);
            // 
            // UnidadeItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(150, 70);
            this.MinimumSize = new System.Drawing.Size(150, 70);
            this.Name = "UnidadeItem";
            this.Size = new System.Drawing.Size(150, 70);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNumero;
        private Botoes.BotaoEditar botaoEditar1;
    }
}

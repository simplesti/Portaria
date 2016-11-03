namespace Portaria.Desktop.Framework.Unidades
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblBloco = new MaterialSkin.Controls.MaterialLabel();
            this.lblNumero = new MaterialSkin.Controls.MaterialLabel();
            this.botaoEditar = new Portaria.Desktop.Framework.Botoes.BotaoPessoa();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.65546F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.34454F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.lblBloco, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNumero, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.botaoEditar, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(150, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lblBloco
            // 
            this.lblBloco.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblBloco.AutoSize = true;
            this.lblBloco.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblBloco.Depth = 0;
            this.lblBloco.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblBloco.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBloco.Location = new System.Drawing.Point(3, 25);
            this.lblBloco.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblBloco.Name = "lblBloco";
            this.lblBloco.Size = new System.Drawing.Size(19, 19);
            this.lblBloco.TabIndex = 3;
            this.lblBloco.Text = "A";
            // 
            // lblNumero
            // 
            this.lblNumero.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblNumero.AutoSize = true;
            this.lblNumero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblNumero.Depth = 0;
            this.lblNumero.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblNumero.Location = new System.Drawing.Point(49, 25);
            this.lblNumero.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(25, 19);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "20";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.botaoEditar.BackColor = System.Drawing.Color.Transparent;
            this.botaoEditar.BackgroundImage = global::Portaria.Desktop.Framework.Properties.Resources.ic_person_grey_24dp_1x;
            this.botaoEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.botaoEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEditar.Location = new System.Drawing.Point(122, 23);
            this.botaoEditar.MaximumSize = new System.Drawing.Size(24, 24);
            this.botaoEditar.MinimumSize = new System.Drawing.Size(24, 24);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(24, 24);
            this.botaoEditar.TabIndex = 5;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
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
        private MaterialSkin.Controls.MaterialLabel lblBloco;
        private MaterialSkin.Controls.MaterialLabel lblNumero;
        private Botoes.BotaoPessoa botaoEditar;
    }
}

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TabVisualizarUnidades));
            this.flpUnidades = new System.Windows.Forms.FlowLayoutPanel();
            this.chkSomente30 = new System.Windows.Forms.CheckBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.botaoPesquisar = new Portaria.Framework.Botoes.BotaoPesquisar();
            this.SuspendLayout();
            // 
            // flpUnidades
            // 
            this.flpUnidades.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpUnidades.Location = new System.Drawing.Point(0, 66);
            this.flpUnidades.Name = "flpUnidades";
            this.flpUnidades.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.flpUnidades.Size = new System.Drawing.Size(681, 375);
            this.flpUnidades.TabIndex = 3;
            // 
            // chkSomente30
            // 
            this.chkSomente30.AutoSize = true;
            this.chkSomente30.Checked = true;
            this.chkSomente30.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSomente30.Location = new System.Drawing.Point(3, 43);
            this.chkSomente30.Name = "chkSomente30";
            this.chkSomente30.Size = new System.Drawing.Size(167, 17);
            this.chkSomente30.TabIndex = 1;
            this.chkSomente30.Text = "Exibir somente os 30 primeiros";
            this.chkSomente30.UseVisualStyleBackColor = true;
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(3, 1);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(53, 13);
            this.lblPesquisar.TabIndex = 3;
            this.lblPesquisar.Text = "Pesquisar";
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(3, 17);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(264, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // botaoPesquisar
            // 
            this.botaoPesquisar.AutoSize = true;
            this.botaoPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("botaoPesquisar.Image")));
            this.botaoPesquisar.Location = new System.Drawing.Point(273, 10);
            this.botaoPesquisar.MaximumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.MinimumSize = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.Name = "botaoPesquisar";
            this.botaoPesquisar.Size = new System.Drawing.Size(32, 32);
            this.botaoPesquisar.TabIndex = 2;
            this.botaoPesquisar.UseVisualStyleBackColor = true;
            this.botaoPesquisar.Click += new System.EventHandler(this.botaoPesquisar_Click);
            // 
            // TabVisualizarUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.botaoPesquisar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.lblPesquisar);
            this.Controls.Add(this.chkSomente30);
            this.Controls.Add(this.flpUnidades);
            this.Name = "TabVisualizarUnidades";
            this.Size = new System.Drawing.Size(681, 441);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpUnidades;
        private System.Windows.Forms.CheckBox chkSomente30;
        private System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.TextBox txtPesquisar;
        private Framework.Botoes.BotaoPesquisar botaoPesquisar;
    }
}

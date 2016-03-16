namespace Portaria.Config
{
    partial class ConfiguracoesUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfiguracoesUsuario));
            this.botaoSalvar = new Portaria.Desktop.Framework.Botoes.BotaoSalvar();
            this.botaoCancelar = new Portaria.Desktop.Framework.Botoes.BotaoCancelar();
            this.lblCor = new System.Windows.Forms.Label();
            this.cboCor = new System.Windows.Forms.ComboBox();
            this.lblAjustesUsuario = new System.Windows.Forms.Label();
            this.chkPesquisaDetalhaada = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.BackColor = System.Drawing.Color.White;
            this.botaoSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSalvar.Image = ((System.Drawing.Image)(resources.GetObject("botaoSalvar.Image")));
            this.botaoSalvar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoSalvar.Location = new System.Drawing.Point(78, 229);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(100, 35);
            this.botaoSalvar.TabIndex = 0;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoSalvar.UseVisualStyleBackColor = false;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // botaoCancelar
            // 
            this.botaoCancelar.BackColor = System.Drawing.Color.White;
            this.botaoCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCancelar.Image = ((System.Drawing.Image)(resources.GetObject("botaoCancelar.Image")));
            this.botaoCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoCancelar.Location = new System.Drawing.Point(184, 229);
            this.botaoCancelar.Name = "botaoCancelar";
            this.botaoCancelar.Size = new System.Drawing.Size(100, 35);
            this.botaoCancelar.TabIndex = 1;
            this.botaoCancelar.Text = "Cancelar";
            this.botaoCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.botaoCancelar.UseVisualStyleBackColor = false;
            this.botaoCancelar.Click += new System.EventHandler(this.botaoCancelar_Click);
            // 
            // lblCor
            // 
            this.lblCor.AutoSize = true;
            this.lblCor.Location = new System.Drawing.Point(9, 50);
            this.lblCor.Name = "lblCor";
            this.lblCor.Size = new System.Drawing.Size(26, 13);
            this.lblCor.TabIndex = 2;
            this.lblCor.Text = "Cor:";
            // 
            // cboCor
            // 
            this.cboCor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCor.FormattingEnabled = true;
            this.cboCor.Location = new System.Drawing.Point(12, 66);
            this.cboCor.Name = "cboCor";
            this.cboCor.Size = new System.Drawing.Size(272, 21);
            this.cboCor.TabIndex = 3;
            // 
            // lblAjustesUsuario
            // 
            this.lblAjustesUsuario.AutoSize = true;
            this.lblAjustesUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAjustesUsuario.Location = new System.Drawing.Point(8, 9);
            this.lblAjustesUsuario.Name = "lblAjustesUsuario";
            this.lblAjustesUsuario.Size = new System.Drawing.Size(165, 24);
            this.lblAjustesUsuario.TabIndex = 4;
            this.lblAjustesUsuario.Text = "Ajustes do usuário";
            // 
            // chkPesquisaDetalhaada
            // 
            this.chkPesquisaDetalhaada.AutoSize = true;
            this.chkPesquisaDetalhaada.Location = new System.Drawing.Point(13, 94);
            this.chkPesquisaDetalhaada.Name = "chkPesquisaDetalhaada";
            this.chkPesquisaDetalhaada.Size = new System.Drawing.Size(197, 17);
            this.chkPesquisaDetalhaada.TabIndex = 5;
            this.chkPesquisaDetalhaada.Text = "Usar pesquisa detalhada por padrão";
            this.chkPesquisaDetalhaada.UseVisualStyleBackColor = true;
            // 
            // ConfiguracoesUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 276);
            this.Controls.Add(this.chkPesquisaDetalhaada);
            this.Controls.Add(this.lblAjustesUsuario);
            this.Controls.Add(this.cboCor);
            this.Controls.Add(this.lblCor);
            this.Controls.Add(this.botaoCancelar);
            this.Controls.Add(this.botaoSalvar);
            this.Name = "ConfiguracoesUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ConfiguracoesUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Desktop.Framework.Botoes.BotaoSalvar botaoSalvar;
        private Desktop.Framework.Botoes.BotaoCancelar botaoCancelar;
        private System.Windows.Forms.Label lblCor;
        private System.Windows.Forms.ComboBox cboCor;
        private System.Windows.Forms.Label lblAjustesUsuario;
        private System.Windows.Forms.CheckBox chkPesquisaDetalhaada;
    }
}
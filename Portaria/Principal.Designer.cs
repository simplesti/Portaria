﻿namespace Portaria
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
            this.tabVisualizarBlocos = new Portaria.TabVisualizarBlocos();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabReservarLocais = new Portaria.Locais.TabReservarLocais();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabVisualizarUsuarios = new Portaria.Usuarios.TabVisualizarUsuarios();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabCadastrarBlocos = new Portaria.Blocos.TabCadastrarBlocos();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabCadastrarUnidades = new Portaria.Unidades.TabCadastrarUnidades();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabCadastrarLocais = new Portaria.Locais.TabCadastrarLocais();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabVisualizarLivroNegro = new Portaria.LivroNegro.TabVisualizarLivroNegro();
            this.tabControl.SuspendLayout();
            this.pnlConteudo.SuspendLayout();
            this.tpUnidades.SuspendLayout();
            this.tpBlocos.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpUnidades);
            this.tabControl.Controls.Add(this.tpBlocos);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Size = new System.Drawing.Size(659, 417);
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Size = new System.Drawing.Size(659, 417);
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
            this.tabVisualizarUnidades.TabVisualizar = null;
            // 
            // tpBlocos
            // 
            this.tpBlocos.Controls.Add(this.tabVisualizarBlocos);
            this.tpBlocos.Location = new System.Drawing.Point(4, 22);
            this.tpBlocos.Name = "tpBlocos";
            this.tpBlocos.Padding = new System.Windows.Forms.Padding(3);
            this.tpBlocos.Size = new System.Drawing.Size(626, 391);
            this.tpBlocos.TabIndex = 1;
            this.tpBlocos.Text = "Blocos";
            this.tpBlocos.UseVisualStyleBackColor = true;
            // 
            // tabVisualizarBlocos
            // 
            this.tabVisualizarBlocos.BackColor = System.Drawing.Color.White;
            this.tabVisualizarBlocos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarBlocos.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarBlocos.Name = "tabVisualizarBlocos";
            this.tabVisualizarBlocos.Size = new System.Drawing.Size(620, 385);
            this.tabVisualizarBlocos.TabIndex = 0;
            this.tabVisualizarBlocos.TabVisualizar = this.tabVisualizarUnidades;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabReservarLocais);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 391);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Reserva de Locais";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabReservarLocais
            // 
            this.tabReservarLocais.BackColor = System.Drawing.Color.White;
            this.tabReservarLocais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReservarLocais.Location = new System.Drawing.Point(3, 3);
            this.tabReservarLocais.Name = "tabReservarLocais";
            this.tabReservarLocais.Size = new System.Drawing.Size(620, 385);
            this.tabReservarLocais.TabIndex = 1;
            this.tabReservarLocais.TabVisualizar = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabVisualizarUsuarios);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 391);
            this.tabPage3.TabIndex = 4;
            this.tabPage3.Text = "Cadastro de Usuários";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabVisualizarUsuarios
            // 
            this.tabVisualizarUsuarios.BackColor = System.Drawing.Color.White;
            this.tabVisualizarUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarUsuarios.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarUsuarios.Name = "tabVisualizarUsuarios";
            this.tabVisualizarUsuarios.Size = new System.Drawing.Size(620, 385);
            this.tabVisualizarUsuarios.TabIndex = 0;
            this.tabVisualizarUsuarios.TabVisualizar = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabCadastrarBlocos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 391);
            this.tabPage2.TabIndex = 5;
            this.tabPage2.Text = "Cadastro de Blocos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabCadastrarBlocos
            // 
            this.tabCadastrarBlocos.BackColor = System.Drawing.Color.White;
            this.tabCadastrarBlocos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadastrarBlocos.Location = new System.Drawing.Point(3, 3);
            this.tabCadastrarBlocos.Name = "tabCadastrarBlocos";
            this.tabCadastrarBlocos.Size = new System.Drawing.Size(620, 385);
            this.tabCadastrarBlocos.TabIndex = 0;
            this.tabCadastrarBlocos.TabVisualizar = null;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabCadastrarUnidades);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(626, 391);
            this.tabPage4.TabIndex = 6;
            this.tabPage4.Text = "Cadastro de Unidades";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabCadastrarUnidades
            // 
            this.tabCadastrarUnidades.BackColor = System.Drawing.Color.White;
            this.tabCadastrarUnidades.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadastrarUnidades.Location = new System.Drawing.Point(3, 3);
            this.tabCadastrarUnidades.Name = "tabCadastrarUnidades";
            this.tabCadastrarUnidades.Size = new System.Drawing.Size(620, 385);
            this.tabCadastrarUnidades.TabIndex = 0;
            this.tabCadastrarUnidades.TabVisualizar = null;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabCadastrarLocais);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(626, 391);
            this.tabPage5.TabIndex = 7;
            this.tabPage5.Text = "Cadastro de Locais";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabCadastrarLocais
            // 
            this.tabCadastrarLocais.BackColor = System.Drawing.Color.White;
            this.tabCadastrarLocais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadastrarLocais.Location = new System.Drawing.Point(3, 3);
            this.tabCadastrarLocais.Name = "tabCadastrarLocais";
            this.tabCadastrarLocais.Size = new System.Drawing.Size(620, 385);
            this.tabCadastrarLocais.TabIndex = 0;
            this.tabCadastrarLocais.TabVisualizar = null;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabVisualizarLivroNegro);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(626, 391);
            this.tabPage6.TabIndex = 8;
            this.tabPage6.Text = "Livro Negro";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabVisualizarLivroNegro
            // 
            this.tabVisualizarLivroNegro.BackColor = System.Drawing.Color.White;
            this.tabVisualizarLivroNegro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarLivroNegro.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarLivroNegro.Name = "tabVisualizarLivroNegro";
            this.tabVisualizarLivroNegro.Size = new System.Drawing.Size(620, 385);
            this.tabVisualizarLivroNegro.TabIndex = 0;
            this.tabVisualizarLivroNegro.TabVisualizar = null;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 480);
            this.Name = "Principal";
            this.Text = "Form1";
            this.Titulo = "Portaria Digital";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl.ResumeLayout(false);
            this.pnlConteudo.ResumeLayout(false);
            this.tpUnidades.ResumeLayout(false);
            this.tpBlocos.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpUnidades;
        private TabVisualizarUnidades tabVisualizarUnidades;
        private System.Windows.Forms.TabPage tpBlocos;
        private TabVisualizarBlocos tabVisualizarBlocos;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private Usuarios.TabVisualizarUsuarios tabVisualizarUsuarios;
        private System.Windows.Forms.TabPage tabPage2;
        private Blocos.TabCadastrarBlocos tabCadastrarBlocos;
        private System.Windows.Forms.TabPage tabPage4;
        private Unidades.TabCadastrarUnidades tabCadastrarUnidades;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private Locais.TabCadastrarLocais tabCadastrarLocais;
        private Locais.TabReservarLocais tabReservarLocais;
        private LivroNegro.TabVisualizarLivroNegro tabVisualizarLivroNegro;
    }
}


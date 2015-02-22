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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabCadastrarBlocos1 = new Portaria.Blocos.TabCadastrarBlocos();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabVisualizarLivroNegro1 = new Portaria.LivroNegro.TabVisualizarLivroNegro();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabCadastrarLocais1 = new Portaria.Locais.TabCadastrarLocais();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabReservarLocais1 = new Portaria.Locais.TabReservarLocais();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabVisualizarBlocos1 = new Portaria.TabVisualizarBlocos();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabVisualizarUnidades1 = new Portaria.TabVisualizarUnidades();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabCadastrarUnidades1 = new Portaria.Unidades.TabCadastrarUnidades();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.tabVisualizarUsuarios1 = new Portaria.Usuarios.TabVisualizarUsuarios();
            this.pnlConteudo.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.Controls.Add(this.tabControl);
            this.pnlConteudo.Size = new System.Drawing.Size(659, 417);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Controls.Add(this.tabPage8);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(659, 417);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tabCadastrarBlocos1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar Blocos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabCadastrarBlocos1
            // 
            this.tabCadastrarBlocos1.BackColor = System.Drawing.Color.White;
            this.tabCadastrarBlocos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadastrarBlocos1.Location = new System.Drawing.Point(3, 3);
            this.tabCadastrarBlocos1.Name = "tabCadastrarBlocos1";
            this.tabCadastrarBlocos1.Size = new System.Drawing.Size(645, 385);
            this.tabCadastrarBlocos1.TabIndex = 0;
            this.tabCadastrarBlocos1.TabVisualizar = null;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabVisualizarLivroNegro1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Livro Negro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabVisualizarLivroNegro1
            // 
            this.tabVisualizarLivroNegro1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarLivroNegro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarLivroNegro1.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarLivroNegro1.Name = "tabVisualizarLivroNegro1";
            this.tabVisualizarLivroNegro1.Size = new System.Drawing.Size(620, 385);
            this.tabVisualizarLivroNegro1.TabIndex = 0;
            this.tabVisualizarLivroNegro1.TabVisualizar = null;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabCadastrarLocais1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(626, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastrar Locais";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabCadastrarLocais1
            // 
            this.tabCadastrarLocais1.BackColor = System.Drawing.Color.White;
            this.tabCadastrarLocais1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadastrarLocais1.Location = new System.Drawing.Point(3, 3);
            this.tabCadastrarLocais1.Name = "tabCadastrarLocais1";
            this.tabCadastrarLocais1.Size = new System.Drawing.Size(620, 385);
            this.tabCadastrarLocais1.TabIndex = 0;
            this.tabCadastrarLocais1.TabVisualizar = null;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.tabReservarLocais1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(626, 391);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reservar Local";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabReservarLocais1
            // 
            this.tabReservarLocais1.BackColor = System.Drawing.Color.White;
            this.tabReservarLocais1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReservarLocais1.Location = new System.Drawing.Point(3, 3);
            this.tabReservarLocais1.Name = "tabReservarLocais1";
            this.tabReservarLocais1.Size = new System.Drawing.Size(620, 385);
            this.tabReservarLocais1.TabIndex = 0;
            this.tabReservarLocais1.TabVisualizar = null;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.tabVisualizarBlocos1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(626, 391);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Blocos";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabVisualizarBlocos1
            // 
            this.tabVisualizarBlocos1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarBlocos1.Location = new System.Drawing.Point(-1, 6);
            this.tabVisualizarBlocos1.Name = "tabVisualizarBlocos1";
            this.tabVisualizarBlocos1.Size = new System.Drawing.Size(641, 417);
            this.tabVisualizarBlocos1.TabIndex = 0;
            this.tabVisualizarBlocos1.TabVisualizar = null;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.tabVisualizarUnidades1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(626, 391);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Unidades";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabVisualizarUnidades1
            // 
            this.tabVisualizarUnidades1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarUnidades1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarUnidades1.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarUnidades1.Name = "tabVisualizarUnidades1";
            this.tabVisualizarUnidades1.Size = new System.Drawing.Size(620, 385);
            this.tabVisualizarUnidades1.TabIndex = 0;
            this.tabVisualizarUnidades1.TabVisualizar = null;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.tabCadastrarUnidades1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(651, 391);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Cadastrar Unidades";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabCadastrarUnidades1
            // 
            this.tabCadastrarUnidades1.BackColor = System.Drawing.Color.White;
            this.tabCadastrarUnidades1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadastrarUnidades1.Location = new System.Drawing.Point(3, 3);
            this.tabCadastrarUnidades1.Name = "tabCadastrarUnidades1";
            this.tabCadastrarUnidades1.Size = new System.Drawing.Size(645, 385);
            this.tabCadastrarUnidades1.TabIndex = 0;
            this.tabCadastrarUnidades1.TabVisualizar = null;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.tabVisualizarUsuarios1);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(651, 391);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Usuários";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // tabVisualizarUsuarios1
            // 
            this.tabVisualizarUsuarios1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarUsuarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarUsuarios1.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarUsuarios1.Name = "tabVisualizarUsuarios1";
            this.tabVisualizarUsuarios1.Size = new System.Drawing.Size(645, 385);
            this.tabVisualizarUsuarios1.TabIndex = 0;
            this.tabVisualizarUsuarios1.TabVisualizar = null;
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
            this.pnlConteudo.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private Blocos.TabCadastrarBlocos tabCadastrarBlocos1;
        private System.Windows.Forms.TabPage tabPage2;
        private LivroNegro.TabVisualizarLivroNegro tabVisualizarLivroNegro1;
        private System.Windows.Forms.TabPage tabPage3;
        private Locais.TabCadastrarLocais tabCadastrarLocais1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private Locais.TabReservarLocais tabReservarLocais1;
        private TabVisualizarBlocos tabVisualizarBlocos1;
        private System.Windows.Forms.TabPage tabPage6;
        private TabVisualizarUnidades tabVisualizarUnidades1;
        private System.Windows.Forms.TabPage tabPage7;
        private Unidades.TabCadastrarUnidades tabCadastrarUnidades1;
        private System.Windows.Forms.TabPage tabPage8;
        private Usuarios.TabVisualizarUsuarios tabVisualizarUsuarios1;

    }
}


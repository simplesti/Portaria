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
            this.tabControl = new Portaria.Desktop.Framework.PortariaTabControl();
            this.tabPage1 = new Portaria.Desktop.Framework.Forms.PortariaTabPage();
            this.tabCadastrarBlocos1 = new Portaria.Blocos.TabCadastrarBlocos();
            this.tabPage2 = new Portaria.Desktop.Framework.Forms.PortariaTabPage();
            this.tabVisualizarLivroNegro1 = new Portaria.LivroNegro.TabVisualizarLivroNegro();
            this.tabPage3 = new Portaria.Desktop.Framework.Forms.PortariaTabPage();
            this.tabCadastrarLocais1 = new Portaria.Locais.TabCadastrarLocais();
            this.tabPage4 = new Portaria.Desktop.Framework.Forms.PortariaTabPage();
            this.tabReservarLocais1 = new Portaria.Locais.TabReservarLocais();
            this.tabPage5 = new Portaria.Desktop.Framework.Forms.PortariaTabPage();
            this.tabVisualizarBlocos1 = new Portaria.TabVisualizarBlocos();
            this.tabPage6 = new Portaria.Desktop.Framework.Forms.PortariaTabPage();
            this.tabVisualizarUnidades1 = new Portaria.TabVisualizarUnidades();
            this.tabPage7 = new Portaria.Desktop.Framework.Forms.PortariaTabPage();
            this.tabCadastrarUnidades1 = new Portaria.Unidades.TabCadastrarUnidades();
            this.tabPage8 = new Portaria.Desktop.Framework.Forms.PortariaTabPage();
            this.tabVisualizarUsuarios1 = new Portaria.Usuarios.TabVisualizarUsuarios();
            this.tabPage9 = new Portaria.Desktop.Framework.Forms.PortariaTabPage();
            this.tabVisualizarCategorias1 = new Portaria.LivroNegro.TabVisualizarCategorias();
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
            this.tabPage9.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConteudo
            // 
            this.pnlConteudo.BackColor = System.Drawing.Color.Transparent;
            this.pnlConteudo.Controls.Add(this.tabControl);
            this.pnlConteudo.Size = new System.Drawing.Size(659, 417);
            // 
            // tabControl
            // 
            this.tabControl.AllowDrop = true;
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Controls.Add(this.tabPage4);
            this.tabControl.Controls.Add(this.tabPage5);
            this.tabControl.Controls.Add(this.tabPage6);
            this.tabControl.Controls.Add(this.tabPage7);
            this.tabControl.Controls.Add(this.tabPage8);
            this.tabControl.Controls.Add(this.tabPage9);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(659, 417);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.tabCadastrarBlocos1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(651, 391);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar Blocos";
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
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.tabVisualizarLivroNegro1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(755, 391);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Livro Negro";
            // 
            // tabVisualizarLivroNegro1
            // 
            this.tabVisualizarLivroNegro1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarLivroNegro1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarLivroNegro1.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarLivroNegro1.Name = "tabVisualizarLivroNegro1";
            this.tabVisualizarLivroNegro1.Size = new System.Drawing.Size(749, 385);
            this.tabVisualizarLivroNegro1.TabIndex = 0;
            this.tabVisualizarLivroNegro1.TabVisualizar = null;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.tabCadastrarLocais1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(755, 391);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cadastrar Locais";
            // 
            // tabCadastrarLocais1
            // 
            this.tabCadastrarLocais1.BackColor = System.Drawing.Color.White;
            this.tabCadastrarLocais1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadastrarLocais1.Location = new System.Drawing.Point(3, 3);
            this.tabCadastrarLocais1.Name = "tabCadastrarLocais1";
            this.tabCadastrarLocais1.Size = new System.Drawing.Size(749, 385);
            this.tabCadastrarLocais1.TabIndex = 0;
            this.tabCadastrarLocais1.TabVisualizar = null;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.tabReservarLocais1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(755, 391);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Reservar Local";
            // 
            // tabReservarLocais1
            // 
            this.tabReservarLocais1.BackColor = System.Drawing.Color.White;
            this.tabReservarLocais1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabReservarLocais1.Location = new System.Drawing.Point(3, 3);
            this.tabReservarLocais1.Name = "tabReservarLocais1";
            this.tabReservarLocais1.Size = new System.Drawing.Size(749, 385);
            this.tabReservarLocais1.TabIndex = 0;
            this.tabReservarLocais1.TabVisualizar = null;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Transparent;
            this.tabPage5.Controls.Add(this.tabVisualizarBlocos1);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(651, 391);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Blocos";
            // 
            // tabVisualizarBlocos1
            // 
            this.tabVisualizarBlocos1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarBlocos1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarBlocos1.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarBlocos1.Name = "tabVisualizarBlocos1";
            this.tabVisualizarBlocos1.Size = new System.Drawing.Size(645, 385);
            this.tabVisualizarBlocos1.TabIndex = 0;
            this.tabVisualizarBlocos1.TabVisualizar = this.tabVisualizarUnidades1;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage6.Controls.Add(this.tabVisualizarUnidades1);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(755, 391);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Unidades";
            // 
            // tabVisualizarUnidades1
            // 
            this.tabVisualizarUnidades1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarUnidades1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarUnidades1.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarUnidades1.Name = "tabVisualizarUnidades1";
            this.tabVisualizarUnidades1.Size = new System.Drawing.Size(749, 385);
            this.tabVisualizarUnidades1.TabIndex = 0;
            this.tabVisualizarUnidades1.TabVisualizar = null;
            // 
            // tabPage7
            // 
            this.tabPage7.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage7.Controls.Add(this.tabCadastrarUnidades1);
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(755, 391);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Cadastrar Unidades";
            // 
            // tabCadastrarUnidades1
            // 
            this.tabCadastrarUnidades1.BackColor = System.Drawing.Color.White;
            this.tabCadastrarUnidades1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCadastrarUnidades1.Location = new System.Drawing.Point(3, 3);
            this.tabCadastrarUnidades1.Name = "tabCadastrarUnidades1";
            this.tabCadastrarUnidades1.Size = new System.Drawing.Size(749, 385);
            this.tabCadastrarUnidades1.TabIndex = 0;
            this.tabCadastrarUnidades1.TabVisualizar = null;
            // 
            // tabPage8
            // 
            this.tabPage8.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage8.Controls.Add(this.tabVisualizarUsuarios1);
            this.tabPage8.Location = new System.Drawing.Point(4, 22);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage8.Size = new System.Drawing.Size(755, 391);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Usuários";
            // 
            // tabVisualizarUsuarios1
            // 
            this.tabVisualizarUsuarios1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarUsuarios1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarUsuarios1.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarUsuarios1.Name = "tabVisualizarUsuarios1";
            this.tabVisualizarUsuarios1.Size = new System.Drawing.Size(749, 385);
            this.tabVisualizarUsuarios1.TabIndex = 0;
            this.tabVisualizarUsuarios1.TabVisualizar = null;
            // 
            // tabPage9
            // 
            this.tabPage9.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage9.Controls.Add(this.tabVisualizarCategorias1);
            this.tabPage9.Location = new System.Drawing.Point(4, 22);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage9.Size = new System.Drawing.Size(755, 391);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Categorias";
            // 
            // tabVisualizarCategorias1
            // 
            this.tabVisualizarCategorias1.BackColor = System.Drawing.Color.White;
            this.tabVisualizarCategorias1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabVisualizarCategorias1.Location = new System.Drawing.Point(3, 3);
            this.tabVisualizarCategorias1.Name = "tabVisualizarCategorias1";
            this.tabVisualizarCategorias1.Size = new System.Drawing.Size(749, 385);
            this.tabVisualizarCategorias1.TabIndex = 0;
            this.tabVisualizarCategorias1.TabVisualizar = null;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 480);
            this.ConfiguracoesUsuarioVisivel = true;
            this.Name = "Principal";
            this.Text = "Portaria Digital";
            this.Titulo = "Portaria Digital";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
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
            this.tabPage9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Portaria.Desktop.Framework.PortariaTabControl tabControl;
        private Portaria.Desktop.Framework.Forms.PortariaTabPage tabPage1;
        private Blocos.TabCadastrarBlocos tabCadastrarBlocos1;
        private Portaria.Desktop.Framework.Forms.PortariaTabPage tabPage2;
        private LivroNegro.TabVisualizarLivroNegro tabVisualizarLivroNegro1;
        private Portaria.Desktop.Framework.Forms.PortariaTabPage tabPage3;
        private Locais.TabCadastrarLocais tabCadastrarLocais1;
        private Portaria.Desktop.Framework.Forms.PortariaTabPage tabPage4;
        private Portaria.Desktop.Framework.Forms.PortariaTabPage tabPage5;
        private Locais.TabReservarLocais tabReservarLocais1;
        private TabVisualizarBlocos tabVisualizarBlocos1;
        private Portaria.Desktop.Framework.Forms.PortariaTabPage tabPage6;
        private TabVisualizarUnidades tabVisualizarUnidades1;
        private Portaria.Desktop.Framework.Forms.PortariaTabPage tabPage7;
        private Unidades.TabCadastrarUnidades tabCadastrarUnidades1;
        private Portaria.Desktop.Framework.Forms.PortariaTabPage tabPage8;
        private Usuarios.TabVisualizarUsuarios tabVisualizarUsuarios1;
        private Portaria.Desktop.Framework.Forms.PortariaTabPage tabPage9;
        private LivroNegro.TabVisualizarCategorias tabVisualizarCategorias1;
    }
}


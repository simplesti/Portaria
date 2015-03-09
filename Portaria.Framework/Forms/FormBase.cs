using Portaria.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria.Framework
{
    public partial class FormBase : Form
    {
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        public FormBase()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (SessaoBus.Sessao() != null && SessaoBus.Sessao().UsuarioLogado.CorTema != 0)
            {
                this.BackColor = Color.FromArgb(SessaoBus.Sessao().UsuarioLogado.CorTema);
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(this.DisplayRectangle.Location,
                new Size(this.DisplayRectangle.Width-1,this.DisplayRectangle.Height-1)));
        }

        private void FormBase_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void FormBase_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void FormBase_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
    }
}

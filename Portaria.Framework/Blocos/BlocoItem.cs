﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portaria.Core.Model.CadastroMorador;

namespace Portaria.Framework.Blocos
{
    public partial class BlocoItem : UserControl
    {
        private Bloco bloco;

        public Bloco Bloco
        {
            get
            {
                return bloco;
            }

            set
            {
                bloco = value;

                lblBloco.Text = bloco.Nome;
            }
        }

        public event EventHandler<BlocoEventArgs> VisualizarBlocoClick;

        public BlocoItem()
        {
            InitializeComponent();
        }

        public BlocoItem(Bloco bloco)
            : this()
        {
            this.Bloco = bloco;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);

            e.Graphics.DrawRectangle(Pens.Black,
                new Rectangle(this.DisplayRectangle.Location,
                    new Size(this.Width - 1, this.Height - 1)));
        }

        private void lblBloco_Click(object sender, EventArgs e)
        {
            VisualizarBlocoClick(sender, new BlocoEventArgs(Bloco));
        }
    }
}

using Portaria.Business.Cadastro;
using Portaria.Framework;
using Portaria.Framework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portaria
{
    public partial class Principal : FormWindowTabbed
    {
        public Principal()
        {
            InitializeComponent();
            Aquecer();
        }

        private void Aquecer()
        {
            var unidadeBus = new UnidadeBus();

            var dumy = unidadeBus.Todos().FirstOrDefault();

        }
    }
}

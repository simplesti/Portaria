using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Portaria.Framework.Forms;
using Portaria.Core;

namespace Portaria
{
    public partial class TabVisualizarBlocos : UserControl, IPortariaTab
    {
        public TabVisualizarBlocos()
        {
            InitializeComponent();
        }


        public ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador, TipoUsuario.SomenteLeitura };
            }
        }
    }
}

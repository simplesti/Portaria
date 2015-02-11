using Portaria.Core;
using Portaria.Framework.Forms;
using System.Collections.Generic;

namespace Portaria.LivroNegro
{
    public partial class TabVisualizarLivroNegro : PortariaTabBase
    {
        public TabVisualizarLivroNegro()
        {
            InitializeComponent();
        }

        public override ICollection<TipoUsuario> TiposUsuariosPermitidos
        {
            get
            {
                return new List<TipoUsuario> { TipoUsuario.Administrador, TipoUsuario.SomenteLeitura };
            }
        }
    }
}

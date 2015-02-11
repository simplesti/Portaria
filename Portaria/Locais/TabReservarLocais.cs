using Portaria.Core;
using Portaria.Framework.Forms;
using System.Collections.Generic;

namespace Portaria.Locais
{
    public partial class TabReservarLocais : PortariaTabBase
    {
        public TabReservarLocais()
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

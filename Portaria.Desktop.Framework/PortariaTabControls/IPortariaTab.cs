using Portaria.Core;
using Portaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Desktop.Framework.Forms
{
    public interface IPortariaTab
    {
        ICollection<TipoUsuario> TiposUsuariosPermitidos { get; }

        PortariaTabBase TabVisualizar { get; set; }
    }
}

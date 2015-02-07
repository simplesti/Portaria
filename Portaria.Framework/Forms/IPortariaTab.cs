using Portaria.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Framework.Forms
{
    public interface IPortariaTab
    {
        ICollection<TipoUsuario> TiposUsuariosPermitidos { get; }
    }
}

using Portaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Plugins
{
    public abstract class PortariaPlugin
    {
        public virtual string Nome { get; }

        public virtual void Executar() { }

        public virtual void Parar() { }

        public virtual void Ajustar() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Plugin.Base
{
    public abstract class PortariaPluginBase
    {
        public virtual string Nome { get; set; }

        public virtual void Executar() { }

        public virtual void Parar() { }
    }
}

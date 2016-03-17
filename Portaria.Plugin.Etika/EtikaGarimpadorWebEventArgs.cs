using System;
using System.Collections.Generic;

namespace Portaria.Plugin.Etika
{
    public class EtikaGarimpadorWebEventArgs : EventArgs
    {
        public IEnumerable<int> UnidadesInadimplentes { get; set; }

        public EtikaGarimpadorWebEventArgs(IEnumerable<int> unidadesInadimplentes) : base()
        {
            this.UnidadesInadimplentes = unidadesInadimplentes;
        }
    }
}

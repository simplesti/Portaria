using Portaria.Core.Model.Cadastro;
using System;

namespace Portaria.Framework.Locais
{
    public class LocalEventArgs : EventArgs
    {
        private Local local;
        
        public Local Local
        {
            get
            {
                return local;
            }
        }

        public LocalEventArgs(Local local)
        {
            this.local = local;
        }
    }
}

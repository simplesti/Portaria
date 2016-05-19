using Portaria.Core.Model;
using System;

namespace Portaria.Core
{
    public class IEntidadeEventArgs : EventArgs
    {
        public IEntidade Entidade { get; set; }

        public IEntidadeEventArgs(IEntidade entidade) : base()
        {
            this.Entidade = entidade;
        }
    }
}

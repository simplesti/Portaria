using Portaria.Core.Model.CadastroMorador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Portaria.Desktop.Framework.Unidades
{
    public class UnidadeEventArgs : EventArgs
    {
        public Unidade Unidade
        {
            get
            {
                return this.unidade;
            }
        }

        private Unidade unidade;

        public UnidadeEventArgs(Unidade unidade)
        {
            this.unidade = unidade;
        }
    }
}

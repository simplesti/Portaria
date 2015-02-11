using Portaria.Core.Model.CadastroMorador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Framework.Blocos
{
    public class BlocoEventArgs : EventArgs
    {
        private Bloco bloco;

        public Bloco Bloco
        {
            get
            {
                return bloco;
            }
        }

        public BlocoEventArgs(Bloco bloco)
        {
            this.bloco = bloco;
        }
    }
}

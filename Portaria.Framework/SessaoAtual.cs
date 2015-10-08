using Portaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria
{
    public static class SessaoAtual
    {
        private static Sessao sessao = null;
        public static Sessao Sessao
        {
            get { return sessao; }
            set { sessao = value; }
        }
    }
}

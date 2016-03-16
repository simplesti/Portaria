using Portaria.Core.Model;

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

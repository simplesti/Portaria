using System;

namespace Portaria.ControleAcessoBiometrico
{
    public class AcessoLiberadoEventArgs : EventArgs
    {
        public IdBiometria Entidade { get; set; }

        public AcessoLiberadoEventArgs(IdBiometria entidade)
        {
            Entidade = entidade;
        }
    }
}

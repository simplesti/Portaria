using Portaria.Data;
using System.Collections.Generic;
using System.Linq;

namespace Portaria.ControleAcessoBiometrico
{
    public static class RepositorioBiometria
    {
        private static List<IdBiometria> _biometriasAutorizadas = null;
        public static List<IdBiometria> BiometriasAutorizadas
        {
            get
            {
                if (_biometriasAutorizadas == null)
                {
                    AtualizarCache();
                }
                return _biometriasAutorizadas;
            }
            set
            {
                _biometriasAutorizadas = value;
            }
        }

        public static void AtualizarCache()
        {
            using (var bd = new PortariaContext())
            {
                _biometriasAutorizadas = new List<IdBiometria>();
                _biometriasAutorizadas.AddRange(bd.Pessoas.Where(ps => ps.ControleAcessoAutorizado).Select(p => new IdBiometria() { Id = p.Id, Biometria = p.Biometria, Tipo = TipoBiometria.Pessoa }).ToList());
                _biometriasAutorizadas.AddRange(bd.Funcionarios.Where(ps => ps.ControleAcessoAutorizado).Select(p => new IdBiometria() { Id = p.Id, Biometria = p.Biometria, Tipo = TipoBiometria.Funcionario }).ToList());
                _biometriasAutorizadas.AddRange(bd.Usuarios.Where(ps => ps.ControleAcessoAutorizado).Select(p => new IdBiometria() { Id = p.Id, Biometria = p.Biometria, Tipo = TipoBiometria.Usuario }).ToList());
            }
        }
    }
}

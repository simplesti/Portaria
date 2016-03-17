using Portaria.Business.Cadastro;
using Portaria.Core;
using Portaria.Core.Model;
using Portaria.Core.Model.Cadastro;
using Portaria.Core.Model.CadastroMorador;
using Portaria.Core.Model.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business
{
    public class PortariaBusFactory
    {
        public static IPortariaBus<T> Buscar<T>(Sessao sessao) where T : IEntidade
        {
            var tipo = typeof(T).Name;

            if (tipo == typeof(Unidade).Name)
            {
                return new UnidadeBus(sessao) as IPortariaBus<T>;
            }
            else if (tipo == typeof(Veiculo).Name)
            {
                return new VeiculoBus(sessao) as IPortariaBus<T>;
            }
            else if (tipo == typeof(Pessoa).Name)
            {
                return new PessoaBus(sessao) as IPortariaBus<T>;
            }
            else if (tipo == typeof(Local).Name)
            {
                return new LocalBus(sessao) as IPortariaBus<T>;
            }
            else if (tipo == typeof(Funcionario).Name)
            {
                return new FuncionarioBus(sessao) as IPortariaBus<T>;
            }
            else if (tipo == typeof(Bloco).Name)
            {
                return new BlocoBus(sessao) as IPortariaBus<T>;
            }
            else if (tipo == typeof(Usuario).Name)
            {
                return new UsuarioBus(sessao) as IPortariaBus<T>;
            }
            else if (tipo == typeof(Reserva).Name)
            {
                return new ReservaBus(sessao) as IPortariaBus<T>;
            }
            else if (tipo == typeof(RegistroLivroNegro).Name)
            {
                return new RegistroLivroNegroBus(sessao) as IPortariaBus<T>;
            }
            else if (tipo == typeof(Configuracao).Name)
            {
                return new ConfiguracaoBus(sessao) as IPortariaBus<T>;
            }

            return null;
        }
    }
}
using Portaria.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business
{
    public interface IPortariaBus<T> where T : IModel
    {
        IEnumerable<T> Todos();

        void InserirOuAtualizar(T entidade);

        T BuscaPorId(int id);

        void Remover(T entidade);
    }
}

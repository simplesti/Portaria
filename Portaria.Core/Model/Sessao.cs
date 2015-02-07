using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model
{
    public class Sessao : IModel
    {
        public int Id { get; set; }

        public DateTime? DataHoraInicio { get; set; }

        public DateTime? DataHoraFim { get; set; }

        public virtual Usuario UsuarioLogado { get; set; }

        public string NomeEstacao { get; set; }
    }
}

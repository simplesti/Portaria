using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model
{
    public class Usuario : IModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public TipoUsuario Tipo { get; set; }

        public virtual ICollection<Sessao> Sessoes { get; set; }
    }
}

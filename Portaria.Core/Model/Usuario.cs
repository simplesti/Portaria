using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model
{
    public class Usuario : IEntidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public TipoUsuario Tipo { get; set; }

        public virtual ICollection<Sessao> Sessoes { get; set; }

        public string TipoEntidade
        {
            get { return typeof(Usuario).Name; }
        }

        public string DescricaoEntidade
        {
            get { return Nome; }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}

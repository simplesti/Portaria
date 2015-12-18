using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model
{
    public class CategoriaLivroNegro : IEntidade
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public bool EnviarEmailNotificacao { get; set; }

        public string TipoEntidade
        {
            get
            {
                return this.Nome;
            }
        }

        public string DescricaoEntidade
        {
            get
            {
                return this.Nome;
            }
        }

        public override string ToString()
        {
            return Nome;
        }

    }
}

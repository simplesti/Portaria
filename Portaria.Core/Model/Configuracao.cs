using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model
{
    public class Configuracao : IEntidade
    {
        public string DescricaoEntidade
        {
            get
            {
                return "Configuracao";
            }
        }

        public int Id { get; set; }

        public string Nome { get; set; }

        public string Valor { get; set; }

        public string TipoEntidade
        {
            get
            {
                return "Configuracao";
            }
        }
    }
}

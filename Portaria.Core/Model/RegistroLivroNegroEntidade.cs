using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model
{
    public class RegistroLivroNegroEntidade : IEntidade
    {
        public int Id { get; set; }

        public int IdEntidade { get; set; }

        public string Tipo { get; set; }

        public virtual RegistroLivroNegro RegistroLivroNegro { get; set; }


        public string TipoEntidade
        {
            get { return typeof(RegistroLivroNegroEntidade).Name; }
        }

        public string DescricaoEntidade
        {
            get
            {
                return string.Format("Entidade Id {0} do registro do livro negro Id {1}", Id.ToString(),
                    RegistroLivroNegro.Id.ToString());
            }
        }

        public override string ToString()
        {
            return DescricaoEntidade;
        }
    }
}

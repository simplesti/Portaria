using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model.CadastroMorador
{
    public class Bloco : IModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public virtual ICollection<Unidade> Unidades { get; set; }

        public override string ToString()
        {
            return Nome;
        }
    }
}

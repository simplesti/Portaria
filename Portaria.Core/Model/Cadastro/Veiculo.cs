using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model.CadastroMorador
{
    public class Veiculo : IModel
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public string Placa { get; set; }

        public string Cor { get; set; }

        public byte[] Foto { get; set; }

        public virtual Unidade Unidade { get; set; }

        public virtual Pessoa Proprietario { get; set; }
    }
}

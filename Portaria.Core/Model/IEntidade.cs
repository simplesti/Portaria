using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core.Model
{
    public interface IEntidade
    {
        int Id { get; set; }

        string TipoEntidade();

        string DescricaoEntidade();
    }
}

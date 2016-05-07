using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Core
{
    public interface IBiometria
    {
        string Nome { get; set; }
        byte[] Biometria { get; set; }
    }
}

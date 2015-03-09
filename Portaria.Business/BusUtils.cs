using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business
{
    public static class BusUtils
    {
        public static bool Between(this DateTime data, DateTime inicio, DateTime fim)
        {
            return (data > inicio && data < fim);
        }
    }
}

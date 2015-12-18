using Portaria.Data;
using Portaria.Log;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.Business
{
    public static class BusUtils
    {
        public static string RemoveAccents(this string s)
        {
            Encoding destEncoding = Encoding.GetEncoding("iso-8859-8");

            return destEncoding.GetString(
                Encoding.Convert(Encoding.UTF8, destEncoding, Encoding.UTF8.GetBytes(s)));
        }

        public static bool Between(this DateTime data, DateTime inicio, DateTime fim)
        {
            return (data > inicio && data < fim);
        }

        public static void Aquecer()
        {
            using (var bd = new PortariaContext())
            {
                var dummy = bd.Usuarios.FirstOrDefault();
            }

            PortariaLog.Aquecer();
        }
    }
}

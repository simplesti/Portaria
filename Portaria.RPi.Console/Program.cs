using Portaria.RPi.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portaria.RPi.RPiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string endpoint = string.Empty;
            int tempo = 0;
            RPiControleAcesso rpi = null;
            bool sair = false;

            while (!sair)
            {
                Console.Clear();
                Console.Write("=> ");
                var comando = Console.ReadLine();
                if (comando.ToUpper().Equals("ABRIR"))
                {
                    if (rpi != null)
                    {
                        rpi.LiberarAcesso();
                    }
                }
                else if (comando.ToUpper().Equals("CONFIG"))
                {
                    Console.Write("Entre com o endereco: ");
                    endpoint = Console.ReadLine();
                    Console.Write("Entre com o tempo de abertura: ");
                    tempo = int.Parse(Console.ReadLine());

                    rpi = new Api.RPiControleAcesso(endpoint, tempo);
                }
                else if (comando.ToUpper().Equals("SAIR"))
                {
                    sair = true;
                }
            }
        }
    }
}

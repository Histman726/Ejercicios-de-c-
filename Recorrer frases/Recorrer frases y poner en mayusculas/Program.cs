using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recorrer_frases_y_poner_en_mayusculas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;
            bool res = true;

            do
            {
                Console.WriteLine("Escribe la frase a recorrer: ");
                frase = Console.ReadLine();
                if (string.IsNullOrEmpty(frase) || string.IsNullOrWhiteSpace(frase))
                {
                    Console.WriteLine("Texto invalido");
                }
                else
                {
                    foreach (char c in frase)
                    {
                        Console.WriteLine(c.ToString().ToUpper());
                    }
                }
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r = Convert.ToChar(Console.ReadLine());
                res = r.ToString().ToLower() == "s" ? true : false;
            } while (res);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_par_y_divisible_entre_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool res = true;

            do
            {
                Console.WriteLine("Numeros pares del 1 al 100");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("Numeros divisibles entre 3 del 1 al 100");
                for (int i = 1; i <= 100; i++)
                {
                    if (i % 3 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r = Convert.ToChar(Console.ReadLine());
                res = r.ToString().ToLower() == "s" ? true : false;
            } while (res);
        }
    }
}

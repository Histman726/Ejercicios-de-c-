using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recoriido_de_numeros_dado_por_el_usuario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool res = true;
            int num=0;
            do
            {
                Console.WriteLine("Numero limite: ");
                num= Convert.ToInt32(Console.ReadLine());
                if (num <= 1)
                {
                    Console.WriteLine("Limite inferior es invalido");
                }
                else
                {
                    Console.WriteLine("Numeros pares del 1 al " + num.ToString());
                    for (int i = 1; i <= num; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                    Console.WriteLine("Numeros divisibles entre 3 del 1 al "+num.ToString());
                    for (int i = 1; i <= num; i++)
                    {
                        if (i % 3 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r = Convert.ToChar(Console.ReadLine());
                res = r.ToString().ToLower() == "s" ? true : false;
            } while (res);
        }
    }
}

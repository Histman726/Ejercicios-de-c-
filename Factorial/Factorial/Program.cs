using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear una funcion que calcule el factorial de un numero
             */

            int num = 0;
            bool res = true;

            do
            {
                Console.WriteLine("Escribe el numero del que se va a sacar el factorial");
                num = Convert.ToInt32(Console.ReadLine());
                if(num <= 1)
                {
                    Console.WriteLine("Numero invalido");
                }
                else
                {
                    Console.WriteLine("El factorial del numero "+num.ToString());
                    int fact=factorial(num);
                    Console.WriteLine(fact.ToString());
                }
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r = Convert.ToChar(Console.ReadLine());
                res = r.ToString().ToLower() == "s" ? true : false;
            } while(res);

        }
        public static int factorial(int num)
        {

            int resultado = num; 
            for (int i = num - 1; i > 1; i--) 
            {
                resultado *= i;
            }
            return resultado; 

        }
    }
}

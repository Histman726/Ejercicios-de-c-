using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recorrer_frase_y_mostrar_sin_espacios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Crear un programa que recorra los caracteres de una frase y muestre la frase sin espacios
             */

            bool res = true;
            string frase=string.Empty,fraseSinEspacios=string.Empty;

            do
            {
                Console.WriteLine("Escriba la frase a recorrer");
                frase=Console.ReadLine();
                if (string.IsNullOrEmpty(frase) || string.IsNullOrWhiteSpace(frase))
                {
                    Console.WriteLine("Texto invalido");
                }
                else
                {
                    foreach (char c in frase)
                    {
                        if (c !=' ')
                        {
                            fraseSinEspacios+=c.ToString();
                        }
                    }
                    Console.WriteLine(fraseSinEspacios);
                }
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r = Convert.ToChar(Console.ReadLine());
                res = r.ToString().ToLower() == "s" ? true : false;
            } while(res);
        }
    }
}

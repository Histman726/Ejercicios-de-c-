using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invertir_un_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             - Pedir al humano que ingrese un texto.
             - Obtener la longitud del texto.
             - Crear un ciclo inverso que almacene las letras pero al revés.
             - Mostrar el texto invertido.
             */
            string texto = string.Empty,textoInvertido=string.Empty;
            char res = 's';

            do
            {
                Console.WriteLine("Escribe una palabra o frase");
                texto = Console.ReadLine();
                foreach(var letra in texto)
                {
                    textoInvertido = letra + textoInvertido;
                }
                Console.WriteLine("Su texto de manera invertida es: " + textoInvertido);

                Console.WriteLine("¿Desea repetir el ciclo?");
                res = Convert.ToChar(Console.ReadLine());
            } while (res == 's');
        }
    }
}

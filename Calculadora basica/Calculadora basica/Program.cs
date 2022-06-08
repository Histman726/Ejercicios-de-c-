using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_basica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear una calculadora funcional con las 4 operaciones basicas 
            *Opcional: Que almacene el historial de operaciones
            */
            int res = 0, num = 0, num2 = 0,opcion=0;
            bool respuesta = true;
            do
            {
                Console.WriteLine("Escriba los numeros que desea usar:");
                Console.WriteLine("Numero 1:");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Numero 2:");
                num2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Menu:\n 1. Sumar\t2. Restar\t3. Dividir\t4. Multiplicar");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        res = num + num2;
                        Console.WriteLine("La suma de los numeros es: "+res.ToString());
                        break;
                    case 2:
                        res = num - num2;
                        Console.WriteLine("La resta de los numeros es: " + res.ToString());
                        break;
                    case 3:
                        if(num2 == 0)
                        {
                            Console.WriteLine("Valor invalido para el divisor");
                        }
                        else
                        {
                            res = num / num2;
                            Console.WriteLine("La division de los numeros es " + res.ToString());
                        }
                        break;
                    case 4:
                        res = num * num2;
                        Console.WriteLine("La multiplicacion de los numeros es " + res.ToString());
                        break ;
                    default:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r=Convert.ToChar(Console.ReadLine());
                respuesta=r.ToString().ToLower()=="s"?true:false;
            } while (respuesta);
        }
    }
}

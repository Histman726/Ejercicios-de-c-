using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Precios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal precio = 0;
            int formaPago=0;
            bool res = true;

            do
            {
                Console.WriteLine("Ingrese el precio del producto:");
                precio = Convert.ToDecimal(Console.ReadLine());
                if (precio <= 0)
                {
                    Console.WriteLine("Precio invalido");
                }
                else
                {
                    Console.WriteLine("Ingresa tu forma de pago\n 1. Efectivo\t2. Tarjeta");
                    formaPago = Convert.ToInt32(Console.ReadLine());
                    switch (formaPago)
                    {
                        case 1:
                            Console.WriteLine("Pago exitoso");
                            break;
                        case 2:
                            Console.WriteLine("Ingrese el numero de cuenta");
                            int cuenta = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Pago exitoso");
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                }
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r = Convert.ToChar(Console.ReadLine());
                res = r.ToString().ToLower() == "s" ? true : false;
            } while (res);
        }
    }
}

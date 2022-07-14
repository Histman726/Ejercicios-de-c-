using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu_bancario
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * 1.- Ver saldo. mostrará el saldo que tenemos (al iniciar tendremos un saldo de 100.00).
               2.- Ingresar dinero. Pedirá el la cantidad de dinero que queramos ingresar y aumentará nuestro saldo inicial.
               3.- Sacar dinero. Restará el dinero que tengamos, si el saldo menos dineroSacar es menor a 0 se cancela la operación.
               4.- Salir. terminara el sistema.
             */

            decimal saldo = 100;
            int opcion = 0;
            do
            {
                Console.WriteLine("Escoja una de las siguientes opciones:\n\t1.Ver saldo\n\t2.Ingresar dinero\n\t3.Sacar dinero\n\t4.Salir");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("El saldo es " + saldo);
                        break;
                    case 2:
                        Console.WriteLine("¿Cuanto dinero va ingresar?");
                        decimal retiro= Convert.ToDecimal(Console.ReadLine());
                        saldo += retiro;
                        Console.WriteLine("Tu saldo actual es: " + saldo);
                        break;
                    case 3:
                        Console.WriteLine("¿Cuanto dinero va sacar?");
                        decimal sacar = Convert.ToDecimal(Console.ReadLine());
                        if (sacar > saldo)
                        {
                            Console.WriteLine("No se puede sacar mas dinero del que se tiene");
                            break;
                        }    
                        saldo -= sacar;
                        Console.WriteLine("Tu saldo actual es: " + saldo);
                        break;
                    case 4:
                        Console.WriteLine("Saliendo...");
                        Environment.Exit(0);
                        break;
                }
            } while (opcion == 1 || opcion == 2 || opcion == 3 || opcion == 4);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Retiro_bancario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pin = 3867, userPin = 0, intentos = 4, opc = 0;
            decimal userSaldo = 4000, montoRetiro = 0;
            List<string> listaMovimientos = new List<string>();
            bool continuar = true;

            Console.WriteLine("Bienvenido al Cajero Automático");
            Console.WriteLine();
            Console.WriteLine("Por favor, ingrese su NIP de 4 dígitos");
            userPin = Convert.ToInt32(Console.ReadLine());
            while (userPin != pin)
            {
                intentos--;
                if (intentos <= 0)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine();
                Console.WriteLine("NIP incorrecto,Por favor ingrese nuevamente su NIP de 4 dígitos. Te restan {0} intentos", (intentos).ToString());

                userPin = Convert.ToInt32(Console.ReadLine());
            }

            do
            {
                Console.WriteLine();
                Console.WriteLine("Por favor selecciona una opcion:");
                Console.WriteLine();
                Console.WriteLine("1 Consultar Saldo");
                Console.WriteLine("2 Retiro de Efectivo");
                Console.WriteLine("3 Consultar Movimientos");
                Console.WriteLine("4 Salir");
                opc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Tu saldo es: $" + userSaldo);
                        listaMovimientos.Add("Consulta de saldo ($" + userSaldo.ToString() + ") fecha: " + DateTime.Now);
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine("Ingresa la cantidad a retirar");
                        montoRetiro = Convert.ToInt32(Console.ReadLine());
                        if (montoRetiro > userSaldo)
                        {
                            Console.WriteLine("El monto de retiro debe ser menor a tu saldo actual (${0})", userSaldo.ToString());
                        }
                        else
                        {
                            userSaldo -= montoRetiro;
                            listaMovimientos.Add("Retiro de efectivo: ($" + montoRetiro.ToString() + ") fecha: " + DateTime.Now);
                            Console.WriteLine("Por favor retire el efectivo. Tu saldo actual es de ${0}", userSaldo.ToString());
                        }
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Estos son tus últimos movimientos:");
                        Console.WriteLine();
                        for (int i = listaMovimientos.Count - 1; i >= 0; i--)
                        {
                            Console.WriteLine(listaMovimientos[i]);
                            Console.WriteLine();
                        }
                        Console.ReadKey();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta, saliendo del sistema.");
                        Console.ReadKey();
                        break;
                }
                Console.WriteLine("¿Desea hacer mas movimientos? s/n");
                char res=Convert.ToChar(Console.ReadLine());
                if(res.ToString().ToLower() == "s")
                {
                    continuar = true;
                }
                else
                {
                    continuar = false;
                }

            } while (continuar);


        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asincrono_vaso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Problema:
               Si yo me emborracho con 2 Litros de cerveza y un vaso mide 6 cm de diámetro y 14 cm de altura. ¿Cuánto vasos 
               debo tomar para emborracharme? Sabiendo que la fórmula del volumen de un cilindro es V=πr2h. Donde el radio 
               es igual a r=d/2.
             */
            string res = "s";
            double Volumen = 0;
            string response = string.Empty;
            double litros = 0,cm3=0;
            Stopwatch timer = new Stopwatch();
            timer.Start();
            do
            {
               
                
                Console.WriteLine("Escribe el diametro del vaso en cm:");
                double diametro = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escribe la altura del vaso en cm:");
                double altura = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Escribe el tamaño en litros de la botella a servir:");
                litros = Convert.ToDouble(Console.ReadLine());
                Task.Run(async () =>
                {
                    try
                    {
                        Task<double> cilindro = VolumenCilindroAsync(diametro, altura);
                        Task<double> cm = ConvertirLaCM3(litros);
                        Volumen = await cilindro;
                        cm3 = await cm;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }).GetAwaiter().GetResult();
                if (cm3 <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Error.WriteLine("El valor de la conversion no puede ser 0");
                    continue;
                }
                try
                {
                    double resultado = Math.Ceiling(Volumen / cm3);
                    Console.WriteLine("Tiene que tomar {0} vasos", resultado);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Desea volver a ejecutar (S/N)");
                res = Console.ReadLine();
            } while (res == "s");
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
        }
        static async Task<double> VolumenCilindroAsync(double diametro, double altura, double pi = 3.1416)
        {
            if (diametro <= 0)
            {
                return 0;
            }
            else if (altura <= 0)
            {
                return 0;
            }
            else if (pi < 3.14)
            {
                return 0;
            }
            double volumen = pi * Math.Pow(diametro / 2, 2) * altura;
            return volumen;
        }
        static async Task<double> ConvertirLaCM3(double l)
        {
            if (l < 0)
            {
                return 0;
            }
            double conversion = l * 1000;
            return conversion;

        }
    }
}

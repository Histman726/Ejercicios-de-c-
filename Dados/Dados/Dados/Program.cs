using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            char res = 's';
            int dado = 0,contador=0;
            List<int> dadoConjunto = new List<int>(3);
            do
            {
                Console.WriteLine("El resultado de los tres dados");
                for(int i = 0; i < 3; i++)
                {
                    Task.Run(async () =>
                    {
                        var result = TirarDados();
                        dado = await result;
                        Console.WriteLine(dado);
                        dadoConjunto.Add(dado);
                    }).GetAwaiter().GetResult();
                }
                foreach (var i in dadoConjunto)
                {
                    if (i == 6)
                        contador++;
                }
                dadoConjunto.Clear();
                if (contador == 1)
                    Console.WriteLine("Regular");
                else if (contador == 2)
                    Console.WriteLine("Muy bien");
                else if (contador == 3)
                    Console.WriteLine("Excelente");
                else
                    Console.WriteLine("Pesimo");

                Console.WriteLine("¿Desea repetir el ciclo?");
                res = Convert.ToChar(Console.ReadLine());
            } while (res == 's');
        }
        static async Task<int> TirarDados()
        {
            Random ran = new Random();
            return ran.Next(1, 7);
        }
    }
}

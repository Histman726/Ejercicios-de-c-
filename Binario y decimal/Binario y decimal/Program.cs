using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binario_y_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un programa que convierte de decimal a binario y viceversa

            bool res = true;

            do
            {
                Console.WriteLine("Introduce un numero: ");
                var num=Convert.ToInt32(Console.ReadLine());
                var binario=DecimalBinario(num);
                Console.WriteLine("El numero binario es: "+binario);
                int decimalB = BinarioDecimal(binario);
                Console.WriteLine("El numero binario " + binario + " en decimal es " + decimalB);
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r = Convert.ToChar(Console.ReadLine());
                res = r.ToString().ToLower() == "s" ? true : false;
            } while (res);
        }
        public static long DecimalBinario(int num)
        {
            const int divisor = 2;
            long digito = 0, binario=0;

            for(int i = num % divisor, j = 0; num > 0; num /= divisor, i = num % divisor, j++)
            {
                digito = i % divisor;
                binario += digito * (long)Math.Pow(10, j);
            }
            return binario;
        }
        public static int BinarioDecimal(long bin)
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;

            for (long i = bin, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }

            return numero;
        }
    }
}

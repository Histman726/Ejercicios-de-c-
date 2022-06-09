using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decimal_a_octal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool res = true;

            do
            {
                Console.WriteLine("Introduce un numero: ");
                var num = Convert.ToInt32(Console.ReadLine());
                long octal = decimalOctal(num);
                long binario = DecimalBinario(num);
                Console.WriteLine("El numero decimal " + num + " en binario es " + binario);

                int decimalB = BinarioDecimal(binario);
                Console.WriteLine("El numero binario " + binario + " en decimal es " + decimalB);
                Console.WriteLine("El numero decimal " + num + " en octal es " + octal);

                int decimalO = octalDecimal(octal);
                Console.WriteLine("El numero octal " + binario + " en decimal es " + decimalO);

                String hexadecimal = decimalHexadecimal(num);
                Console.WriteLine("El numero decimal " + num + " en hexadecimal es " + hexadecimal);

                int decimalH = hexadecimalDecimal(hexadecimal);
                Console.WriteLine("El numero hexadecimal " + hexadecimal + " en decimal es " + decimalH);

            } while(res);
        }
        public static long DecimalBinario(int num)
        {
            const int divisor = 2;
            long digito = 0, binario = 0;

            for (int i = num % divisor, j = 0; num > 0; num /= divisor, i = num % divisor, j++)
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
        public static long decimalOctal(int numero)
        {

            long octal = 0;

            const int DIVISOR = 8;
            long digito = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                digito = i % DIVISOR;
                octal += digito * (long)Math.Pow(10, j);
            }


            return octal;
        }
        public static int octalDecimal(long octal)
        {

            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;

            for (long i = octal, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = (int)i % DIVISOR;
                if (!(digito >= 0 && digito <= 7))
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(8, j);
            }

            return numero;
        }
        public static String decimalHexadecimal(int numero)
        {

            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F' };

            String hexadecimal = "";

            const int DIVISOR = 16;
            long resto = 0;

            for (int i = numero % DIVISOR, j = 0; numero > 0; numero /= DIVISOR, i = numero % DIVISOR, j++)
            {
                resto = i % DIVISOR;
                if (resto >= 10)
                {
                    hexadecimal = letras[resto - 10] + hexadecimal;

                }
                else
                {
                    hexadecimal = resto + hexadecimal;
                }
            }


            return hexadecimal;


        }
        public static int hexadecimalDecimal(String hexadecimal)
        {

            int numero = 0;

            const int DIVISOR = 16;

            for (int i = 0, j = hexadecimal.Length - 1; i < hexadecimal.Length; i++, j--)
            {

                if (hexadecimal[i] >= '0' && hexadecimal[i] <= '9')
                {
                    numero += (int)Math.Pow(DIVISOR, j) * Convert.ToInt32(hexadecimal[i] + "");
                }
                else if (hexadecimal[i] >= 'A' && hexadecimal[i] <= 'F')
                {
                    numero += (int)Math.Pow(DIVISOR, j) * Convert.ToInt32((hexadecimal[i] - 'A' + 10) + "");
                }
                else
                {
                    return -1;
                }

            }

            return numero;

        }
    }
}

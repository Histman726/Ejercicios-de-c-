using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restar_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Declarar la variable añoNacimiento del humano y la variable añoActual que nos entregará automáticamente la 
             *   máquina con el objeto DateTime.Now.Year.
                 - Restar el año actual añoActual al añoNacimiento y obtener la edad del humano.
             */

            int AñoActual = DateTime.Now.Year;
            try
            {
                Console.WriteLine("-----PRIMER SOBRECARGA-------");
                Console.WriteLine("Escribe el año de tu nacimiento");
                int añoNacimiento = Convert.ToInt32(Console.ReadLine());
                dynamic res = RestarFechas(AñoActual, añoNacimiento);
                Console.WriteLine($"El resultado de la resta es {res}");
                Console.WriteLine("------SEGUNDA SOBRECARGA------");
                Console.WriteLine("Escribe una fecha valida en formato MM / dd / yyyy");
                DateTime nacimiento = new DateTime();
                nacimiento = DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                res = RestarFechas(nacimiento, AñoActual);
                Console.WriteLine($"El resultado de la resta es {res}");
                Console.WriteLine("-----TERCER SOBRECARCA-------");
                Console.WriteLine("Escribe una fecha valida en formato MM / dd / yyyy");
                nacimiento= DateTime.ParseExact(Console.ReadLine(), "MM/dd/yyyy", CultureInfo.InvariantCulture);
                DateTime hoy = DateTime.Now;
                res = RestarFechas(hoy, nacimiento);
                Console.WriteLine($"El resultado de la resta es {res}");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

        }
        static dynamic RestarFechas(int actual,int añoNaci)
        {
            if (añoNaci >= actual)
                return string.Format($"El valor de nacimiento {añoNaci} es mayor a {actual}");
            return actual - añoNaci;
        }
        static dynamic RestarFechas(DateTime hoy, int añoNaci)
        {
            if(hoy.Year>=añoNaci)
                return string.Format($"El valor de nacimiento {añoNaci} es mayor a {hoy.Year}");
            return añoNaci-hoy.Year;
        }
        static dynamic RestarFechas(DateTime hoy, DateTime nacer)
        {
            if (nacer >= hoy)
                return string.Format($"El valor de nacimiento {nacer.ToString("MM/dd/yyyy")} es mayor a {hoy.ToString("MM / dd / yyyy")}");
            dynamic res = hoy.Year - nacer.Year;
            return res;
        }
    }
}

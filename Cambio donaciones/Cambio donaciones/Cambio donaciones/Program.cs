using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cambio_donaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Calcule la venta de 3 productos de una tienda 
-                Pregunte si deseamos donar los centavos.
                - Si se acepta el redondeo agradecer por el redondeo y mostrarlo.
                - Si no acepta pues ni modo no hacer nada.
             */
            char res = 's',donacion='s';
            decimal result = 0;
            do
            {
                Console.WriteLine("Escriba el precio del producto 1");
                decimal pro1 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Escriba el precio del producto 2");
                decimal pro2 = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Escriba el precio del producto 3");
                decimal pro3 = Convert.ToDecimal(Console.ReadLine());
                Task.Run(async () =>
                {
                    var eje = SumarProductos(pro1,pro2,pro3);
                    decimal? suma = await eje;
                    Console.WriteLine("Serian "+ suma);
                    Console.WriteLine("¿Desea redondear centavos?");
                    donacion = Convert.ToChar(Console.ReadLine());
                    if (donacion == 's')
                    {
                        result=Math.Ceiling((decimal)suma);
                        Console.WriteLine("Gracias por donar");
                        Console.WriteLine("Su nuevo total es "+result);
                    }
                    else
                    {
                        Console.WriteLine("Gracias por comprar");
                    }
                    
                }).GetAwaiter().GetResult();
                Console.WriteLine("¿Desea volver a compar mas productos?");
                res = Convert.ToChar(Console.ReadLine());
            } while (res=='s');
        }
        static async Task<decimal?> SumarProductos(decimal producto1,decimal p2,decimal p3)
        {
            if (producto1 <= 0 || p2<=0 || p3<=0)
                return null;
            decimal res = producto1 + p2 + p3;
            return res;
        }
    }
}

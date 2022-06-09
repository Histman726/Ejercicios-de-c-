using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_coche
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Coche coche=new Coche(1,"Chevrolet","0152",35,3500);

            Console.WriteLine(coche);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Random_numeros
{
    public class Aleatorio
    {
        public Random NumAlea { get; set; }

        public Aleatorio()
        {
            NumAlea = new Random();
        }
        public int GenerarNumero(int min,int max)
        {
            if(min < max)
                return NumAlea.Next(min,max+1);
            else
                return 0;
        }
        public int[] GenerarNumeroAleotorios(int longitud,int min, int max)
        {
            if(longitud < 1)
            {
                return null;
            }
            else
            {
                int[] result = new int[longitud];
                for(int i = 0; i < result.Length; i++)
                {
                    result[i] = GenerarNumero(min, max);
                }
                return result;
            }
            

        }
    }
}

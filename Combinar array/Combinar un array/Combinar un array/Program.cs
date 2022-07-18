using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinar_un_array
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Declararemos 3 arreglos a,b y c donde a y b tendrán un tamaño de 5 y c tendrá un tamaño de 10.
                - Crearemos dos bucles de 0 a 4 donde pediremos al humano que ingrese los valores del arreglo “a” y “b” respectivamente.
                - Con un tercer bucle llenaremos el tercer arreglo “c” que contendrá la combinación de a y b.
                - Mostraremos el arreglo “c”.
             */
            int[] a = new int[5];
            int[] b = new int[5];
            int[] c = new int[10];

            for(int i = 0; i < 5; i++)
            {
                a[i]=int.Parse(Interaction.InputBox("Ingresa el elemento en el arreglo a en la posicion "+(i+1)));
            }
            for (int i = 0; i < 5; i++)
            {
                b[i] = int.Parse(Interaction.InputBox("Ingresa el elemento en el arreglo b en la posicion " + (i + 1)));
            }
            int j = 0;
            for (int i = 0; i <5; i++)
            {
                c[j] = a[i];
                j++;
                c[j] = b[i];
                j++;
            }
            string arreglo = "";
            foreach(int n in c)
            {
                arreglo +="\n" +n;
            }
            Interaction.MsgBox(arreglo);
        }
    }
}

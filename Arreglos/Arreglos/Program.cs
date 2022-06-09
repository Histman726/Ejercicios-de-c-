using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Crear un programa que te muestre un menu donde las opciones sean 1. Mostrar el array 2. Sumarlo
            3. Promediarlo
            -Opcional: Que el array sea rellenado por el usuario
            */
            bool res = true;
            int option = 0,relleno=0;

            do
            {
                Console.WriteLine("Escriba el tamaño del arreglo");
                relleno=Convert.ToInt32(Console.ReadLine());
                var array=new int[relleno];
                Console.WriteLine("Introduzca cada uno de los elementos del array");
                RellenarArray(array);
                Console.WriteLine("Menu\n 1. Mostrar array\t2. Sumar array\t3. Promedio array");
                option=Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1: 
                        Console.WriteLine("El array es: \n");
                        MostrarArray(array);
                        break;
                    case 2:
                        Console.WriteLine("La suma del array es: \n");
                        var suma=SumarArray(array);
                        Console.WriteLine(suma.ToString());
                        break;
                    case 3:
                        Console.WriteLine("El promedio del array es: \n");
                        var prom=PromedioArray(array);
                        Console.WriteLine(prom.ToString());
                        break ;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break ;
                }
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r = Convert.ToChar(Console.ReadLine());
                res = r.ToString().ToLower() == "s" ? true : false;
            } while (res);
            Console.ReadKey();
        }
        public static void MostrarArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
        public static int SumarArray(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                sum+=i;
            }
            return sum;
        }
        public static double PromedioArray(int[] array)
        {
            int suma=SumarArray(array);
            var pro=Convert.ToDouble(suma/array.Length);
            return pro;
        }
        public static void RellenarArray(int[] array)
        {
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Escriba el numero en el lugar {0}", i + 1);
                var numero = Convert.ToInt32(Console.ReadLine());
                array[i] = numero;
            }
        }
    }
}

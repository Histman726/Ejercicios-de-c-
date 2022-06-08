using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calificaciones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            El reto es poder crear una aplicacion de consola que te registre un conjunto de 
            calificaciones de N alumnos e imprime en pantalla el alumno con peor y mejor
            promedio
            */
            int alumnos = 0;
            Console.WriteLine("Ingrese la cantidad de alumnos a calificar:");
            alumnos=Convert.ToInt32(Console.ReadLine());
            decimal[,] calificaciones=new decimal[alumnos,2];
            Console.WriteLine();


            for(int i = 0; i <= alumnos-1; i++)
            {
                Console.WriteLine("La calificacion del alumno {0} es:",(i+1));
                calificaciones[i,0] = Convert.ToDecimal(Console.ReadLine());//Calificacion
                calificaciones[i,1] = (i+1);//Alumno
                Console.WriteLine();
            }

            //Obtener alumno con mejor promedio
            decimal calificacion = 0;
            decimal alumno=0;
            for(int i = 0; i <= alumnos-1; i++)
            {
                if (calificaciones[i, 0] > calificacion)
                {
                    calificacion = calificaciones[i, 0];
                    alumno = calificaciones[i, 1] = (i+1);
                }
            }

            Console.WriteLine("El alumno con el mejor promedio es #{0} con una calificacion de {1}",alumno.ToString(),calificacion.ToString());
            Console.WriteLine();

            calificacion = 10;
            alumno = 0;
            for(int i = 0; i <= alumnos-1; i++)
            {
                if(calificaciones[i, 0] < calificacion)
                {
                    calificacion=calificaciones[i, 0];
                    alumno=calificaciones[i, 1] = (i+1);
                }
            }
            Console.WriteLine("El alumno con menor calificacion es #{0} con calificacion {1}",alumno.ToString(),calificacion.ToString());
            Console.ReadKey();
        }
    }
}

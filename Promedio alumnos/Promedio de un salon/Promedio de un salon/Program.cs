using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_de_un_salon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa la cantidad de alumnos");
            int alumnos = int.Parse(Console.ReadLine());
            Alumno[] alum = new Alumno[alumnos];
            List<Alumno> alumnos1 = new List<Alumno>(alumnos);

            for(int i=0; i < alumnos; i++)
            {
                Console.WriteLine("Ingresa el nombre del alumno" + (i + 1));
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingresa la calificacion del alumno" + (i + 1));
                double calif = double.Parse( Console.ReadLine());
                Console.WriteLine("Ingresa el aula del alumno" + (i + 1));
                char aulaAlumnos = char.Parse( Console.ReadLine());
                alum[i] = new Alumno(nombre, calif, aulaAlumnos);
                alumnos1.Add(new Alumno(nombre,calif,aulaAlumnos));
            }

            double suma = 0,promedio=0;
            int Salon = 0;
            Console.WriteLine("De que aula quieres promediar las calificaciones");
            char aula = char.Parse(Console.ReadLine());
            for(int i = 0; i < alumnos; i++)
            {
                if (aula == alum[i].GetAula())
                {
                    suma += alum[i].GetCalif();
                    Salon++;
                }
            }
            promedio = suma / Salon;
            Console.WriteLine("El promedio de los alumnos del salon {0} es {1}", aula, promedio);
            Console.ReadKey();
        }
    }
}

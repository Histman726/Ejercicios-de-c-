using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_Promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * - Declaramos un arreglo de tipo doble con un tamaño de 4 elementos.
                - Crearemos un bucle que se puede romper cuando lleguemos a 4 ciclos o cuando el humano de click en cancelar, mientras el bucle se escte ciclando vamos a hacer lo siguiente:
                - Convertimos las calificaciones de texto a double.
                - Validamos que se haya dado cancelar para romper el bucle de lo contrario continuamos.
                - Almacenamos las calificaciones.
                - Sumamos las calificaciones y las promediamos.
                - Mostramos el promedio de calificaciones del alumno.
             */

            double[] calificaciones = new double[4];
            int semestres = 0;
            double suma = 0,promedio=0;

            do
            {
                string Calificion = Interaction.InputBox("Ingresa la calificacion del semestre: " + (semestres+1));
                if (Calificion == string.Empty)
                    break;
                else
                {
                    double calificacionString = double.Parse(Calificion);
                    calificaciones[semestres] = calificacionString;
                    semestres++;
                }
                    
            } while (semestres<4);
            if (semestres > 0)
            {
                foreach (double cal in calificaciones)
                {
                    suma += cal;
                }
                promedio = suma / semestres;
                Interaction.MsgBox(promedio);
            }
            else
            {
                Interaction.MsgBox("Debe ingresal al menos un semestre");
            }
        }
    }
}

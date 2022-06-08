using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dias_de_la_semana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string diaNombre=string.Empty;
            int opcion=0, diaNum = 0;
            bool res = true;

            do
            {
                Console.WriteLine("Escriba la accion a hacer");
                Console.WriteLine("Menu: \n 1. Convertir de numero a dia\t2. Convertir de dia a numero\t3. Decir si es o no fin de semana");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Escriba el numero del dia");
                        diaNum = Convert.ToInt32(Console.ReadLine());
                        if (diaNum < 7)
                        {
                            if (diaNum == 1)
                            {
                                diaNombre = "Lunes";
                            }
                            else if (diaNum == 2)
                            {
                                diaNombre = "Martes";
                            }
                            else if (diaNum == 3)
                            {
                                diaNombre = "Miercoles";
                            }
                            else if (diaNum == 4)
                            {
                                diaNombre = "Jueves";
                            }
                            else if (diaNum == 5)
                            {
                                diaNombre = "Viernes";
                            }
                            else if (diaNum == 6)
                            {
                                diaNombre = "Sabado";
                            }
                            else if (diaNum == 7)
                            {
                                diaNombre = "Domingo";
                            }
                            Console.WriteLine("El dia es: " + diaNombre);
                        }
                        else
                        {
                            Console.WriteLine("Numero de dia invalido");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre del dia (Por favor la primera letra mayuscula y las demas minusculas sin acento)");
                        diaNombre=Console.ReadLine();
                        if (diaNombre == "Lunes")
                        {
                            diaNum=1;
                            Console.WriteLine("El #dia es: " + diaNum.ToString());
                        }
                        else if (diaNombre == "Martes")
                        {
                            diaNum = 2;
                            Console.WriteLine("El #dia es: " + diaNum.ToString());
                        }
                        else if (diaNombre == "Miercoles")
                        {
                            diaNum = 3;
                            Console.WriteLine("El #dia es: " + diaNum.ToString());
                        }
                        else if (diaNombre == "Jueves")
                        {
                            diaNum = 4;
                            Console.WriteLine("El #dia es: " + diaNum.ToString());
                        }
                        else if (diaNombre == "Viernes")
                        {
                            diaNum = 5;
                            Console.WriteLine("El #dia es: " + diaNum.ToString());
                        }
                        else if (diaNombre == "Sabado")
                        {
                            diaNum = 6;
                            Console.WriteLine("El #dia es: " + diaNum.ToString());
                        }
                        else if (diaNombre == "Domingo")
                        {
                            diaNum = 7;
                            Console.WriteLine("El #dia es: " + diaNum.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Nombre del dia invalido");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Inserte el numero del dia");
                        diaNum=Convert.ToInt32(Console.ReadLine());
                        if (diaNum>5)
                        {
                            Console.WriteLine("Es fin de semana");
                        }
                        else
                        {
                            Console.WriteLine("Es dia de trabajar");
                        }
                        break;
                    default:
                        Console.WriteLine("Valor invalido");
                        break;
                }
                Console.WriteLine("¿Desea volver al menu?s/n");
                char r = Convert.ToChar(Console.ReadLine());
                res = r.ToString().ToLower() == "s" ? true : false;
            } while (res);

        }
    }
}

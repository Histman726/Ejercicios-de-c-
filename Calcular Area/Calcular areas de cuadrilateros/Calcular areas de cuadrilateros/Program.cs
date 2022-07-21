
using System;

namespace Calcular_areas_de_cuadrilateros
{
    class Program
    {
        static void Main(string[] args)
        {
            double lado1 = 0, lado2 = 0, lado3 = 0;
            Cuadrilateros fig = new Cuadrilateros();

            Console.WriteLine("¿De que cuadrilatero desea cualcular el area?\n\t1. Cuadrado\n\t2. Rectangulo\n\t3. Rombo\n\t4. Trapecio\n\t5. Salir");
            int op = int.Parse(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.WriteLine("Usted va a calcular el area de un cuadrado");
                    Console.WriteLine("Lado: ");
                    lado1 = double.Parse(Console.ReadLine());
                    fig = new Cuadrado(lado1);
                    break;
                case 2:
                    Console.WriteLine("Usted va a calcular el area de un rectangulo");
                    Console.WriteLine("Lado: ");
                    lado1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Lado 2: ");
                    lado2 = double.Parse(Console.ReadLine());
                    fig = new Rectangulo(lado1, lado2);
                    break;
                case 3:
                    Console.WriteLine("Usted va a calcular el area de un rombo");
                    Console.WriteLine("Diametro menor: ");
                    lado1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Diametro mayor: ");
                    lado2 = double.Parse(Console.ReadLine());
                    fig = new Rombo(lado1, lado2);
                    break;
                case 4:
                    Console.WriteLine("Usted va a calcular el area de un trapecio");
                    Console.WriteLine("Altura: ");
                    lado1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base menor: ");
                    lado2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Base mayor: ");
                    lado3 = double.Parse(Console.ReadLine());
                    fig = new Trapecio(lado1, lado2, lado3);
                    break;
                default:
                    Environment.Exit(0);
                    break;
            }
            Console.WriteLine("El area de la figura seleccionada es: " + fig.Area());
        }
    }
}

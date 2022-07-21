namespace Calcular_areas_de_cuadrilateros
{
    public class Cuadrado : Cuadrilateros
    {
        public Cuadrado(double lado)
        {
            Lado1 = lado;
        }

        public override double Area()
        {
            return Lado1 * Lado1;
        }
    }
}

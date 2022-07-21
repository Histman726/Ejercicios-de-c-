namespace Calcular_areas_de_cuadrilateros
{
    public class Cuadrilateros
    {
        public double Lado1 { get; set; }
        public double Lado2 { get; set; }

        public virtual double Area() => Lado2 * Lado1;
    }
}

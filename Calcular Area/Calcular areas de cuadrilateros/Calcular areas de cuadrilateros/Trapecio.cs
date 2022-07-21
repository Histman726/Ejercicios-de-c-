namespace Calcular_areas_de_cuadrilateros
{
    public class Trapecio : Cuadrilateros
    {
        public double Superior { get; set; }
        public Trapecio(double altura, double inferior, double superior)
        {
            Lado1 = altura;
            Lado2 = inferior;
            Superior = superior;
        }
        public override double Area()
        {
            return ((Superior + Lado2) * Lado1) / 2;
        }
    }
}

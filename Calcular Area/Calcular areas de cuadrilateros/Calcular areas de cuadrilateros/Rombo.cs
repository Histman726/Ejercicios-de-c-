namespace Calcular_areas_de_cuadrilateros
{
    public class Rombo : Cuadrilateros
    {
        public Rombo(double diametroMe, double diametroMay)
        {
            Lado1 = diametroMe;
            Lado2 = diametroMay;
        }
        public override double Area()
        {
            return (Lado2 * Lado1) / 2;
        }
    }
}

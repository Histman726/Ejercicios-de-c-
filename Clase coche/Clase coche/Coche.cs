using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_coche
{
    public class Coche
    {
        public int ID { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public double Km { get; set; }
        public decimal Precio { get; set; }

        public Coche(int iD, string marca, string modelo, double km, decimal precio)
        {
            ID = iD;
            Marca = marca;
            Modelo = modelo;
            Km = km;
            Precio = precio;
        }

        public Coche()
        {
        }

        public override string ToString()
        {
            return "Id: " + ID + ", Marca: " + Marca + ", Modelo: " + Modelo + ", Km: " + Km + ", Precio: " + Precio;
        }
    }
}

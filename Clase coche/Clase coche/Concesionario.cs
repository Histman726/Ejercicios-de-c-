using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_coche
{
    public class Concesionario
    {
        public Coche[] Coches { get; set; }
        public int Limite { get; set; }
        public int NumCoches { get; set; }

        public Concesionario(int limite)
        {
            this.Coches=new Coche[limite];
            this.Limite = limite;
            this.NumCoches=0;
        }
        public void AñadirCoche(Coche c)
        {
            if (c != null && this.NumCoches<Coches.Length)
            {
                Coches[this.NumCoches] = c;
                NumCoches++;
            }
        }
        public void MostrarCoche()
        {
            for (int i = 0; i < NumCoches; i++)
            {
                Console.WriteLine(Coches[i]);
            }
        }
        public void VaciarCoche()
        {
            Coches=new Coche[Limite];
        }
        public void EliminarCoche(Coche c)
        {
            if(c != null && this.NumCoches !=0)
            {
                int position=0;
                for(int i = 0; i < NumCoches; i++)
                {
                    if(c.ID == Coches[i].ID)
                    {
                        position=i;
                    }
                }
                if(position <= 0)
                {
                    Console.WriteLine("El coche no existe");
                }
                else
                {
                    Coches[position] = null;
                    for(int i = position; i < NumCoches; i++)
                    {
                        Coches[i] = Coches[i + 1];
                    }
                    NumCoches--;
                }
            }
        }
    }
}

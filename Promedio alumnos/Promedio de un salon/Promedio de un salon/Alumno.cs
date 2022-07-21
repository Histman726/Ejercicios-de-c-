using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio_de_un_salon
{
    class Alumno
    {
        private string _nombre;
        private double _calificacion;
        private char _aula;

        public Alumno(string nombre,double calificacion,char aula)
        {
            if (calificacion > 10)
                calificacion = 10;
            else if (calificacion < 0)
                calificacion = 0;
            else
                _calificacion = calificacion;
            _nombre = nombre;
            _aula = aula;
        }

        public string GetNombre()
        {
            return _nombre;
        }

        public double GetCalif()
        {
            return _calificacion;
        }

        public char GetAula()
        {
            return _aula;
        }
    }
}

using Escuela.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela.Services
{
    internal static class AlumnosIngreso
    {
        public static List<Grado> ListarGrado()
        {
            try
            {
                using (EscuelaEntities db = new EscuelaEntities())
                {
                    var grado = db.Grado.ToList();
                    return grado;
                }
            }
            catch
            {
                return new List<Grado>();
            }
        }
        public static List<Nivel> ListarNivel()
        {
            try
            {
                using (EscuelaEntities db = new EscuelaEntities())
                {
                    var nivel = db.Nivel.ToList();
                    return nivel;
                }
            }
            catch
            {
                return new List<Nivel>();
            }
        }
        public static bool Inscribir(Alumnos a)
        {
            try
            {
                using (EscuelaEntities db = new EscuelaEntities())
                {
                    db.Alumnos.Add(a);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        public static bool Reinscribir(Alumnos a)
        {
            try
            {
                using (EscuelaEntities db = new EscuelaEntities())
                {

                    db.Entry(a).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}

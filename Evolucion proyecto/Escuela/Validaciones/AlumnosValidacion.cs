using Escuela.Models;
using Escuela.Services;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela.Validaciones
{
    internal static class AlumnosValidacion
    {
        public static bool ValidarAlumno(Alumnos a)
        {
            if (a.NombreAlumno.Length > 0 && a.cveGrado > 0 && a.cveNivel > 0)
            {
                using (EscuelaEntities db = new EscuelaEntities())
                {
                    var res = db.Alumnos.Where<Alumnos>(A => A.NombreAlumno == a.NombreAlumno).ToList();

                    if (res.Count == 0)
                        AlumnosIngreso.Inscribir(a);
                    else
                        AlumnosIngreso.Reinscribir(a);
                }
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}

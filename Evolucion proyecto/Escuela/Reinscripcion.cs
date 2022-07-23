using Escuela.Models;
using Escuela.Services;
using Escuela.Validaciones;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Escuela
{
    public partial class Reinscripcion : Form
    {
        public Reinscripcion()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Alumnos alumno = new Alumnos();
            alumno.NombreAlumno = txtNombre.Text;
            alumno.cveGrado = Convert.ToInt32(cmbGrado.SelectedValue);
            alumno.cveNivel = Convert.ToInt32(cmbNivel.SelectedValue);
            bool al = AlumnosValidacion.ValidarAlumno(alumno);
            if (al)
                MessageBox.Show("Alumno reinscrito");
            else
                MessageBox.Show("Error al escribir un dato");
            this.Hide();
        }

        private void Reinscripcion_Load(object sender, EventArgs e)
        {
            var grado = AlumnosIngreso.ListarGrado();
            cmbGrado.DataSource = grado;
            cmbGrado.ValueMember = "IdGrado";
            cmbGrado.DisplayMember = "Numero";
            var nivel = AlumnosIngreso.ListarNivel();
            cmbNivel.DataSource = nivel;
            cmbNivel.ValueMember = "IdNivel";
            cmbNivel.DisplayMember = "NombreNivel";
        }
    }
}

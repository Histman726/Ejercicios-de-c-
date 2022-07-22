using Microsoft.VisualBasic;

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
    public partial class Un_Salon_Promedio : Form
    {
        private int _alumnos = 0;
        public Un_Salon_Promedio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _alumnos = Convert.ToInt32(txtCantidad.Text);
            List<double> promedio = new List<double>(_alumnos);
            for (int i = 0; i < _alumnos; i++)
            {
                double calif = double.Parse(Interaction.InputBox("Ingrese la calificacion del alumno " + (i + 1)));
                promedio.Add(calif);
            }
            lblPromedio.Text = promedio.Average().ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.Show();
            this.Hide();
        }
    }
}

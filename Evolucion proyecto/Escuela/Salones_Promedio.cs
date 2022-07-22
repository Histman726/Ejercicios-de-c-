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
    public partial class Salones_Promedio : Form
    {
        private int _contador = 0;
        public Salones_Promedio()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            _contador = int.Parse(txtCantidad.Text);
            List<double> salones = new List<double>(_contador);
            for (int i = 0; i < _contador; i++)
            {
                double salon = double.Parse(Interaction.InputBox("Ingrese el valor del salon " + (i + 1)));
                salones.Add(salon);
            }
            lblPromedio.Text = salones.Average().ToString();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
    }
}

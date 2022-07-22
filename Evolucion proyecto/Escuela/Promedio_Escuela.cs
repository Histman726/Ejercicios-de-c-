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
    public partial class Promedio_Escuela : Form
    {
        private int contadorAlumnos = 0;
        private List<double> promedios = new List<double>();
        private int contadorSalones = 1;
        public Promedio_Escuela()
        {
            InitializeComponent();
        }

        private void Promedio_Escuela_Load(object sender, EventArgs e)
        {
            txtSalones.Enabled = false;
            btnSalones.Enabled = false;
            btnAgregar.Enabled = false;
            lblPromedios.Hide();
        }

        private void btnPromediar2_Click(object sender, EventArgs e)
        {
            contadorAlumnos = int.Parse(txtAlumnos.Text);
            List<double> prom = new List<double>(contadorAlumnos);
            for (int i = 0; i < contadorAlumnos; i++)
            {
                double nota = double.Parse(Interaction.InputBox("Ingrese la nota del alumno " + (i + 1)));
                prom.Add(nota);
            }
            lblPromedioAlumnos.Text = prom.Average().ToString("0.00");
            promedios.Add(prom.Average());
            txtAlumnos.Enabled = false;
            btnAgregar.Enabled = true;
            btnSalones.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            txtAlumnos.Enabled = true;
            contadorSalones++;
        }

        private void btnSalones_Click(object sender, EventArgs e)
        {
            txtSalones.Enabled = true;
            txtSalones.Text = contadorSalones.ToString();
            lblPromedioSalones.Text = promedios.Average().ToString("0.00");
            var res = MessageBox.Show("¿Desea ver el promedio de cada salon?", null, MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                lblPromedios.Show();
                for (int i = 0; i < contadorSalones; i++)
                {
                    lblPromedios.Text = lblPromedios.Text + "\n" + "Salon " + (i + 1) + " : " + promedios[i].ToString("0.00");
                }
            }
            btnSalones.Enabled = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Menu men = new Menu();
            men.Show();
            this.Hide();
        }
    }
}

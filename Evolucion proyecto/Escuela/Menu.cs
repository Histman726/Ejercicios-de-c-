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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnEscuelas_Click(object sender, EventArgs e)
        {

        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inscripcion ins = new Inscripcion();
            ins.ShowDialog();
        }

        private void reinscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reinscripcion reinscripcion = new Reinscripcion();
            reinscripcion.ShowDialog();
        }

        private void salonesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salones_Promedio salon = new Salones_Promedio();
            salon.Show();
            this.Hide();
        }

        private void unSalonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Un_Salon_Promedio salon = new Un_Salon_Promedio();
            salon.Show();
            this.Hide();
        }

        private void escuelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Promedio_Escuela pro = new Promedio_Escuela();
            pro.Show();
            this.Hide();
        }
    }
}

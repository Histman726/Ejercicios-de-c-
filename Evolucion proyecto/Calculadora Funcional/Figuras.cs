using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Funcional
{
    public partial class Figuras : Form
    {
        double Area = 0, Per = 0, dato1 = 0, dato2 = 0, dato3 = 0, dato4 = 0, dato5 = 0;
        public Figuras()
        {
            InitializeComponent();
        }

        public void FigurasTipo(object sender, EventArgs e)
        {
            if (rdbPoligono.Checked || rdbTrapecio.Checked || rdbRombo.Checked)
            {
                txtDato3.Enabled = true;
                if (rdbTrapecio.Checked)
                {
                    txtDato4.Enabled = true;
                    txtDato5.Enabled = true;
                }
                else
                {
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                }
            }
            else
            {
                if (rdbCuadrado.Checked)
                {
                    txtDato2.Enabled = false;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                }
                else
                {
                    txtDato2.Enabled = true;
                    txtDato3.Enabled = false;
                    txtDato4.Enabled = false;
                    txtDato5.Enabled = false;
                }
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                dato1 = Convert.ToDouble(txtDato1.Text);
                if (!rdbCuadrado.Checked)
                    dato2 = Convert.ToDouble(txtDato2.Text);
            }
            catch
            {
                MessageBox.Show("Falta llenar algun campo");
            }

            if (dato1 == 0 || dato2 == 0)
            {
                if (rdbCuadrado.Checked)
                {
                    if (dato1 == 0)
                        MessageBox.Show("Debe completar los campos de dato 1");
                }
                else
                    MessageBox.Show("Debe completar los campos de dato 1 y 2");
            }
            else if ((rdbPoligono.Checked || rdbTrapecio.Checked || rdbRombo.Checked))
            {
                try
                {
                    dato3 = Convert.ToDouble(txtDato3.Text);
                    if (rdbTrapecio.Checked)
                    {
                        dato4 = Convert.ToDouble(txtDato4.Text);
                        dato5 = Convert.ToDouble(txtDato5.Text);
                        if (dato3 == 0 || dato4 == 0 || dato5 == 0)
                            MessageBox.Show("Debe completar los campos de dato 3, 4 y 5");
                    }
                    if (dato3 == 0)
                        MessageBox.Show("Debe completar los campos de dato 3");
                }
                catch
                {
                    MessageBox.Show("Falta llenar algun campo de los posibles");
                }

            }

            if (rdbCuadrado.Checked)
            {
                Area = dato1 * dato1;
                Per = dato1 * 4;
            }
            else if (rdbRect.Checked)
            {
                if (dato1 != dato2)
                {
                    Area = dato1 * dato2;
                    Per = dato1 * 2 + dato2 * 2;
                }
                else
                {
                    MessageBox.Show("Usted no estara buscando el area de un cuadrado");
                }
            }
            else if (rdbTriangulo.Checked)
            {
                Area = (dato1 * dato2) / 2;
                Per = dato1 + dato2 + dato3;
            }
            else if (rdbTrapecio.Checked)
            {
                if (dato1 == dato2)
                    MessageBox.Show("Creo que no estas calculando el area de un trapecio");
                else
                {
                    Area = ((dato1 + dato2) / 2) * dato3;
                    Per = dato1 + dato2 + dato4 + dato5;
                }
            }
            else if (rdbPoligono.Checked)
            {
                Per = dato1 * dato2;
                Area = (Per * dato3) / 2;
            }
            else if (rdbCirculo.Checked)
            {
                Area = Math.PI * dato1 * dato1;
                if (dato1 * 2 == dato2)
                    Per = Math.PI * dato2;
                else
                    MessageBox.Show("El diametro debe ser el doble del radio");
            }
            else if (rdbOvalo.Checked)
            {
                if (dato1 <= dato2)
                    MessageBox.Show("El radio mayor debe ser mas grande que el radio menor");
                else
                {
                    Area = Math.PI * dato1 * dato2;
                    Per = 2 * Math.PI * Math.Sqrt((dato1 * dato1 + dato2 * dato2) / 2);
                }
            }
            else if (rdbRombo.Checked)
            {
                if (dato1 <= dato2)
                    MessageBox.Show("El diagonal mayor debe ser mas grande que el diagonal menor");
                else
                {
                    Area = (dato1 * dato2) / 2;
                }
                Per = dato3 * 4;
            }
            else
                MessageBox.Show("No selecciono ninguna figura");
            txtResArea.Text += Area.ToString("0.00");
            txtResPerimetro.Text += Per.ToString("0.00");
            txtDato1.Clear();
            txtDato2.Clear();
            txtDato3.Clear();
            txtDato4.Clear();
            txtDato5.Clear();
        }
    }
}

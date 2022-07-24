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
    public partial class Estandar : Form
    {
        double num1 = 0, num2 = 0;
        char operador = ' ';
        public Estandar()
        {
            InitializeComponent();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            var boton = ((Button)sender);
            num1 = Convert.ToDouble(txtRes.Text);
            operador = Convert.ToChar(boton.Text);
            txtRes.Text = "0";
        }

        private void AgregarNumero(object sender, EventArgs e)
        {
            var boton = ((Button)sender);

            if (txtRes.Text == "0")
                txtRes.Text = "";

            txtRes.Text += boton.Text;
        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            num2 = Convert.ToDouble(txtRes.Text);

            if (operador == '+')
            {
                txtRes.Text = (num1 + num2).ToString();
                num1 = Convert.ToDouble(txtRes.Text);
            }
            else if (operador == '-')
            {
                txtRes.Text = (num1 - num2).ToString();
                num1 = Convert.ToDouble(txtRes.Text);
            }
            else if (operador == 'x')
            {
                txtRes.Text = (num1 * num2).ToString();
                num1 = Convert.ToDouble(txtRes.Text);
            }
            else if (operador == '÷')
            {
                if (txtRes.Text != "0")
                {
                    txtRes.Text = (num1 / num2).ToString();
                    num1 = Convert.ToDouble(txtRes.Text);
                }
                else
                {
                    MessageBox.Show("No se puede dividir por cero!");
                }
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (txtRes.Text.Length > 1)
            {
                txtRes.Text = txtRes.Text.Substring(0, txtRes.Text.Length - 1);
            }
            else
            {
                txtRes.Text = "0";
            }
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            txtRes.Text = "0";
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtRes.Text = "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            if (!txtRes.Text.Contains("."))
            {
                txtRes.Text += ".";
            }
            else
            {
                MessageBox.Show("Un numero no puede tener mas de un punto decimal.");
            }
        }

        private void btnSuma(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtRes.Text);
            operador = '+';
            txtRes.Text = "0";
        }
        private void btnResta(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtRes.Text);
            operador = '-';
            txtRes.Text = "0";
        }
        private void btnMulti_Short(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtRes.Text);
            operador = 'x';
            txtRes.Text = "0";
        }

        private void figurasGometricasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDiv_Short(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(txtRes.Text);
            operador = '÷';
            txtRes.Text = "0";
        }
    }
}

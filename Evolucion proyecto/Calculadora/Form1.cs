namespace Calculadora
{
    public partial class frmBasica : Form
    {
        private double num1 = 0;
        private double num2 = 0;
        private char operador;
        public frmBasica()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "9";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = '+';
            txtRes.Text = txtRes.Text + "+";
            num1 = Convert.ToDouble(txtRes.Text.Substring(0, txtRes.Text.Length - 1));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            operador = '-';
            txtRes.Text = txtRes.Text + "-";
            num1 = Convert.ToDouble(txtRes.Text.Substring(0, txtRes.Text.Length - 1));
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            operador = 'x';
            txtRes.Text = txtRes.Text + "x";
            num1 = Convert.ToDouble(txtRes.Text.Substring(0, txtRes.Text.Length - 1));
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = '÷';
            txtRes.Text = txtRes.Text + "÷";
            num1 = Convert.ToDouble(txtRes.Text.Substring(0, txtRes.Text.Length - 1));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(txtRes.Text.Split(operador)[1]);
            switch (operador)
            {
                case '+':
                    txtRes.Text = (num1 + num2).ToString();
                    break;
                case '-':
                    txtRes.Text = (num1 - num2).ToString();
                    break;
                case 'x':
                    txtRes.Text = (num1 * num2).ToString();
                    break;
                case '÷':
                    txtRes.Text = (num1 / num2).ToString();
                    break;
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtRes.Text == "0")
                txtRes.Clear();
            txtRes.Text = txtRes.Text + "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            txtRes.Text = txtRes.Text + ".";
        }

        private void btnBorrarChar_Click(object sender, EventArgs e)
        {
            if (txtRes.Text.Length > 1)
                txtRes.Text = txtRes.Text.Substring(0, txtRes.Text.Length - 1);
            else
                txtRes.Text = "0";
        }

        private void btnBorrarTodo_Click(object sender, EventArgs e)
        {
            num1 = 0;
            num2 = 0;
            operador = '\0';
            txtRes.Text = "0";
        }

        private void btnBorrarParte_Click(object sender, EventArgs e)
        {
            if (num1 == 0)
            {
                num1 = 0;
                txtRes.Text = num1.ToString() + operador.ToString();
            }
            else if (num2 == 0)
            {
                num2 = 0;
                txtRes.Text = num1.ToString() + operador.ToString() + num2.ToString();
            }
        }
    }
}
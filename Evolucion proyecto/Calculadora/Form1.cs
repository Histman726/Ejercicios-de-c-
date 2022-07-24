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

        private void frmBasica_KeyDown(object sender, KeyEventArgs e)
        {
            //Shortcuts
            if (e.KeyData == Keys.D0 || e.KeyData == Keys.NumPad0)
                btn0_Click(sender, e);
            if (e.KeyData == Keys.D1 || e.KeyData == Keys.NumPad1)
                btn1_Click(sender, e);
            if (e.KeyData == Keys.D2 || e.KeyData == Keys.NumPad2)
                btn2_Click(sender, e);
            if (e.KeyData == Keys.D3 || e.KeyData == Keys.NumPad3)
                btn3_Click(sender, e);
            if (e.KeyData == Keys.D4 || e.KeyData == Keys.NumPad4)
                btn4_Click(sender, e);
            if (e.KeyData == Keys.D5 || e.KeyData == Keys.NumPad5)
                btn5_Click(sender, e);
            if (e.KeyData == Keys.D6 || e.KeyData == Keys.NumPad6)
                btn6_Click(sender, e);
            if (e.KeyData == Keys.D7 || e.KeyData == Keys.NumPad7)
                btn7_Click(sender, e);
            if (e.KeyData == Keys.D8 || e.KeyData == Keys.NumPad8)
                btn8_Click(sender, e);
            if (e.KeyData == Keys.D9 || e.KeyData == Keys.NumPad9)
                btn9_Click(sender, e);
            if (e.KeyData == Keys.Add || e.KeyData == Keys.Oemplus)
                btnSuma_Click(sender, e);
            if (e.KeyData == Keys.Subtract || e.KeyData == Keys.OemMinus)
                button5_Click(sender, e);
            if (e.KeyData == Keys.Multiply || e.KeyData == Keys.OemBackslash)
                btnMulti_Click(sender, e);
            if (e.KeyData == Keys.Divide || e.KeyData == Keys.OemQuestion)
                btnDiv_Click(sender, e);
            if (e.KeyData == Keys.Decimal || e.KeyData == Keys.Oemcomma)
                btnPunto_Click(sender, e);
            if (e.KeyData == Keys.Back)
                btnBorrarChar_Click(sender, e);
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.OemClear)
                btnBorrarTodo_Click(sender, e);
            if (e.KeyData == Keys.Enter || e.KeyData == Keys.Return)
                button13_Click(sender, e);
            if (e.KeyData == Keys.Escape)
                btnBorrarParte_Click(sender, e);
            if (e.KeyData == (Keys.Control | Keys.S))
            {
                btnSuma_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.R))
            {
                button5_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.M))
            {
                btnMulti_Click(sender, e);
            }
            else if (e.KeyData == (Keys.Control | Keys.D))
            {
                btnDiv_Click(sender, e);
            }
        }

        private void frmBasica_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '0')
                btn0_Click(sender, e);
            if (e.KeyChar == '1')
                btn1_Click(sender, e);
            if (e.KeyChar == '2')
                btn2_Click(sender, e);
            if (e.KeyChar == '3')
                btn3_Click(sender, e);
            if (e.KeyChar == '4')
                btn4_Click(sender, e);
            if (e.KeyChar == '5')
                btn5_Click(sender, e);
            if (e.KeyChar == '6')
                btn6_Click(sender, e);
            if (e.KeyChar == '7')
                btn7_Click(sender, e);
            if (e.KeyChar == '8')
                btn8_Click(sender, e);
            if (e.KeyChar == '9')
                btn9_Click(sender, e);
            if (e.KeyChar == '+')
                btnSuma_Click(sender, e);
            if (e.KeyChar == '-')
                button5_Click(sender, e);
            if (e.KeyChar == '*')
                btnMulti_Click(sender, e);
            if (e.KeyChar == '/')
                btnDiv_Click(sender, e);
            if (e.KeyChar == '.')
                btnPunto_Click(sender, e);
            if (e.KeyChar == '\b')
                btnBorrarChar_Click(sender, e);
            if (e.KeyChar == '\r')
                btnBorrarTodo_Click(sender, e);
            if (e.KeyChar == '\x1b')
                button13_Click(sender, e);
            if (e.KeyChar == '\x08')
                btnBorrarParte_Click(sender, e);
        }
    }
}
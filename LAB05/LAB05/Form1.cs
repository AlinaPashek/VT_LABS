namespace LAB05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool TryGetNumbers(out double number1, out double number2)
        {
            number1 = 0;
            number2 = 0;

            try
            {
                number1 = Convert.ToDouble(txtNumber1.Text);
                number2 = Convert.ToDouble(txtNumber2.Text);
                return true;
            }
            catch
            {
                lblResult.ForeColor = Color.Red;
                lblResult.Text = "Ошибка ввода";
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double number1, out double number2))
            {
                double result = number1 + number2;
                lblResult.ForeColor = Color.Green;
                lblResult.Text = result.ToString();
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double number1, out double number2))
            {
                double result = number1 - number2;
                lblResult.ForeColor = Color.Green;
                lblResult.Text = result.ToString();
            }
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double number1, out double number2))
            {
                double result = number1 * number2;
                lblResult.ForeColor = Color.Green;
                lblResult.Text = result.ToString();
            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (TryGetNumbers(out double number1, out double number2))
            {
                if (number2 == 0)
                {
                    lblResult.ForeColor = Color.Red;
                    lblResult.Text = "Деление на ноль";
                    return;
                }

                double result = number1 / number2;
                lblResult.ForeColor = Color.Green;
                lblResult.Text = result.ToString();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber1.Clear();
            txtNumber2.Clear();

            lblResult.ForeColor = Color.Green;
            lblResult.Text = "0";

            txtNumber1.Focus();
        }
    }
}
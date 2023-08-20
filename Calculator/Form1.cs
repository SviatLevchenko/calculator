using org.mariuszgromada.math.mxparser;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button0_Click(object sender, EventArgs e)
        {
            input_box.Text += "0";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            input_box.Text += "1";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            input_box.Text += "2";
        }
        private void button3_Click(object sender, EventArgs e)
        {
            input_box.Text += "3";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            input_box.Text += "4";
        }
        private void button5_Click(object sender, EventArgs e)
        {
            input_box.Text += "5";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            input_box.Text += "6";
        }
        private void button7_Click(object sender, EventArgs e)
        {
            input_box.Text += "7";
        }
        private void button8_Click(object sender, EventArgs e)
        {
            input_box.Text += "8";
        }
        private void button9_Click(object sender, EventArgs e)
        {
            input_box.Text += "9";
        }
        private void button_dot_Click(object sender, EventArgs e)
        {
            input_box.Text += ".";
        }
        private void division_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input_box.Text))
            {
                input_box.Text += "/";
            }
        }
        private void multiplication_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input_box.Text))
            {
                input_box.Text += "*";
            }
        }
        private void subtraction_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input_box.Text))
            {
                input_box.Text += "-";
            }
        }
        private void addition_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(input_box.Text))
            {
                input_box.Text += "+";
            }
        }
        private void leftbracket_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "(";
        }
        private void rightbracket_button_Click(object sender, EventArgs e)
        {
            input_box.Text += ")";
        }
        private void percent_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "%";
        }
        private void factorial_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "!";
        }
        private void power_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "^(";
        }
        private void sqrt_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "√";
        }
        private void log_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "log(";
        }
        private void ln_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "ln(";
        }
        private void clearing_button_Click(object sender, EventArgs e)
        {
            if (input_box.Text.Length > 0)
            {
                input_box.Text = input_box.Text.Substring(0, input_box.Text.Length - 1);
            }
        }
        private void allclearing_button_Click(object sender, EventArgs e)
        {
            input_box.Clear();
        }
        private void sin_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "sin(";
        }
        private void cos_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "cos(";
        }
        private void tg_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "tan(";
        }
        private void ctg_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "cot(";
        }
        private void pi_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "pi";
        }
        private void e_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "e";
        }
        private void complex_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "i";
        }
        private void infinity_button_Click(object sender, EventArgs e)
        {
            input_box.Text += "infinity";
        }
        private double CalculateExpression(string expression)
        {
            Expression exp = new Expression(expression);
            return exp.calculate();
        }
        private void button_equal_Click(object sender, EventArgs e)
        {
            try
            {
                string input = input_box.Text;
                input = input.Replace("√", "sqrt").Replace("log", "log10").Replace("ln", "log").Replace("∞", "infinity");
                double result = CalculateExpression(input);
                result_box.Text = result.ToString();
            }
            catch (Exception ex)
            {
                result_box.Text = "Error: " + ex.Message;
            }
        }
        private void input_box_TextChanged(object sender, EventArgs e)
        {

        }
        private void result_box_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

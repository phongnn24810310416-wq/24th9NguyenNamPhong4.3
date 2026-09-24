namespace FormCalculator
{
    public partial class Form1 : Form
    {
        double firstNumber = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            txtDisplay.Text += btn.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "+";
            txtDisplay.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "-";
            txtDisplay.Clear();
        }

        private void btnMutiply_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "*";
            txtDisplay.Clear();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            firstNumber = double.Parse(txtDisplay.Text);
            operation = "/";
            txtDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            firstNumber = 0;
            operation = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double secondNumber = double.Parse(txtDisplay.Text);
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                case "-":
                    result = firstNumber - secondNumber;
                    break;

                case "*":
                    result = firstNumber * secondNumber;
                    break;

                case "/":
                    if (secondNumber == 0)
                    {
                        MessageBox.Show("Không thể chia cho 0!");
                        return;
                    }

                    result = firstNumber / secondNumber;
                    break;
            }

            txtDisplay.Text = result.ToString();
        }
    }
}

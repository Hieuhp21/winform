namespace bai8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            Calculate("+");
        }

        private void buttonT_Click(object sender, EventArgs e)
        {
            Calculate("-");
        }

        private void buttonN_Click(object sender, EventArgs e)
        {
            Calculate("*");
        }

        private void buttonChia_Click(object sender, EventArgs e)
        {
            Calculate("/");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBoxNumber1.Clear();
            textBoxNumber2.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void Calculate(string operation)
        {
            double number1, number2, result = 0;
            if (!double.TryParse(textBoxNumber1.Text, out number1))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số thứ 1");
                return;
            }
            if (!double.TryParse(textBoxNumber2.Text, out number2))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho số thứ 2");
                return;
            }

            switch (operation)
            {
                case "+":
                    result = number1 + number2;
                    break;
                case "-":
                    result = number1 - number2;
                    break;
                case "*":
                    result = number1 * number2;
                    break;
                case "/":
                    if (number2 != 0)
                    {
                        result = number1 / number2;
                    }
                    else
                    {
                        MessageBox.Show("Không thể chia cho 0");
                        return;
                    }
                    break;
            }

            textBox1.Text = "" + result;
        }
    }
}

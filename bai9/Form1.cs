namespace bai9
{
    public partial class Form1 : Form
    {
        private int sum = 0;
        private int sumEven = 0;
        private int sumOdd = 0;
        private string sequence = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonNhap_Click(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBoxInput.Text, out number))
            {
                sequence += number + " ";
                richTextBoxOutPut.Text = sequence;
                textBoxInput.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
            }
            buttonCalculate(sender, e);
        }

        private void buttonCalculate(object sender, EventArgs e)
        {
            sum = 0;
            sumEven = 0;
            sumOdd = 0;
            string[] numbers = sequence.Trim().Split(' ');

            foreach (string num in numbers)
            {
                int number;
                if (int.TryParse(num, out number))
                {
                    sum += number;
                    if (number % 2 == 0)
                    {
                        sumEven += number;
                    }
                    else
                    {
                        sumOdd += number;
                    }
                }
            }

            textBoxTong.Text = "" + sum;
            textBoxChan.Text = "" + sumEven;
            textBoxLe.Text = "" + sumOdd;
        }

        private void buttonCt_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            richTextBoxOutPut.Clear();
            textBoxChan.Clear();
            textBoxLe.Clear();
            textBoxTong.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBoxInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonNhap.PerformClick();
            }
        }
    }
}

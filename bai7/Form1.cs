namespace bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTH_Click(object sender, EventArgs e)
        {
            int number1, number2;
            if (!int.TryParse(textBoxA.Text, out number1))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho số thứ 1");
                return;
            }
            if (!int.TryParse(textBoxB.Text, out number2))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho số thứ 2");
                return;
            }

            int ucln = UCLN(number1, number2);
            int bcnn = BCNN(number1, number2);

            textBoxUCLN.Text = Convert.ToString(ucln);
            textBoxBCNN.Text = Convert.ToString( bcnn);
        }

        private void button1Continue_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxBCNN.Clear();
            textBoxUCLN.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private int BCNN(int a, int b)
        {
            return (a * b) / UCLN(a, b);
        }
    }
}

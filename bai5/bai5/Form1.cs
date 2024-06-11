
namespace bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButtonPtB1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPtB1.Checked)
            {
                textBoxC.Enabled = false;
                textBoxC.Text = string.Empty; // Xóa giá trị trong textBoxC khi không sử dụng
            }
        }

        private void radioButtonPtB2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPtB2.Checked)
            {
                textBoxC.Enabled = true;
            }
        }

        private void GiaiPTBac1(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    textBoxKq.Text = "Phương trình vô số nghiệm.";
                }
                else
                {
                    textBoxKq.Text = "Phương trình vô nghiệm.";
                }
            }
            else
            {
                double x = -b / a;
                textBoxKq.Text = $"Phương trình có nghiệm x = {x}.";
            }
        }

        private void GiaiPTBac2(double a, double b, double c)
        {
            if (a == 0)
            {
                GiaiPTBac1(b, c); // Trường hợp phương trình bậc 2 trở thành bậc 1
            }
            else
            {
                double delta = b * b - 4 * a * c;
                if (delta < 0)
                {
                    textBoxKq.Text = "Phương trình vô nghiệm.";
                }
                else if (delta == 0)
                {
                    double x = -b / (2 * a);
                    textBoxKq.Text = $"Phương trình có nghiệm kép x = {x}.";
                }
                else
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    textBoxKq.Text = $"Phương trình có hai nghiệm phân biệt x1 = {x1} và x2 = {x2}.";
                }
            }
        }

        private void buttonGiai_Click(object sender, EventArgs e)
        {
            double a, b, c = 0;

            if (!double.TryParse(textBoA.Text, out a) || !double.TryParse(textBoxB.Text, out b) ||
                (textBoxC.Enabled && !double.TryParse(textBoxC.Text, out c)))
            {
                textBoxKq.Text = "Vui lòng nhập đúng các hệ số.";
                return;
            }

            if (radioButtonPtB1.Checked)
            {
                GiaiPTBac1(a, b);
            }
            else if (radioButtonPtB2.Checked)
            {
                GiaiPTBac2(a, b, c);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

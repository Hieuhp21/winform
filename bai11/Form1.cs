namespace bai11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxInput_TextChanged(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBoxInput.Text, out number))
            {
                if (IsPrime(number))
                {
                    textBoxKt.Text = $"{number} là số nguyên tố.";
                }
                else
                {
                    textBoxKt.Text = $"{number} không phải là số nguyên tố.";
                }

                List<int> primes = GetPrimesLessThanN(number);
                textBoxDNT.Text = string.Join(", ", primes);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
            }
        }

        private bool IsPrime(int number)
        {
            if (number < 2) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        private List<int> GetPrimesLessThanN(int n)
        {
            List<int> primes = new List<int>();
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i))
                {
                    primes.Add(i);
                }
            }
            return primes;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

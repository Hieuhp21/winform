namespace bai10
{
    public partial class Form1 : Form
    {
        private NumberSequence numberSequence;
        public Form1()
        {
            InitializeComponent();
            numberSequence = new NumberSequence();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            using (InputForm inputForm = new InputForm())
            {
                if (inputForm.ShowDialog() == DialogResult.OK)
                {
                    numberSequence.AddNumbers(inputForm.NumberSequenceInput);
                    DisplayResults();
                }
            }
        }
        private void DisplayResults()
        {
            richTextBox1.Text = string.Join(" ", numberSequence.Numbers);
            richTextBoxSum.Text = "" + numberSequence.Sum();
            richTextBoxChan.Text = "" + numberSequence.SumEven();
            richTextBoxLe.Text = "" + numberSequence.SumOdd();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBoxChan.Clear();
            richTextBoxLe.Clear();
            richTextBoxSum.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

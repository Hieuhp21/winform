namespace bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Google.com");
            comboBox1.Items.Add("FaceBook.com");
            comboBox1.Items.Add("YouTobe.com");
            comboBox1.Items.Add("LinkedIn.com");
            comboBox1.Items.Add("Twitter.com");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string slWeb = comboBox1.SelectedItem.ToString();
            ListboxRes.Items.Add(slWeb);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            ListboxRes.Items.Clear();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

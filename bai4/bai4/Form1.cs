namespace bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.Add("Google");
            comboBox1.Items.Add("Facebook");
            comboBox1.Items.Add("YouTube");
            comboBox1.Items.Add("Twitter");
            comboBox1.Items.Add("LinkedIn");
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listResult.Items.Clear();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedWebsite = comboBox1.SelectedItem.ToString();
           // listResult.Items.Clear();
            listResult.Items.Add($"Website được chọn: {selectedWebsite}.com");
        }
    }
}

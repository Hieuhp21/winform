namespace bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            string fullName = textBoxName.Text;
            DateTime dob = dateOfBirth.Value;
            string favorite = textBoxFavorit.Text;

            string result = $"{fullName} \n {dob.ToShortDateString()} \n {favorite}";
            textBoxkq.Text = result;
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

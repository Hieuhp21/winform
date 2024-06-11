namespace bai1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            //validation
            if (string.IsNullOrEmpty(username) || string.IsNullOrWhiteSpace(password)) {
                MessageBox.Show("Vui lòng nhập đủ Username và password");
                textBox1.Focus();
                return;
            } 
            if (username == "tamga" && password == "123" ) {
                MessageBox.Show("Bạn đã đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else {
                MessageBox.Show("Bạn hãy nhập lại !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát hay không ?", "Chú ý", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes) {
                Application.Exit();
            }
        }
    }
}

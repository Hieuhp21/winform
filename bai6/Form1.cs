namespace bai6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioPTBac1_CheckedChanged(object sender, EventArgs e)
        {
            textBoxC.Enabled = false;
            textBoxC.Text = string.Empty;
        }

        private void radioPTBac2_CheckedChanged(object sender, EventArgs e)
        {
            textBoxC.Enabled = true;
        }


        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double a, b, c;
            //validate input
            if (!double.TryParse(textBoxA.Text, out a))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho A");
                return;
            }
            if (!double.TryParse(textBoxB.Text, out b))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ cho B");
                return;
            }
            //giai
            if (radioPTBac1.Checked)
            {
                PTBac1 pt1 = new PTBac1(a, b);
                try
                {
                    textBoxKetQua.Text = pt1.Giai().ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (radioPTBac2.Checked)
            {
                if (!double.TryParse(textBoxC.Text, out c))
                {
                    MessageBox.Show("Vui lòng nhập số hợp lệ cho C");
                    return;
                }

                PTBac2 pt2 = new PTBac2(a, b, c);
                try
                {
                    textBoxKetQua.Text = pt2.Giai();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            textBoxA.Clear();
            textBoxB.Clear();
            textBoxC.Clear();
            textBoxKetQua.Clear();
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

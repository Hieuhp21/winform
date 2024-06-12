namespace bai14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioVuong_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxVuong.Visible = radioVuong.Checked;
            groupBoxTamGiac.Visible=false;
            groupBoxHTron.Visible=false;
            groupBoxHCN.Visible=false;
        }

        private void radioTron_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxVuong.Visible = false;
            groupBoxTamGiac.Visible = false;
            groupBoxHTron.Visible = radioTron.Checked;
            groupBoxHCN.Visible = false;
        }

        private void radioHCN_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxVuong.Visible = false;
            groupBoxTamGiac.Visible = false;
            groupBoxHTron.Visible = false;
            groupBoxHCN.Visible = radioHCN.Checked;
        }

        private void radioTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxVuong.Visible = false;
            groupBoxTamGiac.Visible = radioTamGiac.Checked;
            groupBoxHTron.Visible = false;
            groupBoxHCN.Visible = false;
        }

        private void buttonCalculator_Click(object sender, EventArgs e)
        {
            //validate 
            if (radioVuong.Checked)
            {
                if (!ValidateGroupBox(groupBoxVuong))
                {
                    MessageBox.Show("Độ dài các cạnh phải lớn hơn 0.");
                    return;
                }
            }
            else if (radioTron.Checked)
            {
                if (!ValidateGroupBox(groupBoxHTron))
                {
                    MessageBox.Show("Bán kính phải lớn hơn 0.");
                    return;
                }
            }
            else if (radioTamGiac.Checked)
            {
                if (!ValidateGroupBox(groupBoxTamGiac))
                {
                    MessageBox.Show("Độ dài các cạnh phải lớn hơn 0.");
                    return;
                }
            }
            else if (radioHCN.Checked)
            {
                if (!ValidateGroupBox(groupBoxHCN))
                {
                    MessageBox.Show("Chiều dài và chiều rộng phải lớn hơn 0.");
                    return;
                }
             // calculator

            if (radioVuong.Checked)
            {
                double side = double.Parse(textBoxCanhHV.Text);
                double perimeter = 4 * side;
                double area = side * side;
                textBoxSHV.Text = $"{area}";
                textBoxCHV.Text = "" + perimeter;
            }
            else if (radioTron.Checked)
            {
                double radius = double.Parse(textBoxR.Text);
                double perimeter = 2 * Math.PI * radius;
                double area = Math.PI * radius * radius;
                textBoxSTron.Text = $"{area}";
                textBoxCTron.Text=""+perimeter;
            }
            else if (radioTamGiac.Checked)
            {
                double a = double.Parse(textBoxCA.Text);
                double b = double.Parse(textBoxCB.Text);
                double c = double.Parse(textBoxCC.Text);
                double perimeter = a + b + c;
                double s = perimeter / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
                textBoxSTG.Text = $"{area}";
                textBoxCTG.Text = "" + perimeter;
                textBoxLoaiTG.Text=CheckTriangleType(a, b, c);
            }
            else if (radioHCN.Checked)
            {
                double length = double.Parse(textBoxCD.Text);
                double width = double.Parse(textBoxCR.Text);
                double perimeter = 2 * (length + width);
                double area = length * width;
                textBoxSHCN.Text = $"{area}";
                textBoxCHCN.Text = "" + perimeter;
            }
        }
        }
        private bool ValidateGroupBox(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is TextBox)
                {
                    double value;
                    if (!double.TryParse(control.Text, out value) || value <= 0)
                    {
                        return false;
                    }
                }
            }
            return true;
        }


            private string CheckTriangleType(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                return "Không phải tam giác";
            }
            else if (a == b && b == c)
            {
                return "Tam giác đều";
            }
            else if (a == b || a == c || b == c)
            {
                return "Tam giác cân";
            }
            else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
            {
                return "Tam giác vuông";
            }
            else
            {
                return "Tam giác thường";
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Globalization;
using System.Windows.Forms;

namespace bai15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonThucHien_Click(object sender, EventArgs e)
        {
            string inputString = textBoxInput.Text;

            if (radioButtonThường.Checked)
            {
                textBoxOutPut.Text = ConvertToLowerCase(inputString);
            }
            else if (radioButtonHoa.Checked)
            {
                textBoxOutPut.Text = ConvertToTitleCase(inputString);
            }
        }

        private string ConvertToLowerCase(string input)
        {
            return input.ToLower();
        }

        private string ConvertToTitleCase(string input)
        {
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
            return textInfo.ToTitleCase(input.ToLower());
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            textBoxOutPut.Clear();
        }
    }
}

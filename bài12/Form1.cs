using System;

namespace bài12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PerformOperation(Operation.Add, "Cộng");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            PerformOperation(Operation.Subtract, "Trừ");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            PerformOperation(Operation.Multiply, "Nhân");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            PerformOperation(Operation.Divide, "Chia");
        }

        private void PerformOperation(Operation operation, string operationName)
        {
            try
            {
                Fraction fraction1 = GetFraction(textBoxNumerator1.Text, textBoxDenominator1.Text);
                Fraction fraction2 = GetFraction(textBoxNumerator2.Text, textBoxDenominator2.Text);

                Fraction result = null;
                switch (operation)
                {
                    case Operation.Add:
                        result = fraction1.Add(fraction2);
                        break;
                    case Operation.Subtract:
                        result = fraction1.Subtract(fraction2);
                        break;
                    case Operation.Multiply:
                        result = fraction1.Multiply(fraction2);
                        break;
                    case Operation.Divide:
                        result = fraction1.Divide(fraction2);
                        break;
                }

                labelResult.Text = $"Kết quả phép {operationName}: {result}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Fraction GetFraction(string numeratorText, string denominatorText)
        {
            if (int.TryParse(numeratorText, out int numerator) && int.TryParse(denominatorText, out int denominator))
            {
                return new Fraction(numerator, denominator);
            }
            else
            {
                throw new ArgumentException("Tử số và mẫu số phải là số nguyên.");
            }
        }

        
    }

    enum Operation
    {
        Add,
        Subtract,
        Multiply,
        Divide
    }

}

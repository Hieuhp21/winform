namespace bài12
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelNumerator1;
        private System.Windows.Forms.TextBox textBoxNumerator1;
        private System.Windows.Forms.Label labelDenominator1;
        private System.Windows.Forms.TextBox textBoxDenominator1;
        private System.Windows.Forms.Label labelNumerator2;
        private System.Windows.Forms.TextBox textBoxNumerator2;
        private System.Windows.Forms.Label labelDenominator2;
        private System.Windows.Forms.TextBox textBoxDenominator2;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSubtract;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.Button buttonDivide;
        private System.Windows.Forms.Label labelResult;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            labelNumerator1 = new Label();
            textBoxNumerator1 = new TextBox();
            labelDenominator1 = new Label();
            textBoxDenominator1 = new TextBox();
            labelNumerator2 = new Label();
            textBoxNumerator2 = new TextBox();
            labelDenominator2 = new Label();
            textBoxDenominator2 = new TextBox();
            buttonAdd = new Button();
            buttonSubtract = new Button();
            buttonMultiply = new Button();
            buttonDivide = new Button();
            labelResult = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // labelNumerator1
            // 
            labelNumerator1.AutoSize = true;
            labelNumerator1.Location = new Point(61, 113);
            labelNumerator1.Name = "labelNumerator1";
            labelNumerator1.Size = new Size(60, 20);
            labelNumerator1.TabIndex = 0;
            labelNumerator1.Text = "Tử số 1:";
            // 
            // textBoxNumerator1
            // 
            textBoxNumerator1.Location = new Point(127, 110);
            textBoxNumerator1.Name = "textBoxNumerator1";
            textBoxNumerator1.Size = new Size(100, 27);
            textBoxNumerator1.TabIndex = 1;
            // 
            // labelDenominator1
            // 
            labelDenominator1.AutoSize = true;
            labelDenominator1.Location = new Point(49, 156);
            labelDenominator1.Name = "labelDenominator1";
            labelDenominator1.Size = new Size(72, 20);
            labelDenominator1.TabIndex = 2;
            labelDenominator1.Text = "Mẫu số 1:";
            // 
            // textBoxDenominator1
            // 
            textBoxDenominator1.Location = new Point(127, 149);
            textBoxDenominator1.Name = "textBoxDenominator1";
            textBoxDenominator1.Size = new Size(100, 27);
            textBoxDenominator1.TabIndex = 3;
            // 
            // labelNumerator2
            // 
            labelNumerator2.AutoSize = true;
            labelNumerator2.Location = new Point(349, 113);
            labelNumerator2.Name = "labelNumerator2";
            labelNumerator2.Size = new Size(60, 20);
            labelNumerator2.TabIndex = 4;
            labelNumerator2.Text = "Tử số 2:";
            // 
            // textBoxNumerator2
            // 
            textBoxNumerator2.Location = new Point(427, 110);
            textBoxNumerator2.Name = "textBoxNumerator2";
            textBoxNumerator2.Size = new Size(100, 27);
            textBoxNumerator2.TabIndex = 5;
            // 
            // labelDenominator2
            // 
            labelDenominator2.AutoSize = true;
            labelDenominator2.Location = new Point(349, 156);
            labelDenominator2.Name = "labelDenominator2";
            labelDenominator2.Size = new Size(72, 20);
            labelDenominator2.TabIndex = 6;
            labelDenominator2.Text = "Mẫu số 2:";
            // 
            // textBoxDenominator2
            // 
            textBoxDenominator2.Location = new Point(427, 149);
            textBoxDenominator2.Name = "textBoxDenominator2";
            textBoxDenominator2.Size = new Size(100, 27);
            textBoxDenominator2.TabIndex = 7;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(61, 219);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(75, 55);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Cộng";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSubtract
            // 
            buttonSubtract.Location = new Point(61, 280);
            buttonSubtract.Name = "buttonSubtract";
            buttonSubtract.Size = new Size(75, 55);
            buttonSubtract.TabIndex = 9;
            buttonSubtract.Text = "Trừ";
            buttonSubtract.UseVisualStyleBackColor = true;
            buttonSubtract.Click += buttonSubtract_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(152, 219);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(75, 55);
            buttonMultiply.TabIndex = 10;
            buttonMultiply.Text = "Nhân";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDivide
            // 
            buttonDivide.Location = new Point(152, 280);
            buttonDivide.Name = "buttonDivide";
            buttonDivide.Size = new Size(75, 55);
            buttonDivide.TabIndex = 11;
            buttonDivide.Text = "Chia";
            buttonDivide.UseVisualStyleBackColor = true;
            buttonDivide.Click += buttonDivide_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(285, 254);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(63, 20);
            labelResult.TabIndex = 12;
            labelResult.Text = "Kết quả:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(217, 33);
            label1.Name = "label1";
            label1.Size = new Size(159, 23);
            label1.TabIndex = 13;
            label1.Text = "Phép Tính Phân Số";
            // 
            // Form1
            // 
            ClientSize = new Size(579, 431);
            Controls.Add(label1);
            Controls.Add(labelResult);
            Controls.Add(buttonDivide);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonSubtract);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxDenominator2);
            Controls.Add(labelDenominator2);
            Controls.Add(textBoxNumerator2);
            Controls.Add(labelNumerator2);
            Controls.Add(textBoxDenominator1);
            Controls.Add(labelDenominator1);
            Controls.Add(textBoxNumerator1);
            Controls.Add(labelNumerator1);
            Name = "Form1";
            Text = "Fraction Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #region Windows Form Designer generated code



        #endregion

        private Label label1;
    }
}

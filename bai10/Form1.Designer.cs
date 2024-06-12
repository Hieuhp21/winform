namespace bai10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            richTextBoxSum = new RichTextBox();
            richTextBoxChan = new RichTextBox();
            richTextBoxLe = new RichTextBox();
            buttonAdd = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(323, 49);
            label1.Name = "label1";
            label1.Size = new Size(120, 28);
            label1.TabIndex = 0;
            label1.Text = "Tổng Chuỗi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 134);
            label2.Name = "label2";
            label2.Size = new Size(199, 20);
            label2.TabIndex = 1;
            label2.Text = "Dãy số bạn vừa nhập vào là :";
            // 
            // richTextBox1
            // 
            richTextBox1.Enabled = false;
            richTextBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBox1.Location = new Point(169, 168);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(480, 31);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 241);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 3;
            label3.Text = "Tổng: ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(169, 277);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 4;
            label4.Text = "Tổng chẵn : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(456, 277);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 5;
            label5.Text = "Tổng lẻ : ";
            // 
            // richTextBoxSum
            // 
            richTextBoxSum.Enabled = false;
            richTextBoxSum.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxSum.Location = new Point(264, 234);
            richTextBoxSum.Name = "richTextBoxSum";
            richTextBoxSum.Size = new Size(117, 27);
            richTextBoxSum.TabIndex = 6;
            richTextBoxSum.Text = "";
            // 
            // richTextBoxChan
            // 
            richTextBoxChan.Enabled = false;
            richTextBoxChan.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxChan.Location = new Point(264, 270);
            richTextBoxChan.Name = "richTextBoxChan";
            richTextBoxChan.Size = new Size(117, 27);
            richTextBoxChan.TabIndex = 7;
            richTextBoxChan.Text = "";
            // 
            // richTextBoxLe
            // 
            richTextBoxLe.Enabled = false;
            richTextBoxLe.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            richTextBoxLe.Location = new Point(532, 270);
            richTextBoxLe.Name = "richTextBoxLe";
            richTextBoxLe.Size = new Size(117, 27);
            richTextBoxLe.TabIndex = 8;
            richTextBoxLe.Text = "";
            // 
            // buttonAdd
            // 
            buttonAdd.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.Location = new Point(169, 368);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(156, 29);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Nhập và Tính";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.Location = new Point(441, 368);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(85, 29);
            buttonReset.TabIndex = 10;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(564, 368);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(85, 29);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 525);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(buttonAdd);
            Controls.Add(richTextBoxLe);
            Controls.Add(richTextBoxChan);
            Controls.Add(richTextBoxSum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RichTextBox richTextBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private RichTextBox richTextBoxSum;
        private RichTextBox richTextBoxChan;
        private RichTextBox richTextBoxLe;
        private Button buttonAdd;
        private Button buttonReset;
        private Button buttonExit;
    }
}

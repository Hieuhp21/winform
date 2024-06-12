namespace bai11
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
            label3 = new Label();
            label4 = new Label();
            textBoxInput = new TextBox();
            textBoxKt = new TextBox();
            textBoxDNT = new TextBox();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(258, 28);
            label1.Name = "label1";
            label1.Size = new Size(304, 28);
            label1.TabIndex = 0;
            label1.Text = "Kiểm Tra và TÌm Số Nguyên Tố";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(159, 100);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập số :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(159, 165);
            label3.Name = "label3";
            label3.Size = new Size(110, 20);
            label3.TabIndex = 2;
            label3.Text = "Kiểm tra SNT :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(159, 215);
            label4.Name = "label4";
            label4.Size = new Size(136, 20);
            label4.TabIndex = 3;
            label4.Text = "Các SNT nhỏ hơn :";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(326, 100);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(236, 27);
            textBoxInput.TabIndex = 4;
            textBoxInput.TextChanged += textBoxInput_TextChanged;
            // 
            // textBoxKt
            // 
            textBoxKt.Enabled = false;
            textBoxKt.Location = new Point(326, 162);
            textBoxKt.Name = "textBoxKt";
            textBoxKt.Size = new Size(236, 27);
            textBoxKt.TabIndex = 5;
            // 
            // textBoxDNT
            // 
            textBoxDNT.Enabled = false;
            textBoxDNT.Location = new Point(326, 212);
            textBoxDNT.Name = "textBoxDNT";
            textBoxDNT.Size = new Size(236, 27);
            textBoxDNT.TabIndex = 6;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(468, 283);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonExit);
            Controls.Add(textBoxDNT);
            Controls.Add(textBoxKt);
            Controls.Add(textBoxInput);
            Controls.Add(label4);
            Controls.Add(label3);
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
        private Label label3;
        private Label label4;
        private TextBox textBoxInput;
        private TextBox textBoxKt;
        private TextBox textBoxDNT;
        private Button buttonExit;
    }
}

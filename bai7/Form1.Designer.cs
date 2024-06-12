namespace bai7
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
            label5 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxUCLN = new TextBox();
            textBoxBCNN = new TextBox();
            buttonTH = new Button();
            button1Continue = new Button();
            buttonExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Cyan;
            label1.Location = new Point(160, 46);
            label1.Name = "label1";
            label1.Size = new Size(483, 28);
            label1.TabIndex = 0;
            label1.Text = "Tìm Ước Chung Lớn Nhất và Bội Chung Nhỏ Nhất";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(205, 179);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập số a :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(205, 224);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhập số b :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(205, 314);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 3;
            label4.Text = "Ước chung lớn nhất :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(205, 361);
            label5.Name = "label5";
            label5.Size = new Size(152, 20);
            label5.TabIndex = 4;
            label5.Text = "Bội chung nhỏ nhất :";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(337, 172);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(235, 27);
            textBoxA.TabIndex = 5;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(337, 217);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(235, 27);
            textBoxB.TabIndex = 6;
            // 
            // textBoxUCLN
            // 
            textBoxUCLN.BackColor = Color.FromArgb(224, 224, 224);
            textBoxUCLN.Enabled = false;
            textBoxUCLN.ForeColor = Color.Red;
            textBoxUCLN.Location = new Point(410, 307);
            textBoxUCLN.Name = "textBoxUCLN";
            textBoxUCLN.Size = new Size(162, 27);
            textBoxUCLN.TabIndex = 7;
            // 
            // textBoxBCNN
            // 
            textBoxBCNN.BackColor = Color.FromArgb(224, 224, 224);
            textBoxBCNN.Enabled = false;
            textBoxBCNN.ForeColor = Color.Lime;
            textBoxBCNN.Location = new Point(410, 354);
            textBoxBCNN.Name = "textBoxBCNN";
            textBoxBCNN.Size = new Size(162, 27);
            textBoxBCNN.TabIndex = 8;
            // 
            // buttonTH
            // 
            buttonTH.BackColor = Color.FromArgb(128, 255, 128);
            buttonTH.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonTH.ForeColor = Color.Green;
            buttonTH.Location = new Point(205, 454);
            buttonTH.Name = "buttonTH";
            buttonTH.Size = new Size(94, 29);
            buttonTH.TabIndex = 9;
            buttonTH.Text = "Thực Hiện";
            buttonTH.UseVisualStyleBackColor = false;
            buttonTH.Click += buttonTH_Click;
            // 
            // button1Continue
            // 
            button1Continue.BackColor = Color.FromArgb(255, 255, 128);
            button1Continue.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1Continue.ForeColor = Color.Olive;
            button1Continue.Location = new Point(349, 454);
            button1Continue.Name = "button1Continue";
            button1Continue.Size = new Size(94, 29);
            button1Continue.TabIndex = 10;
            button1Continue.Text = "Tiếp Tục";
            button1Continue.UseVisualStyleBackColor = false;
            button1Continue.Click += button1Continue_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.FromArgb(255, 128, 128);
            buttonExit.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.Maroon;
            buttonExit.Location = new Point(478, 454);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 624);
            Controls.Add(buttonExit);
            Controls.Add(button1Continue);
            Controls.Add(buttonTH);
            Controls.Add(textBoxBCNN);
            Controls.Add(textBoxUCLN);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveCaption;
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
        private Label label5;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxUCLN;
        private TextBox textBoxBCNN;
        private Button buttonTH;
        private Button button1Continue;
        private Button buttonExit;
    }
}

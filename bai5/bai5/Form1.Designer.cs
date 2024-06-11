namespace bai5
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
            groupBox1 = new GroupBox();
            radioButtonPtB2 = new RadioButton();
            radioButtonPtB1 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            label5 = new Label();
            textBoxKq = new TextBox();
            buttonGiai = new Button();
            buttonExit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(285, 29);
            label1.Name = "label1";
            label1.Size = new Size(208, 31);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonPtB2);
            groupBox1.Controls.Add(radioButtonPtB1);
            groupBox1.Location = new Point(256, 124);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(264, 125);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Vui lòng chọn dạng bài giải";
            // 
            // radioButtonPtB2
            // 
            radioButtonPtB2.AutoSize = true;
            radioButtonPtB2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonPtB2.Location = new Point(16, 82);
            radioButtonPtB2.Name = "radioButtonPtB2";
            radioButtonPtB2.Size = new Size(191, 24);
            radioButtonPtB2.TabIndex = 1;
            radioButtonPtB2.TabStop = true;
            radioButtonPtB2.Text = "Giải phương trình bậc 2";
            radioButtonPtB2.UseVisualStyleBackColor = true;
            radioButtonPtB2.CheckedChanged += radioButtonPtB2_CheckedChanged;
            // 
            // radioButtonPtB1
            // 
            radioButtonPtB1.AutoSize = true;
            radioButtonPtB1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonPtB1.Location = new Point(16, 40);
            radioButtonPtB1.Name = "radioButtonPtB1";
            radioButtonPtB1.Size = new Size(189, 24);
            radioButtonPtB1.TabIndex = 0;
            radioButtonPtB1.TabStop = true;
            radioButtonPtB1.Text = "Giải phương trình bậc 1";
            radioButtonPtB1.UseVisualStyleBackColor = true;
            radioButtonPtB1.CheckedChanged += radioButtonPtB1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 271);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập a :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(256, 315);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 3;
            label3.Text = "Nhập b :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(256, 351);
            label4.Name = "label4";
            label4.Size = new Size(63, 20);
            label4.TabIndex = 4;
            label4.Text = "Nhập c :";
            // 
            // textBoA
            // 
            textBoA.Location = new Point(342, 269);
            textBoA.Name = "textBoA";
            textBoA.Size = new Size(178, 27);
            textBoA.TabIndex = 5;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(342, 308);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(178, 27);
            textBoxB.TabIndex = 6;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(342, 351);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(178, 27);
            textBoxC.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(256, 402);
            label5.Name = "label5";
            label5.Size = new Size(69, 20);
            label5.TabIndex = 8;
            label5.Text = "Kết quả :";
            // 
            // textBoxKq
            // 
            textBoxKq.Location = new Point(342, 399);
            textBoxKq.Name = "textBoxKq";
            textBoxKq.Size = new Size(322, 27);
            textBoxKq.TabIndex = 9;
            // 
            // buttonGiai
            // 
            buttonGiai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            buttonGiai.Location = new Point(570, 271);
            buttonGiai.Name = "buttonGiai";
            buttonGiai.Size = new Size(94, 64);
            buttonGiai.TabIndex = 10;
            buttonGiai.Text = "Giải";
            buttonGiai.UseVisualStyleBackColor = true;
            buttonGiai.Click += buttonGiai_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonExit.Location = new Point(570, 351);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 11;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 508);
            Controls.Add(buttonExit);
            Controls.Add(buttonGiai);
            Controls.Add(textBoxKq);
            Controls.Add(label5);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioButtonPtB1;
        private RadioButton radioButtonPtB2;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Label label5;
        private TextBox textBoxKq;
        private Button buttonGiai;
        private Button buttonExit;
    }
}

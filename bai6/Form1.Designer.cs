namespace bai6
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
            radioPTBac2 = new RadioButton();
            radioPTBac1 = new RadioButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxA = new TextBox();
            textBoxB = new TextBox();
            textBoxC = new TextBox();
            buttonSolve = new Button();
            buttonDelete = new Button();
            buttonExit = new Button();
            label5 = new Label();
            textBoxKetQua = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(314, 50);
            label1.Name = "label1";
            label1.Size = new Size(183, 28);
            label1.TabIndex = 0;
            label1.Text = "Giải Phương Trình";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioPTBac2);
            groupBox1.Controls.Add(radioPTBac1);
            groupBox1.Location = new Point(243, 158);
            groupBox1.Name = "groupBox1";
            groupBox1.RightToLeft = RightToLeft.No;
            groupBox1.Size = new Size(336, 126);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn phương trình";
            // 
            // radioPTBac2
            // 
            radioPTBac2.AutoSize = true;
            radioPTBac2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioPTBac2.Location = new Point(40, 81);
            radioPTBac2.Name = "radioPTBac2";
            radioPTBac2.Size = new Size(191, 24);
            radioPTBac2.TabIndex = 1;
            radioPTBac2.TabStop = true;
            radioPTBac2.Text = "Giải phương trình bậc 2";
            radioPTBac2.UseVisualStyleBackColor = true;
            radioPTBac2.CheckedChanged += radioPTBac2_CheckedChanged;
            // 
            // radioPTBac1
            // 
            radioPTBac1.AutoSize = true;
            radioPTBac1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioPTBac1.Location = new Point(40, 41);
            radioPTBac1.Name = "radioPTBac1";
            radioPTBac1.Size = new Size(189, 24);
            radioPTBac1.TabIndex = 0;
            radioPTBac1.TabStop = true;
            radioPTBac1.Text = "Giải phương trình bậc 1";
            radioPTBac1.UseVisualStyleBackColor = true;
            radioPTBac1.CheckedChanged += radioPTBac1_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(167, 326);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập a :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(167, 370);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 3;
            label3.Text = "Nhập b :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(167, 410);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 4;
            label4.Text = "Nhập c :";
            // 
            // textBoxA
            // 
            textBoxA.Location = new Point(243, 326);
            textBoxA.Name = "textBoxA";
            textBoxA.Size = new Size(141, 27);
            textBoxA.TabIndex = 5;
            // 
            // textBoxB
            // 
            textBoxB.Location = new Point(243, 367);
            textBoxB.Name = "textBoxB";
            textBoxB.Size = new Size(141, 27);
            textBoxB.TabIndex = 6;
            // 
            // textBoxC
            // 
            textBoxC.Location = new Point(243, 410);
            textBoxC.Name = "textBoxC";
            textBoxC.Size = new Size(141, 27);
            textBoxC.TabIndex = 7;
            // 
            // buttonSolve
            // 
            buttonSolve.BackColor = Color.FromArgb(128, 255, 128);
            buttonSolve.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSolve.ForeColor = Color.Black;
            buttonSolve.Location = new Point(461, 326);
            buttonSolve.Name = "buttonSolve";
            buttonSolve.Size = new Size(118, 29);
            buttonSolve.TabIndex = 8;
            buttonSolve.Text = "Giải";
            buttonSolve.UseVisualStyleBackColor = false;
            buttonSolve.Click += buttonSolve_Click;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.FromArgb(224, 224, 224);
            buttonDelete.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDelete.ForeColor = Color.Black;
            buttonDelete.Location = new Point(461, 367);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(118, 29);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Xóa";
            buttonDelete.UseMnemonic = false;
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.ForeColor = Color.Black;
            buttonExit.Location = new Point(461, 410);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(118, 29);
            buttonExit.TabIndex = 10;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(167, 485);
            label5.Name = "label5";
            label5.Size = new Size(73, 20);
            label5.TabIndex = 11;
            label5.Text = "Kết quả : ";
            // 
            // textBoxKetQua
            // 
            textBoxKetQua.Enabled = false;
            textBoxKetQua.Location = new Point(243, 482);
            textBoxKetQua.Multiline = true;
            textBoxKetQua.Name = "textBoxKetQua";
            textBoxKetQua.Size = new Size(333, 33);
            textBoxKetQua.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 564);
            Controls.Add(textBoxKetQua);
            Controls.Add(label5);
            Controls.Add(buttonExit);
            Controls.Add(buttonDelete);
            Controls.Add(buttonSolve);
            Controls.Add(textBoxC);
            Controls.Add(textBoxB);
            Controls.Add(textBoxA);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioPTBac2;
        private RadioButton radioPTBac1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxA;
        private TextBox textBoxB;
        private TextBox textBoxC;
        private Button buttonSolve;
        private Button buttonDelete;
        private Button buttonExit;
        private Label label5;
        private TextBox textBoxKetQua;
    }
}

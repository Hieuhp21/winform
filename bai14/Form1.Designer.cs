namespace bai14
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
            radioTamGiac = new RadioButton();
            radioHCN = new RadioButton();
            radioTron = new RadioButton();
            radioVuong = new RadioButton();
            groupBoxVuong = new GroupBox();
            label4 = new Label();
            label3 = new Label();
            textBoxCHV = new TextBox();
            textBoxSHV = new TextBox();
            textBoxCanhHV = new TextBox();
            label2 = new Label();
            groupBoxHCN = new GroupBox();
            label11 = new Label();
            textBoxCR = new TextBox();
            label8 = new Label();
            label9 = new Label();
            textBoxCHCN = new TextBox();
            textBoxSHCN = new TextBox();
            textBoxCD = new TextBox();
            label10 = new Label();
            groupBoxTamGiac = new GroupBox();
            textBoxLoaiTG = new TextBox();
            textBoxCC = new TextBox();
            label16 = new Label();
            label12 = new Label();
            textBoxCB = new TextBox();
            label13 = new Label();
            label14 = new Label();
            textBoxCTG = new TextBox();
            textBoxSTG = new TextBox();
            textBoxCA = new TextBox();
            label15 = new Label();
            groupBoxHTron = new GroupBox();
            label5 = new Label();
            label6 = new Label();
            textBoxCTron = new TextBox();
            textBoxSTron = new TextBox();
            textBoxR = new TextBox();
            label7 = new Label();
            buttonCalculator = new Button();
            buttonReset = new Button();
            buttonExit = new Button();
            groupBox1.SuspendLayout();
            groupBoxVuong.SuspendLayout();
            groupBoxHCN.SuspendLayout();
            groupBoxTamGiac.SuspendLayout();
            groupBoxHTron.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(287, 46);
            label1.Name = "label1";
            label1.Size = new Size(245, 28);
            label1.TabIndex = 0;
            label1.Text = "Tính Chu Vi và Diện Tích";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioTamGiac);
            groupBox1.Controls.Add(radioHCN);
            groupBox1.Controls.Add(radioTron);
            groupBox1.Controls.Add(radioVuong);
            groupBox1.Location = new Point(165, 111);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(511, 141);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chọn hình";
            // 
            // radioTamGiac
            // 
            radioTamGiac.AutoSize = true;
            radioTamGiac.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioTamGiac.Location = new Point(324, 86);
            radioTamGiac.Name = "radioTamGiac";
            radioTamGiac.Size = new Size(125, 24);
            radioTamGiac.TabIndex = 3;
            radioTamGiac.TabStop = true;
            radioTamGiac.Text = "Hình tam giác";
            radioTamGiac.UseVisualStyleBackColor = true;
            radioTamGiac.CheckedChanged += radioTamGiac_CheckedChanged;
            // 
            // radioHCN
            // 
            radioHCN.AutoSize = true;
            radioHCN.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioHCN.Location = new Point(324, 39);
            radioHCN.Name = "radioHCN";
            radioHCN.Size = new Size(127, 24);
            radioHCN.TabIndex = 2;
            radioHCN.TabStop = true;
            radioHCN.Text = "Hình chữ nhật";
            radioHCN.UseVisualStyleBackColor = true;
            radioHCN.CheckedChanged += radioHCN_CheckedChanged;
            // 
            // radioTron
            // 
            radioTron.AutoSize = true;
            radioTron.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioTron.Location = new Point(49, 86);
            radioTron.Name = "radioTron";
            radioTron.Size = new Size(96, 24);
            radioTron.TabIndex = 1;
            radioTron.TabStop = true;
            radioTron.Text = "Hình tròn";
            radioTron.UseVisualStyleBackColor = true;
            radioTron.CheckedChanged += radioTron_CheckedChanged;
            // 
            // radioVuong
            // 
            radioVuong.AutoSize = true;
            radioVuong.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            radioVuong.Location = new Point(49, 39);
            radioVuong.Name = "radioVuong";
            radioVuong.Size = new Size(111, 24);
            radioVuong.TabIndex = 0;
            radioVuong.TabStop = true;
            radioVuong.Text = "Hình vuông";
            radioVuong.UseVisualStyleBackColor = true;
            radioVuong.CheckedChanged += radioVuong_CheckedChanged;
            // 
            // groupBoxVuong
            // 
            groupBoxVuong.BackColor = Color.Aqua;
            groupBoxVuong.Controls.Add(label4);
            groupBoxVuong.Controls.Add(label3);
            groupBoxVuong.Controls.Add(textBoxCHV);
            groupBoxVuong.Controls.Add(textBoxSHV);
            groupBoxVuong.Controls.Add(textBoxCanhHV);
            groupBoxVuong.Controls.Add(label2);
            groupBoxVuong.Location = new Point(165, 388);
            groupBoxVuong.Name = "groupBoxVuong";
            groupBoxVuong.Size = new Size(511, 200);
            groupBoxVuong.TabIndex = 2;
            groupBoxVuong.TabStop = false;
            groupBoxVuong.Text = "Hình Vuông";
            groupBoxVuong.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(202, 156);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 5;
            label4.Text = "Chu Vi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(183, 123);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Diện Tích";
            // 
            // textBoxCHV
            // 
            textBoxCHV.Enabled = false;
            textBoxCHV.Location = new Point(276, 149);
            textBoxCHV.Name = "textBoxCHV";
            textBoxCHV.Size = new Size(123, 27);
            textBoxCHV.TabIndex = 3;
            // 
            // textBoxSHV
            // 
            textBoxSHV.Enabled = false;
            textBoxSHV.Location = new Point(276, 116);
            textBoxSHV.Name = "textBoxSHV";
            textBoxSHV.Size = new Size(123, 27);
            textBoxSHV.TabIndex = 2;
            // 
            // textBoxCanhHV
            // 
            textBoxCanhHV.Location = new Point(276, 56);
            textBoxCanhHV.Name = "textBoxCanhHV";
            textBoxCanhHV.Size = new Size(125, 27);
            textBoxCanhHV.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(125, 59);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 0;
            label2.Text = "Nhập độ dài cạnh";
            // 
            // groupBoxHCN
            // 
            groupBoxHCN.BackColor = Color.FromArgb(128, 255, 255);
            groupBoxHCN.Controls.Add(label11);
            groupBoxHCN.Controls.Add(textBoxCR);
            groupBoxHCN.Controls.Add(label8);
            groupBoxHCN.Controls.Add(label9);
            groupBoxHCN.Controls.Add(textBoxCHCN);
            groupBoxHCN.Controls.Add(textBoxSHCN);
            groupBoxHCN.Controls.Add(textBoxCD);
            groupBoxHCN.Controls.Add(label10);
            groupBoxHCN.Location = new Point(165, 365);
            groupBoxHCN.Name = "groupBoxHCN";
            groupBoxHCN.Size = new Size(511, 200);
            groupBoxHCN.TabIndex = 3;
            groupBoxHCN.TabStop = false;
            groupBoxHCN.Text = "Hình Chữ Nhật";
            groupBoxHCN.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(131, 82);
            label11.Name = "label11";
            label11.Size = new Size(125, 20);
            label11.TabIndex = 7;
            label11.Text = "Nhập chiều rộng";
            // 
            // textBoxCR
            // 
            textBoxCR.Location = new Point(276, 82);
            textBoxCR.Name = "textBoxCR";
            textBoxCR.Size = new Size(125, 27);
            textBoxCR.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(202, 156);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 5;
            label8.Text = "Chu Vi";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(183, 123);
            label9.Name = "label9";
            label9.Size = new Size(73, 20);
            label9.TabIndex = 4;
            label9.Text = "Diện Tích";
            // 
            // textBoxCHCN
            // 
            textBoxCHCN.Enabled = false;
            textBoxCHCN.Location = new Point(276, 149);
            textBoxCHCN.Name = "textBoxCHCN";
            textBoxCHCN.Size = new Size(123, 27);
            textBoxCHCN.TabIndex = 3;
            // 
            // textBoxSHCN
            // 
            textBoxSHCN.Enabled = false;
            textBoxSHCN.Location = new Point(276, 116);
            textBoxSHCN.Name = "textBoxSHCN";
            textBoxSHCN.Size = new Size(123, 27);
            textBoxSHCN.TabIndex = 2;
            // 
            // textBoxCD
            // 
            textBoxCD.Location = new Point(276, 43);
            textBoxCD.Name = "textBoxCD";
            textBoxCD.Size = new Size(125, 27);
            textBoxCD.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(143, 49);
            label10.Name = "label10";
            label10.Size = new Size(113, 20);
            label10.TabIndex = 0;
            label10.Text = "Nhập chiều dài";
            // 
            // groupBoxTamGiac
            // 
            groupBoxTamGiac.BackColor = Color.Aqua;
            groupBoxTamGiac.Controls.Add(textBoxLoaiTG);
            groupBoxTamGiac.Controls.Add(textBoxCC);
            groupBoxTamGiac.Controls.Add(label16);
            groupBoxTamGiac.Controls.Add(label12);
            groupBoxTamGiac.Controls.Add(textBoxCB);
            groupBoxTamGiac.Controls.Add(label13);
            groupBoxTamGiac.Controls.Add(label14);
            groupBoxTamGiac.Controls.Add(textBoxCTG);
            groupBoxTamGiac.Controls.Add(textBoxSTG);
            groupBoxTamGiac.Controls.Add(textBoxCA);
            groupBoxTamGiac.Controls.Add(label15);
            groupBoxTamGiac.Location = new Point(165, 363);
            groupBoxTamGiac.Name = "groupBoxTamGiac";
            groupBoxTamGiac.Size = new Size(511, 276);
            groupBoxTamGiac.TabIndex = 4;
            groupBoxTamGiac.TabStop = false;
            groupBoxTamGiac.Text = "Hình Tam Giác";
            groupBoxTamGiac.Visible = false;
            // 
            // textBoxLoaiTG
            // 
            textBoxLoaiTG.Enabled = false;
            textBoxLoaiTG.Location = new Point(52, 229);
            textBoxLoaiTG.Name = "textBoxLoaiTG";
            textBoxLoaiTG.Size = new Size(411, 27);
            textBoxLoaiTG.TabIndex = 10;
            // 
            // textBoxCC
            // 
            textBoxCC.Location = new Point(368, 89);
            textBoxCC.Name = "textBoxCC";
            textBoxCC.Size = new Size(95, 27);
            textBoxCC.TabIndex = 9;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(360, 55);
            label16.Name = "label16";
            label16.Size = new Size(95, 20);
            label16.TabIndex = 8;
            label16.Text = "Nhập cạnh c";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(202, 52);
            label12.Name = "label12";
            label12.Size = new Size(97, 20);
            label12.TabIndex = 7;
            label12.Text = "Nhập cạnh b";
            // 
            // textBoxCB
            // 
            textBoxCB.Location = new Point(202, 89);
            textBoxCB.Name = "textBoxCB";
            textBoxCB.Size = new Size(97, 27);
            textBoxCB.TabIndex = 6;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(137, 196);
            label13.Name = "label13";
            label13.Size = new Size(54, 20);
            label13.TabIndex = 5;
            label13.Text = "Chu Vi";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(118, 156);
            label14.Name = "label14";
            label14.Size = new Size(73, 20);
            label14.TabIndex = 4;
            label14.Text = "Diện Tích";
            // 
            // textBoxCTG
            // 
            textBoxCTG.Enabled = false;
            textBoxCTG.Location = new Point(202, 189);
            textBoxCTG.Name = "textBoxCTG";
            textBoxCTG.Size = new Size(123, 27);
            textBoxCTG.TabIndex = 3;
            // 
            // textBoxSTG
            // 
            textBoxSTG.Enabled = false;
            textBoxSTG.Location = new Point(202, 156);
            textBoxSTG.Name = "textBoxSTG";
            textBoxSTG.Size = new Size(123, 27);
            textBoxSTG.TabIndex = 2;
            // 
            // textBoxCA
            // 
            textBoxCA.Location = new Point(52, 89);
            textBoxCA.Name = "textBoxCA";
            textBoxCA.Size = new Size(99, 27);
            textBoxCA.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(52, 52);
            label15.Name = "label15";
            label15.Size = new Size(96, 20);
            label15.TabIndex = 0;
            label15.Text = "Nhập cạnh a";
            // 
            // groupBoxHTron
            // 
            groupBoxHTron.BackColor = Color.Aqua;
            groupBoxHTron.Controls.Add(label5);
            groupBoxHTron.Controls.Add(label6);
            groupBoxHTron.Controls.Add(textBoxCTron);
            groupBoxHTron.Controls.Add(textBoxSTron);
            groupBoxHTron.Controls.Add(textBoxR);
            groupBoxHTron.Controls.Add(label7);
            groupBoxHTron.Location = new Point(165, 382);
            groupBoxHTron.Name = "groupBoxHTron";
            groupBoxHTron.Size = new Size(511, 200);
            groupBoxHTron.TabIndex = 3;
            groupBoxHTron.TabStop = false;
            groupBoxHTron.Text = "Hình Tròn";
            groupBoxHTron.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(202, 156);
            label5.Name = "label5";
            label5.Size = new Size(54, 20);
            label5.TabIndex = 5;
            label5.Text = "Chu Vi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(183, 123);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 4;
            label6.Text = "Diện Tích";
            // 
            // textBoxCTron
            // 
            textBoxCTron.Enabled = false;
            textBoxCTron.Location = new Point(276, 156);
            textBoxCTron.Name = "textBoxCTron";
            textBoxCTron.Size = new Size(123, 27);
            textBoxCTron.TabIndex = 3;
            // 
            // textBoxSTron
            // 
            textBoxSTron.Enabled = false;
            textBoxSTron.Location = new Point(276, 116);
            textBoxSTron.Name = "textBoxSTron";
            textBoxSTron.Size = new Size(123, 27);
            textBoxSTron.TabIndex = 2;
            // 
            // textBoxR
            // 
            textBoxR.Location = new Point(276, 59);
            textBoxR.Name = "textBoxR";
            textBoxR.Size = new Size(125, 27);
            textBoxR.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(125, 59);
            label7.Name = "label7";
            label7.Size = new Size(107, 20);
            label7.TabIndex = 0;
            label7.Text = "Nhập độ dài R";
            // 
            // buttonCalculator
            // 
            buttonCalculator.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCalculator.Location = new Point(165, 288);
            buttonCalculator.Name = "buttonCalculator";
            buttonCalculator.Size = new Size(119, 36);
            buttonCalculator.TabIndex = 5;
            buttonCalculator.Text = "Thực Hiện";
            buttonCalculator.UseVisualStyleBackColor = true;
            buttonCalculator.Click += buttonCalculator_Click;
            // 
            // buttonReset
            // 
            buttonReset.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.Location = new Point(367, 288);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(119, 36);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(557, 288);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(119, 36);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(837, 681);
            Controls.Add(groupBoxHCN);
            Controls.Add(groupBoxHTron);
            Controls.Add(buttonExit);
            Controls.Add(groupBoxTamGiac);
            Controls.Add(buttonReset);
            Controls.Add(groupBoxVuong);
            Controls.Add(buttonCalculator);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBoxVuong.ResumeLayout(false);
            groupBoxVuong.PerformLayout();
            groupBoxHCN.ResumeLayout(false);
            groupBoxHCN.PerformLayout();
            groupBoxTamGiac.ResumeLayout(false);
            groupBoxTamGiac.PerformLayout();
            groupBoxHTron.ResumeLayout(false);
            groupBoxHTron.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private RadioButton radioTron;
        private RadioButton radioVuong;
        private GroupBox groupBoxVuong;
        private RadioButton radioTamGiac;
        private RadioButton radioHCN;
        private TextBox textBoxSHV;
        private TextBox textBoxCanhHV;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBoxCHV;
        private GroupBox groupBoxHCN;
        private Label label11;
        private TextBox textBoxCR;
        private Label label8;
        private Label label9;
        private TextBox textBoxCHCN;
        private TextBox textBoxSHCN;
        private TextBox textBoxCD;
        private Label label10;
        private GroupBox groupBoxTamGiac;
        private TextBox textBoxCC;
        private Label label16;
        private Label label12;
        private TextBox textBoxCB;
        private Label label13;
        private Label label14;
        private TextBox textBoxCTG;
        private TextBox textBoxSTG;
        private TextBox textBoxCA;
        private Label label15;
        private TextBox textBoxLoaiTG;
        private Button buttonCalculator;
        private Button buttonReset;
        private Button buttonExit;
        private Label label7;
        private TextBox textBoxR;
        private TextBox textBoxSTron;
        private TextBox textBoxCTron;
        private Label label6;
        private Label label5;
        private GroupBox groupBoxHTron;
    }
}

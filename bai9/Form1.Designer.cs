namespace bai9
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
            label6 = new Label();
            textBoxInput = new TextBox();
            textBoxTong = new TextBox();
            textBoxChan = new TextBox();
            textBoxLe = new TextBox();
            buttonNhap = new Button();
            buttonCt = new Button();
            buttonExit = new Button();
            richTextBoxOutPut = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(283, 49);
            label1.Name = "label1";
            label1.Size = new Size(180, 28);
            label1.TabIndex = 0;
            label1.Text = "Tính Tổng Dãy Số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(144, 163);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập số :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(144, 219);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 2;
            label3.Text = "Dãy số vừa nhập :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(144, 294);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 3;
            label4.Text = "Tổng dãy số :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(141, 333);
            label5.Name = "label5";
            label5.Size = new Size(134, 20);
            label5.TabIndex = 4;
            label5.Text = "Tổng các số chẵn :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(144, 366);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 5;
            label6.Text = "Tổng các số lẻ :";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(298, 156);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(87, 27);
            textBoxInput.TabIndex = 6;
            textBoxInput.KeyDown += new KeyEventHandler(textBoxInput_KeyDown);
            // 
            // textBoxTong
            // 
            textBoxTong.Enabled = false;
            textBoxTong.Location = new Point(298, 287);
            textBoxTong.Name = "textBoxTong";
            textBoxTong.Size = new Size(87, 27);
            textBoxTong.TabIndex = 8;
            // 
            // textBoxChan
            // 
            textBoxChan.Enabled = false;
            textBoxChan.Location = new Point(298, 326);
            textBoxChan.Name = "textBoxChan";
            textBoxChan.Size = new Size(87, 27);
            textBoxChan.TabIndex = 9;
            // 
            // textBoxLe
            // 
            textBoxLe.Enabled = false;
            textBoxLe.Location = new Point(298, 366);
            textBoxLe.Name = "textBoxLe";
            textBoxLe.Size = new Size(87, 27);
            textBoxLe.TabIndex = 10;
            // 
            // buttonNhap
            // 
            buttonNhap.BackColor = SystemColors.ActiveCaption;
            buttonNhap.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonNhap.Location = new Point(525, 154);
            buttonNhap.Name = "buttonNhap";
            buttonNhap.Size = new Size(94, 29);
            buttonNhap.TabIndex = 11;
            buttonNhap.Text = "Nhập";
            buttonNhap.UseVisualStyleBackColor = false;
            buttonNhap.Click += buttonNhap_Click;
            // 
            // buttonCt
            // 
            buttonCt.BackColor = Color.Lime;
            buttonCt.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCt.Location = new Point(298, 430);
            buttonCt.Name = "buttonCt";
            buttonCt.Size = new Size(94, 29);
            buttonCt.TabIndex = 12;
            buttonCt.Text = "Reset";
            buttonCt.UseVisualStyleBackColor = false;
            buttonCt.Click += buttonCt_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(525, 430);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 13;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // richTextBoxOutPut
            // 
            richTextBoxOutPut.Enabled = false;
            richTextBoxOutPut.Location = new Point(298, 216);
            richTextBoxOutPut.Name = "richTextBoxOutPut";
            richTextBoxOutPut.Size = new Size(321, 29);
            richTextBoxOutPut.TabIndex = 14;
            richTextBoxOutPut.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(781, 615);
            Controls.Add(richTextBoxOutPut);
            Controls.Add(buttonExit);
            Controls.Add(buttonCt);
            Controls.Add(buttonNhap);
            Controls.Add(textBoxLe);
            Controls.Add(textBoxChan);
            Controls.Add(textBoxTong);
            Controls.Add(textBoxInput);
            Controls.Add(label6);
            Controls.Add(label5);
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
        private Label label5;
        private Label label6;
        private TextBox textBoxInput;
        private TextBox textBoxTong;
        private TextBox textBoxChan;
        private TextBox textBoxLe;
        private Button buttonNhap;
        private Button buttonCt;
        private Button buttonExit;
        private RichTextBox richTextBoxOutPut;
    }
}

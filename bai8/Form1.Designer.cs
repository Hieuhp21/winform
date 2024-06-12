namespace bai8
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
            textBoxNumber1 = new TextBox();
            textBoxNumber2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            buttonReset = new Button();
            buttonExit = new Button();
            buttonC = new Button();
            buttonN = new Button();
            buttonT = new Button();
            buttonChia = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(305, 31);
            label1.Name = "label1";
            label1.Size = new Size(108, 28);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(132, 108);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 1;
            label2.Text = "Nhập số a:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(132, 152);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 2;
            label3.Text = "Nhập số b:";
            // 
            // textBoxNumber1
            // 
            textBoxNumber1.Location = new Point(231, 108);
            textBoxNumber1.Name = "textBoxNumber1";
            textBoxNumber1.Size = new Size(125, 27);
            textBoxNumber1.TabIndex = 3;
            // 
            // textBoxNumber2
            // 
            textBoxNumber2.Location = new Point(231, 145);
            textBoxNumber2.Name = "textBoxNumber2";
            textBoxNumber2.Size = new Size(125, 27);
            textBoxNumber2.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.Enabled = false;
            textBox1.Location = new Point(231, 214);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(132, 214);
            label4.Name = "label4";
            label4.Size = new Size(78, 23);
            label4.TabIndex = 6;
            label4.Text = "Kết quả :";
            // 
            // buttonReset
            // 
            buttonReset.BackColor = SystemColors.ActiveCaption;
            buttonReset.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReset.Location = new Point(455, 106);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 7;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = false;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.BackColor = Color.Red;
            buttonExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(455, 212);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = false;
            buttonExit.Click += buttonExit_Click;
            // 
            // buttonC
            // 
            buttonC.BackColor = Color.Cyan;
            buttonC.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonC.Location = new Point(87, 292);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(94, 29);
            buttonC.TabIndex = 9;
            buttonC.Text = "Cộng";
            buttonC.UseVisualStyleBackColor = false;
            buttonC.Click += buttonC_Click;
            // 
            // buttonN
            // 
            buttonN.BackColor = Color.Lime;
            buttonN.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonN.Location = new Point(362, 292);
            buttonN.Name = "buttonN";
            buttonN.Size = new Size(94, 29);
            buttonN.TabIndex = 10;
            buttonN.Text = "Nhân";
            buttonN.UseVisualStyleBackColor = false;
            buttonN.Click += buttonN_Click;
            // 
            // buttonT
            // 
            buttonT.BackColor = Color.DodgerBlue;
            buttonT.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonT.Location = new Point(220, 292);
            buttonT.Name = "buttonT";
            buttonT.Size = new Size(94, 29);
            buttonT.TabIndex = 11;
            buttonT.Text = "Trừ";
            buttonT.UseVisualStyleBackColor = false;
            buttonT.Click += buttonT_Click;
            // 
            // buttonChia
            // 
            buttonChia.BackColor = Color.LightCoral;
            buttonChia.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonChia.Location = new Point(506, 292);
            buttonChia.Name = "buttonChia";
            buttonChia.Size = new Size(94, 29);
            buttonChia.TabIndex = 12;
            buttonChia.Text = "Chia";
            buttonChia.UseVisualStyleBackColor = false;
            buttonChia.Click += buttonChia_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 530);
            Controls.Add(buttonChia);
            Controls.Add(buttonT);
            Controls.Add(buttonN);
            Controls.Add(buttonC);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(textBoxNumber2);
            Controls.Add(textBoxNumber1);
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
        private TextBox textBoxNumber1;
        private TextBox textBoxNumber2;
        private TextBox textBox1;
        private Label label4;
        private Button buttonReset;
        private Button buttonExit;
        private Button buttonC;
        private Button buttonN;
        private Button buttonT;
        private Button buttonChia;
    }
}

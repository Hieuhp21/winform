namespace bai15
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
            textBoxInput = new TextBox();
            label2 = new Label();
            radioButtonThường = new RadioButton();
            radioButtonHoa = new RadioButton();
            textBoxOutPut = new TextBox();
            buttonReset = new Button();
            buttonExit = new Button();
            buttonThucHien = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 27);
            label1.Name = "label1";
            label1.Size = new Size(245, 28);
            label1.TabIndex = 0;
            label1.Text = "Chuyển Đổi Hoa Thường";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(157, 124);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(469, 27);
            textBoxInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(323, 82);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhập nội dung :";
            // 
            // radioButtonThường
            // 
            radioButtonThường.AutoSize = true;
            radioButtonThường.Location = new Point(248, 208);
            radioButtonThường.Name = "radioButtonThường";
            radioButtonThường.Size = new Size(111, 24);
            radioButtonThường.TabIndex = 3;
            radioButtonThường.TabStop = true;
            radioButtonThường.Text = "Chữ Thường";
            radioButtonThường.UseVisualStyleBackColor = true;
            // 
            // radioButtonHoa
            // 
            radioButtonHoa.AutoSize = true;
            radioButtonHoa.Location = new Point(457, 208);
            radioButtonHoa.Name = "radioButtonHoa";
            radioButtonHoa.Size = new Size(88, 24);
            radioButtonHoa.TabIndex = 4;
            radioButtonHoa.TabStop = true;
            radioButtonHoa.Text = "Chữ Hoa";
            radioButtonHoa.UseVisualStyleBackColor = true;
            // 
            // textBoxOutPut
            // 
            textBoxOutPut.Enabled = false;
            textBoxOutPut.Location = new Point(157, 336);
            textBoxOutPut.Name = "textBoxOutPut";
            textBoxOutPut.Size = new Size(469, 27);
            textBoxOutPut.TabIndex = 5;
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(344, 266);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 6;
            buttonReset.Text = "Xóa";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonExit
            // 
            buttonExit.Location = new Point(532, 266);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 29);
            buttonExit.TabIndex = 7;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            // 
            // buttonThucHien
            // 
            buttonThucHien.Location = new Point(157, 266);
            buttonThucHien.Name = "buttonThucHien";
            buttonThucHien.Size = new Size(94, 29);
            buttonThucHien.TabIndex = 8;
            buttonThucHien.Text = "Thực Hiện";
            buttonThucHien.UseVisualStyleBackColor = true;
            buttonThucHien.Click += buttonThucHien_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonThucHien);
            Controls.Add(buttonExit);
            Controls.Add(buttonReset);
            Controls.Add(textBoxOutPut);
            Controls.Add(radioButtonHoa);
            Controls.Add(radioButtonThường);
            Controls.Add(label2);
            Controls.Add(textBoxInput);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxInput;
        private Label label2;
        private RadioButton radioButtonThường;
        private RadioButton radioButtonHoa;
        private TextBox textBoxOutPut;
        private Button buttonReset;
        private Button buttonExit;
        private Button buttonThucHien;
    }
}

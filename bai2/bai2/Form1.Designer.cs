namespace bai2
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
            lbname = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxName = new TextBox();
            textBoxFavorit = new TextBox();
            dateOfBirth = new DateTimePicker();
            buttonShow = new Button();
            buttonExit = new Button();
            textBoxkq = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(260, 40);
            label1.Name = "label1";
            label1.Size = new Size(104, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbname
            // 
            lbname.AutoSize = true;
            lbname.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbname.Location = new Point(96, 111);
            lbname.Name = "lbname";
            lbname.Size = new Size(87, 23);
            lbname.TabIndex = 1;
            lbname.Text = "Họ và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(96, 205);
            label2.Name = "label2";
            label2.Size = new Size(75, 23);
            label2.TabIndex = 2;
            label2.Text = "Sở Thích";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(96, 156);
            label3.Name = "label3";
            label3.Size = new Size(85, 23);
            label3.TabIndex = 3;
            label3.Text = "Năm Sinh";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(236, 113);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(269, 27);
            textBoxName.TabIndex = 4;
            // 
            // textBoxFavorit
            // 
            textBoxFavorit.Location = new Point(236, 201);
            textBoxFavorit.Name = "textBoxFavorit";
            textBoxFavorit.Size = new Size(269, 27);
            textBoxFavorit.TabIndex = 5;
            // 
            // dateOfBirth
            // 
            dateOfBirth.Location = new Point(236, 156);
            dateOfBirth.Name = "dateOfBirth";
            dateOfBirth.Size = new Size(269, 27);
            dateOfBirth.TabIndex = 6;
            // 
            // buttonShow
            // 
            buttonShow.AutoSize = true;
            buttonShow.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonShow.Location = new Point(236, 270);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(94, 33);
            buttonShow.TabIndex = 7;
            buttonShow.Text = "Xem";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // buttonExit
            // 
            buttonExit.AutoSize = true;
            buttonExit.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonExit.Location = new Point(411, 270);
            buttonExit.Name = "buttonExit";
            buttonExit.Size = new Size(94, 33);
            buttonExit.TabIndex = 8;
            buttonExit.Text = "Thoát";
            buttonExit.UseVisualStyleBackColor = true;
            buttonExit.Click += buttonExit_Click;
            // 
            // textBoxkq
            // 
            textBoxkq.Location = new Point(236, 353);
            textBoxkq.Multiline = true;
            textBoxkq.Name = "textBoxkq";
            textBoxkq.ReadOnly = true;
            textBoxkq.Size = new Size(269, 101);
            textBoxkq.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 506);
            Controls.Add(textBoxkq);
            Controls.Add(buttonExit);
            Controls.Add(buttonShow);
            Controls.Add(dateOfBirth);
            Controls.Add(textBoxFavorit);
            Controls.Add(textBoxName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbname);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbname;
        private Label label2;
        private Label label3;
        private TextBox textBoxName;
        private TextBox textBoxFavorit;
        private DateTimePicker dateOfBirth;
        private Button buttonShow;
        private Button buttonExit;
        private TextBox textBoxkq;
    }
}

﻿namespace bai1
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            exit = new Button();
            login = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(88, 50);
            label1.Name = "label1";
            label1.Size = new Size(211, 28);
            label1.TabIndex = 0;
            label1.Text = "Thông tin đăng nhập";
            label1.UseMnemonic = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(88, 130);
            label2.Name = "label2";
            label2.Size = new Size(140, 23);
            label2.TabIndex = 1;
            label2.Text = "Tên người dùng :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(88, 176);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(256, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(225, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(256, 176);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(225, 27);
            textBox2.TabIndex = 4;
            textBox2.UseSystemPasswordChar = true;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            exit.Location = new Point(376, 267);
            exit.Name = "exit";
            exit.Size = new Size(105, 33);
            exit.TabIndex = 6;
            exit.Text = "Thoát";
            exit.UseVisualStyleBackColor = true;
            exit.Click += new System.EventHandler(exit_Click);
            // 
            // login
            // 
            login.AutoSize = true;
            login.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            login.Location = new Point(256, 267);
            login.Name = "login";
            login.Size = new Size(105, 33);
            login.TabIndex = 7;
            login.Text = "Đăng nhập";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(596, 401);
            Controls.Add(login);
            Controls.Add(exit);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Hệ thống đăng nhập";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button exit;
        private Button login;
    }
}

namespace bai10
{
    partial class InputForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
      
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonSubmit;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            labelInput = new Label();
            textBoxInput = new TextBox();
            buttonSubmit = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(13, 13);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(147, 20);
            labelInput.TabIndex = 0;
            labelInput.Text = "Nhập dãy số nguyên:";
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(16, 36);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(420, 29);
            textBoxInput.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(229, 84);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(84, 31);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Ok";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(352, 84);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(84, 31);
            buttonCancel.TabIndex = 3;
            buttonCancel.Text = "Cancel";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // InputForm
            // 
            ClientSize = new Size(468, 150);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSubmit);
            Controls.Add(textBoxInput);
            Controls.Add(labelInput);
            Name = "InputForm";
            Text = "Nhập dãy số";
            ResumeLayout(false);
            PerformLayout();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>


        #endregion

        private Button buttonCancel;
    }
}
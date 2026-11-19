namespace WinFormsApp3
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
            textBox1 = new TextBox();
            btnOk = new Button();
            txtFileContent = new TextBox();
            txtMyInput = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(179, 121);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(449, 23);
            textBox1.TabIndex = 0;
            // 
            // btnOk
            // 
            btnOk.Location = new Point(291, 173);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(195, 100);
            btnOk.TabIndex = 1;
            btnOk.Text = "button1";
            btnOk.UseVisualStyleBackColor = true;
            // 
            // txtFileContent
            // 
            txtFileContent.Location = new Point(199, 331);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.Size = new Size(411, 78);
            txtFileContent.TabIndex = 2;
            // 
            // txtMyInput
            // 
            txtMyInput.AutoSize = true;
            txtMyInput.Location = new Point(328, 85);
            txtMyInput.Name = "txtMyInput";
            txtMyInput.Size = new Size(135, 15);
            txtMyInput.TabIndex = 3;
            txtMyInput.Text = "Введіть шлях до файлу:";
            txtMyInput.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(360, 294);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 4;
            label2.Text = "Вміст файлу:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(txtMyInput);
            Controls.Add(txtFileContent);
            Controls.Add(btnOk);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnOk;
        private TextBox txtFileContent;
        private Label txtMyInput;
        private Label label2;
    }
}

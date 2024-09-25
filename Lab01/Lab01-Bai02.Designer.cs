namespace Lab01
{
    partial class Lab01_Bai02
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            input_textBox = new TextBox();
            read_btn = new Button();
            label2 = new Label();
            output_textBox = new TextBox();
            clear_btn = new Button();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(285, 21);
            label1.TabIndex = 0;
            label1.Text = "Nhập vào số nguyên từ 1 đến 10 chữ số";
            // 
            // input_textBox
            // 
            input_textBox.Location = new Point(329, 29);
            input_textBox.Margin = new Padding(4);
            input_textBox.MaxLength = 10;
            input_textBox.Name = "input_textBox";
            input_textBox.Size = new Size(181, 29);
            input_textBox.TabIndex = 1;
            // 
            // read_btn
            // 
            read_btn.Location = new Point(540, 29);
            read_btn.Margin = new Padding(4);
            read_btn.Name = "read_btn";
            read_btn.Size = new Size(120, 48);
            read_btn.TabIndex = 2;
            read_btn.Text = "Đọc";
            read_btn.UseVisualStyleBackColor = true;
            read_btn.Click += read_btn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 3;
            label2.Text = "Kết quả";
            // 
            // output_textBox
            // 
            output_textBox.Location = new Point(36, 160);
            output_textBox.Margin = new Padding(4);
            output_textBox.Name = "output_textBox";
            output_textBox.ReadOnly = true;
            output_textBox.Size = new Size(474, 29);
            output_textBox.TabIndex = 4;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(540, 85);
            clear_btn.Margin = new Padding(4);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(120, 48);
            clear_btn.TabIndex = 5;
            clear_btn.Text = "Xoá";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(540, 141);
            exit_btn.Margin = new Padding(4);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(120, 48);
            exit_btn.TabIndex = 6;
            exit_btn.Text = "Thoát";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // Lab01_Bai02
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 223);
            Controls.Add(exit_btn);
            Controls.Add(clear_btn);
            Controls.Add(output_textBox);
            Controls.Add(label2);
            Controls.Add(read_btn);
            Controls.Add(input_textBox);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Lab01_Bai02";
            Padding = new Padding(32);
            Text = "BaiTH2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox input_textBox;
        private Button read_btn;
        private Label label2;
        private TextBox output_textBox;
        private Button clear_btn;
        private Button exit_btn;
    }
}
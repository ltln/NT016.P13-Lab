namespace Lab01
{
    partial class Lab01_Bai01
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
            num1_label = new Label();
            num2_label = new Label();
            resultMax_label = new Label();
            num1_textBox = new TextBox();
            num2_textBox = new TextBox();
            num3_textBox = new TextBox();
            num3_label = new Label();
            resultMin_label = new Label();
            resultMax_textBox = new TextBox();
            resultMin_textBox = new TextBox();
            find_btn = new Button();
            clear_btn = new Button();
            exit_btn = new Button();
            SuspendLayout();
            // 
            // num1_label
            // 
            num1_label.AutoSize = true;
            num1_label.Location = new Point(36, 32);
            num1_label.Margin = new Padding(4, 0, 4, 0);
            num1_label.Name = "num1_label";
            num1_label.Size = new Size(90, 21);
            num1_label.TabIndex = 0;
            num1_label.Text = "Số thứ nhất";
            // 
            // num2_label
            // 
            num2_label.AutoSize = true;
            num2_label.Location = new Point(344, 32);
            num2_label.Margin = new Padding(4, 0, 4, 0);
            num2_label.Name = "num2_label";
            num2_label.Size = new Size(80, 21);
            num2_label.TabIndex = 1;
            num2_label.Text = "Số thứ hai";
            // 
            // resultMax_label
            // 
            resultMax_label.AutoSize = true;
            resultMax_label.Location = new Point(171, 149);
            resultMax_label.Margin = new Padding(4, 0, 4, 0);
            resultMax_label.Name = "resultMax_label";
            resultMax_label.Size = new Size(90, 21);
            resultMax_label.TabIndex = 2;
            resultMax_label.Text = "Số lớn nhất";
            // 
            // num1_textBox
            // 
            num1_textBox.Location = new Point(134, 29);
            num1_textBox.Margin = new Padding(4);
            num1_textBox.Name = "num1_textBox";
            num1_textBox.Size = new Size(127, 29);
            num1_textBox.TabIndex = 3;
            // 
            // num2_textBox
            // 
            num2_textBox.Location = new Point(432, 29);
            num2_textBox.Margin = new Padding(4);
            num2_textBox.Name = "num2_textBox";
            num2_textBox.Size = new Size(127, 29);
            num2_textBox.TabIndex = 4;
            // 
            // num3_textBox
            // 
            num3_textBox.Location = new Point(710, 29);
            num3_textBox.Margin = new Padding(4);
            num3_textBox.Name = "num3_textBox";
            num3_textBox.Size = new Size(127, 29);
            num3_textBox.TabIndex = 5;
            // 
            // num3_label
            // 
            num3_label.AutoSize = true;
            num3_label.Location = new Point(626, 32);
            num3_label.Margin = new Padding(4, 0, 4, 0);
            num3_label.Name = "num3_label";
            num3_label.Size = new Size(76, 21);
            num3_label.TabIndex = 6;
            num3_label.Text = "Số thứ ba";
            // 
            // resultMin_label
            // 
            resultMin_label.AutoSize = true;
            resultMin_label.Location = new Point(482, 149);
            resultMin_label.Margin = new Padding(4, 0, 4, 0);
            resultMin_label.Name = "resultMin_label";
            resultMin_label.Size = new Size(94, 21);
            resultMin_label.TabIndex = 7;
            resultMin_label.Text = "Số nhỏ nhất";
            // 
            // resultMax_textBox
            // 
            resultMax_textBox.Location = new Point(269, 146);
            resultMax_textBox.Margin = new Padding(4);
            resultMax_textBox.Name = "resultMax_textBox";
            resultMax_textBox.ReadOnly = true;
            resultMax_textBox.Size = new Size(127, 29);
            resultMax_textBox.TabIndex = 8;
            // 
            // resultMin_textBox
            // 
            resultMin_textBox.Location = new Point(584, 146);
            resultMin_textBox.Margin = new Padding(4);
            resultMin_textBox.Name = "resultMin_textBox";
            resultMin_textBox.ReadOnly = true;
            resultMin_textBox.Size = new Size(127, 29);
            resultMin_textBox.TabIndex = 9;
            // 
            // find_btn
            // 
            find_btn.Location = new Point(275, 75);
            find_btn.Margin = new Padding(4);
            find_btn.Name = "find_btn";
            find_btn.Size = new Size(120, 48);
            find_btn.TabIndex = 10;
            find_btn.Text = "Tìm";
            find_btn.UseVisualStyleBackColor = true;
            find_btn.Click += find_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(403, 75);
            clear_btn.Margin = new Padding(4);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(120, 48);
            clear_btn.TabIndex = 11;
            clear_btn.Text = "Xoá";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(531, 75);
            exit_btn.Margin = new Padding(4);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(120, 48);
            exit_btn.TabIndex = 12;
            exit_btn.Text = "Thoát";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // Lab01_Bai01
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 213);
            Controls.Add(exit_btn);
            Controls.Add(clear_btn);
            Controls.Add(find_btn);
            Controls.Add(resultMin_textBox);
            Controls.Add(resultMax_textBox);
            Controls.Add(resultMin_label);
            Controls.Add(num3_label);
            Controls.Add(num3_textBox);
            Controls.Add(num2_textBox);
            Controls.Add(num1_textBox);
            Controls.Add(resultMax_label);
            Controls.Add(num2_label);
            Controls.Add(num1_label);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Lab01_Bai01";
            Padding = new Padding(32);
            ShowInTaskbar = false;
            Text = "BaiTH1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label num1_label;
        private Label num2_label;
        private Label resultMax_label;
        private TextBox num1_textBox;
        private TextBox num2_textBox;
        private TextBox num3_textBox;
        private Label num3_label;
        private Label resultMin_label;
        private TextBox resultMax_textBox;
        private TextBox resultMin_textBox;
        private Button find_btn;
        private Button clear_btn;
        private Button exit_btn;
    }
}
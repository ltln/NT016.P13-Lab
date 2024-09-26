namespace Lab01
{
    partial class Lab01_Bai04
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
            label2 = new Label();
            resultBox = new GroupBox();
            resultA_label = new Label();
            valueA_textBox = new TextBox();
            valueB_textBox = new TextBox();
            calculate_btn = new Button();
            clear_btn = new Button();
            exit_btn = new Button();
            resultB_label = new Label();
            resultS1_label = new Label();
            resultS2_label = new Label();
            resultS3_label = new Label();
            resultBox.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 32);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 0;
            label1.Text = "Nhập A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 32);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 1;
            label2.Text = "Nhập B";
            // 
            // resultBox
            // 
            resultBox.Controls.Add(resultS3_label);
            resultBox.Controls.Add(resultS2_label);
            resultBox.Controls.Add(resultS1_label);
            resultBox.Controls.Add(resultB_label);
            resultBox.Controls.Add(resultA_label);
            resultBox.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultBox.Location = new Point(36, 183);
            resultBox.Margin = new Padding(4);
            resultBox.Name = "resultBox";
            resultBox.Padding = new Padding(4);
            resultBox.Size = new Size(475, 160);
            resultBox.TabIndex = 2;
            resultBox.TabStop = false;
            resultBox.Text = "KẾT QUẢ";
            // 
            // resultA_label
            // 
            resultA_label.AutoSize = true;
            resultA_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultA_label.ForeColor = SystemColors.Highlight;
            resultA_label.Location = new Point(18, 35);
            resultA_label.Name = "resultA_label";
            resultA_label.Size = new Size(34, 17);
            resultA_label.TabIndex = 0;
            resultA_label.Text = "!A =";
            // 
            // valueA_textBox
            // 
            valueA_textBox.Location = new Point(106, 29);
            valueA_textBox.Margin = new Padding(4);
            valueA_textBox.Name = "valueA_textBox";
            valueA_textBox.Size = new Size(127, 29);
            valueA_textBox.TabIndex = 3;
            // 
            // valueB_textBox
            // 
            valueB_textBox.Location = new Point(384, 29);
            valueB_textBox.Margin = new Padding(4);
            valueB_textBox.Name = "valueB_textBox";
            valueB_textBox.Size = new Size(127, 29);
            valueB_textBox.TabIndex = 4;
            // 
            // calculate_btn
            // 
            calculate_btn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            calculate_btn.Location = new Point(36, 93);
            calculate_btn.Margin = new Padding(4);
            calculate_btn.Name = "calculate_btn";
            calculate_btn.Size = new Size(267, 48);
            calculate_btn.TabIndex = 5;
            calculate_btn.Text = "Tính các giá trị";
            calculate_btn.UseVisualStyleBackColor = true;
            calculate_btn.Click += calculate_btn_Click;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(311, 93);
            clear_btn.Margin = new Padding(4);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(96, 48);
            clear_btn.TabIndex = 6;
            clear_btn.Text = "Xoá";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // exit_btn
            // 
            exit_btn.Location = new Point(415, 93);
            exit_btn.Margin = new Padding(4);
            exit_btn.Name = "exit_btn";
            exit_btn.Size = new Size(96, 48);
            exit_btn.TabIndex = 7;
            exit_btn.Text = "Thoát";
            exit_btn.UseVisualStyleBackColor = true;
            exit_btn.Click += exit_btn_Click;
            // 
            // resultB_label
            // 
            resultB_label.AutoSize = true;
            resultB_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultB_label.ForeColor = SystemColors.Highlight;
            resultB_label.Location = new Point(227, 35);
            resultB_label.Name = "resultB_label";
            resultB_label.Size = new Size(33, 17);
            resultB_label.TabIndex = 1;
            resultB_label.Text = "!B =";
            // 
            // resultS1_label
            // 
            resultS1_label.AutoSize = true;
            resultS1_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultS1_label.ForeColor = SystemColors.Highlight;
            resultS1_label.Location = new Point(18, 64);
            resultS1_label.Name = "resultS1_label";
            resultS1_label.Size = new Size(39, 17);
            resultS1_label.TabIndex = 2;
            resultS1_label.Text = "S1 = ";
            // 
            // resultS2_label
            // 
            resultS2_label.AutoSize = true;
            resultS2_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultS2_label.ForeColor = SystemColors.Highlight;
            resultS2_label.Location = new Point(18, 93);
            resultS2_label.Name = "resultS2_label";
            resultS2_label.Size = new Size(39, 17);
            resultS2_label.TabIndex = 3;
            resultS2_label.Text = "S2 = ";
            // 
            // resultS3_label
            // 
            resultS3_label.AutoSize = true;
            resultS3_label.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resultS3_label.ForeColor = SystemColors.Highlight;
            resultS3_label.Location = new Point(18, 124);
            resultS3_label.Name = "resultS3_label";
            resultS3_label.Size = new Size(39, 17);
            resultS3_label.TabIndex = 4;
            resultS3_label.Text = "S3 = ";
            // 
            // Lab01_Bai04
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(564, 406);
            Controls.Add(exit_btn);
            Controls.Add(clear_btn);
            Controls.Add(calculate_btn);
            Controls.Add(valueB_textBox);
            Controls.Add(valueA_textBox);
            Controls.Add(resultBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Lab01_Bai04";
            Padding = new Padding(32);
            ShowInTaskbar = false;
            Text = "BaiTH4";
            resultBox.ResumeLayout(false);
            resultBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private GroupBox resultBox;
        private TextBox valueA_textBox;
        private TextBox valueB_textBox;
        private Button calculate_btn;
        private Button clear_btn;
        private Button exit_btn;
        private Label resultA_label;
        private Label resultS2_label;
        private Label resultS1_label;
        private Label resultB_label;
        private Label resultS3_label;
    }
}
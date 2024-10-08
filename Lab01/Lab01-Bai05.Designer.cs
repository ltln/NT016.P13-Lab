namespace Lab01
{
    partial class Lab01_Bai05
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
            digit_7_Btn = new Button();
            groupBox1 = new GroupBox();
            op_Divide_Btn = new Button();
            clearEntry_Btn = new Button();
            clear_Btn = new Button();
            backspace_Btn = new Button();
            op_Multiply_Btn = new Button();
            calculate_Btn = new Button();
            op_Addition_Btn = new Button();
            op_Subtract_Btn = new Button();
            op_Negate_Btn = new Button();
            digit_Point_Btn = new Button();
            digit_4_Btn = new Button();
            digit_6_Btn = new Button();
            digit_1_Btn = new Button();
            digit_2_Btn = new Button();
            digit_3_Btn = new Button();
            digit_0_Btn = new Button();
            digit_5_Btn = new Button();
            digit_9_Btn = new Button();
            digit_8_Btn = new Button();
            entriesLabel = new Label();
            entryBox = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // digit_7_Btn
            // 
            digit_7_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_7_Btn.Location = new Point(11, 77);
            digit_7_Btn.Margin = new Padding(4);
            digit_7_Btn.Name = "digit_7_Btn";
            digit_7_Btn.Size = new Size(80, 48);
            digit_7_Btn.TabIndex = 0;
            digit_7_Btn.Text = "7";
            digit_7_Btn.UseVisualStyleBackColor = true;
            digit_7_Btn.Click += ButtonClickListener;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(op_Divide_Btn);
            groupBox1.Controls.Add(clearEntry_Btn);
            groupBox1.Controls.Add(clear_Btn);
            groupBox1.Controls.Add(backspace_Btn);
            groupBox1.Controls.Add(op_Multiply_Btn);
            groupBox1.Controls.Add(calculate_Btn);
            groupBox1.Controls.Add(op_Addition_Btn);
            groupBox1.Controls.Add(op_Subtract_Btn);
            groupBox1.Controls.Add(op_Negate_Btn);
            groupBox1.Controls.Add(digit_Point_Btn);
            groupBox1.Controls.Add(digit_4_Btn);
            groupBox1.Controls.Add(digit_6_Btn);
            groupBox1.Controls.Add(digit_1_Btn);
            groupBox1.Controls.Add(digit_2_Btn);
            groupBox1.Controls.Add(digit_3_Btn);
            groupBox1.Controls.Add(digit_0_Btn);
            groupBox1.Controls.Add(digit_5_Btn);
            groupBox1.Controls.Add(digit_9_Btn);
            groupBox1.Controls.Add(digit_8_Btn);
            groupBox1.Controls.Add(digit_7_Btn);
            groupBox1.Location = new Point(12, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(368, 307);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // op_Divide_Btn
            // 
            op_Divide_Btn.BackColor = SystemColors.Control;
            op_Divide_Btn.Font = new Font("Segoe UI", 16F);
            op_Divide_Btn.Location = new Point(275, 77);
            op_Divide_Btn.Margin = new Padding(4);
            op_Divide_Btn.Name = "op_Divide_Btn";
            op_Divide_Btn.Size = new Size(80, 48);
            op_Divide_Btn.TabIndex = 31;
            op_Divide_Btn.Text = "/";
            op_Divide_Btn.UseVisualStyleBackColor = false;
            op_Divide_Btn.Click += ButtonClickListener;
            // 
            // clearEntry_Btn
            // 
            clearEntry_Btn.BackColor = SystemColors.Control;
            clearEntry_Btn.Font = new Font("Segoe UI", 14F);
            clearEntry_Btn.Location = new Point(187, 21);
            clearEntry_Btn.Margin = new Padding(4);
            clearEntry_Btn.Name = "clearEntry_Btn";
            clearEntry_Btn.Size = new Size(80, 48);
            clearEntry_Btn.TabIndex = 30;
            clearEntry_Btn.Text = "CE";
            clearEntry_Btn.UseVisualStyleBackColor = false;
            clearEntry_Btn.Click += clearEntry_Btn_Click;
            // 
            // clear_Btn
            // 
            clear_Btn.BackColor = SystemColors.Control;
            clear_Btn.Font = new Font("Segoe UI", 14F);
            clear_Btn.Location = new Point(99, 21);
            clear_Btn.Margin = new Padding(4);
            clear_Btn.Name = "clear_Btn";
            clear_Btn.Size = new Size(80, 48);
            clear_Btn.TabIndex = 27;
            clear_Btn.Text = "C";
            clear_Btn.UseVisualStyleBackColor = false;
            clear_Btn.Click += clear_Btn_Click;
            // 
            // backspace_Btn
            // 
            backspace_Btn.BackColor = SystemColors.Control;
            backspace_Btn.Font = new Font("Segoe UI", 16F);
            backspace_Btn.Location = new Point(275, 21);
            backspace_Btn.Margin = new Padding(4);
            backspace_Btn.Name = "backspace_Btn";
            backspace_Btn.Size = new Size(80, 48);
            backspace_Btn.TabIndex = 26;
            backspace_Btn.Text = "←";
            backspace_Btn.UseVisualStyleBackColor = false;
            backspace_Btn.Click += backspace_Btn_Click;
            // 
            // op_Multiply_Btn
            // 
            op_Multiply_Btn.BackColor = SystemColors.Control;
            op_Multiply_Btn.Font = new Font("Segoe UI", 16F);
            op_Multiply_Btn.Location = new Point(275, 133);
            op_Multiply_Btn.Margin = new Padding(4);
            op_Multiply_Btn.Name = "op_Multiply_Btn";
            op_Multiply_Btn.Size = new Size(80, 48);
            op_Multiply_Btn.TabIndex = 23;
            op_Multiply_Btn.Text = "x";
            op_Multiply_Btn.UseVisualStyleBackColor = false;
            op_Multiply_Btn.Click += ButtonClickListener;
            // 
            // calculate_Btn
            // 
            calculate_Btn.BackColor = SystemColors.ActiveCaption;
            calculate_Btn.Font = new Font("Segoe UI", 16F);
            calculate_Btn.Location = new Point(187, 245);
            calculate_Btn.Margin = new Padding(4);
            calculate_Btn.Name = "calculate_Btn";
            calculate_Btn.Size = new Size(80, 48);
            calculate_Btn.TabIndex = 15;
            calculate_Btn.Text = "=";
            calculate_Btn.UseVisualStyleBackColor = false;
            calculate_Btn.Click += calculate_Btn_Click;
            // 
            // op_Addition_Btn
            // 
            op_Addition_Btn.BackColor = SystemColors.Control;
            op_Addition_Btn.Font = new Font("Segoe UI", 16F);
            op_Addition_Btn.Location = new Point(275, 245);
            op_Addition_Btn.Margin = new Padding(4);
            op_Addition_Btn.Name = "op_Addition_Btn";
            op_Addition_Btn.Size = new Size(80, 48);
            op_Addition_Btn.TabIndex = 14;
            op_Addition_Btn.Text = "+";
            op_Addition_Btn.UseVisualStyleBackColor = false;
            op_Addition_Btn.Click += ButtonClickListener;
            // 
            // op_Subtract_Btn
            // 
            op_Subtract_Btn.BackColor = SystemColors.Control;
            op_Subtract_Btn.Font = new Font("Segoe UI", 16F);
            op_Subtract_Btn.Location = new Point(275, 189);
            op_Subtract_Btn.Margin = new Padding(4);
            op_Subtract_Btn.Name = "op_Subtract_Btn";
            op_Subtract_Btn.RightToLeft = RightToLeft.No;
            op_Subtract_Btn.Size = new Size(80, 48);
            op_Subtract_Btn.TabIndex = 13;
            op_Subtract_Btn.Text = "-";
            op_Subtract_Btn.UseVisualStyleBackColor = false;
            op_Subtract_Btn.Click += ButtonClickListener;
            // 
            // op_Negate_Btn
            // 
            op_Negate_Btn.BackColor = SystemColors.Control;
            op_Negate_Btn.Font = new Font("Segoe UI", 14F);
            op_Negate_Btn.Location = new Point(11, 21);
            op_Negate_Btn.Margin = new Padding(4);
            op_Negate_Btn.Name = "op_Negate_Btn";
            op_Negate_Btn.Size = new Size(80, 48);
            op_Negate_Btn.TabIndex = 11;
            op_Negate_Btn.Text = "+/-";
            op_Negate_Btn.UseVisualStyleBackColor = false;
            op_Negate_Btn.Click += ButtonClickListener;
            // 
            // digit_Point_Btn
            // 
            digit_Point_Btn.BackColor = SystemColors.Control;
            digit_Point_Btn.Font = new Font("Segoe UI", 16F);
            digit_Point_Btn.Location = new Point(11, 245);
            digit_Point_Btn.Margin = new Padding(4);
            digit_Point_Btn.Name = "digit_Point_Btn";
            digit_Point_Btn.Size = new Size(80, 48);
            digit_Point_Btn.TabIndex = 10;
            digit_Point_Btn.Text = ".";
            digit_Point_Btn.UseVisualStyleBackColor = false;
            digit_Point_Btn.Click += ButtonClickListener;
            // 
            // digit_4_Btn
            // 
            digit_4_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_4_Btn.Location = new Point(11, 133);
            digit_4_Btn.Margin = new Padding(4);
            digit_4_Btn.Name = "digit_4_Btn";
            digit_4_Btn.Size = new Size(80, 48);
            digit_4_Btn.TabIndex = 9;
            digit_4_Btn.Text = "4";
            digit_4_Btn.UseVisualStyleBackColor = true;
            digit_4_Btn.Click += ButtonClickListener;
            // 
            // digit_6_Btn
            // 
            digit_6_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_6_Btn.Location = new Point(187, 133);
            digit_6_Btn.Margin = new Padding(4);
            digit_6_Btn.Name = "digit_6_Btn";
            digit_6_Btn.Size = new Size(80, 48);
            digit_6_Btn.TabIndex = 8;
            digit_6_Btn.Text = "6";
            digit_6_Btn.UseVisualStyleBackColor = true;
            digit_6_Btn.Click += ButtonClickListener;
            // 
            // digit_1_Btn
            // 
            digit_1_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_1_Btn.Location = new Point(11, 189);
            digit_1_Btn.Margin = new Padding(4);
            digit_1_Btn.Name = "digit_1_Btn";
            digit_1_Btn.Size = new Size(80, 48);
            digit_1_Btn.TabIndex = 7;
            digit_1_Btn.Text = "1";
            digit_1_Btn.UseVisualStyleBackColor = true;
            digit_1_Btn.Click += ButtonClickListener;
            // 
            // digit_2_Btn
            // 
            digit_2_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_2_Btn.Location = new Point(99, 189);
            digit_2_Btn.Margin = new Padding(4);
            digit_2_Btn.Name = "digit_2_Btn";
            digit_2_Btn.Size = new Size(80, 48);
            digit_2_Btn.TabIndex = 6;
            digit_2_Btn.Text = "2";
            digit_2_Btn.UseVisualStyleBackColor = true;
            digit_2_Btn.Click += ButtonClickListener;
            // 
            // digit_3_Btn
            // 
            digit_3_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_3_Btn.Location = new Point(187, 189);
            digit_3_Btn.Margin = new Padding(4);
            digit_3_Btn.Name = "digit_3_Btn";
            digit_3_Btn.Size = new Size(80, 48);
            digit_3_Btn.TabIndex = 5;
            digit_3_Btn.Text = "3";
            digit_3_Btn.UseVisualStyleBackColor = true;
            digit_3_Btn.Click += ButtonClickListener;
            // 
            // digit_0_Btn
            // 
            digit_0_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_0_Btn.Location = new Point(99, 245);
            digit_0_Btn.Margin = new Padding(4);
            digit_0_Btn.Name = "digit_0_Btn";
            digit_0_Btn.Size = new Size(80, 48);
            digit_0_Btn.TabIndex = 4;
            digit_0_Btn.Text = "0";
            digit_0_Btn.UseVisualStyleBackColor = true;
            digit_0_Btn.Click += ButtonClickListener;
            // 
            // digit_5_Btn
            // 
            digit_5_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_5_Btn.Location = new Point(99, 133);
            digit_5_Btn.Margin = new Padding(4);
            digit_5_Btn.Name = "digit_5_Btn";
            digit_5_Btn.Size = new Size(80, 48);
            digit_5_Btn.TabIndex = 3;
            digit_5_Btn.Text = "5";
            digit_5_Btn.UseVisualStyleBackColor = true;
            digit_5_Btn.Click += ButtonClickListener;
            // 
            // digit_9_Btn
            // 
            digit_9_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_9_Btn.Location = new Point(187, 77);
            digit_9_Btn.Margin = new Padding(4);
            digit_9_Btn.Name = "digit_9_Btn";
            digit_9_Btn.Size = new Size(80, 48);
            digit_9_Btn.TabIndex = 2;
            digit_9_Btn.Text = "9";
            digit_9_Btn.UseVisualStyleBackColor = true;
            digit_9_Btn.Click += ButtonClickListener;
            // 
            // digit_8_Btn
            // 
            digit_8_Btn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            digit_8_Btn.Location = new Point(99, 77);
            digit_8_Btn.Margin = new Padding(4);
            digit_8_Btn.Name = "digit_8_Btn";
            digit_8_Btn.Size = new Size(80, 48);
            digit_8_Btn.TabIndex = 1;
            digit_8_Btn.Text = "8";
            digit_8_Btn.UseVisualStyleBackColor = true;
            digit_8_Btn.Click += ButtonClickListener;
            // 
            // entriesLabel
            // 
            entriesLabel.AutoSize = true;
            entriesLabel.Font = new Font("Segoe UI", 10F);
            entriesLabel.Location = new Point(12, 9);
            entriesLabel.Name = "entriesLabel";
            entriesLabel.Size = new Size(0, 19);
            entriesLabel.TabIndex = 2;
            // 
            // entryBox
            // 
            entryBox.Font = new Font("Segoe UI", 18F);
            entryBox.Location = new Point(12, 58);
            entryBox.Name = "entryBox";
            entryBox.ReadOnly = true;
            entryBox.RightToLeft = RightToLeft.No;
            entryBox.Size = new Size(368, 39);
            entryBox.TabIndex = 3;
            entryBox.Text = "0";
            entryBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Lab01_Bai05
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(394, 420);
            Controls.Add(entryBox);
            Controls.Add(entriesLabel);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Lab01_Bai05";
            ShowInTaskbar = false;
            Text = "BaiTH5";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button digit_7_Btn;
        private GroupBox groupBox1;
        private Button op_Multiply_Btn;
        private Button calculate_Btn;
        private Button op_Addition_Btn;
        private Button op_Subtract_Btn;
        private Button op_Negate_Btn;
        private Button digit_Point_Btn;
        private Button digit_4_Btn;
        private Button digit_6_Btn;
        private Button digit_1_Btn;
        private Button digit_2_Btn;
        private Button digit_3_Btn;
        private Button digit_0_Btn;
        private Button digit_5_Btn;
        private Button digit_9_Btn;
        private Button digit_8_Btn;
        private Button clear_Btn;
        private Button backspace_Btn;
        private Label entriesLabel;
        private TextBox entryBox;
        private Button clearEntry_Btn;
        private Button op_Divide_Btn;
    }
}
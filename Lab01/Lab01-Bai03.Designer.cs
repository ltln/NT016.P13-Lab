namespace Lab01
{
    partial class Lab01_Bai03
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            input_textBox = new TextBox();
            output_textBox = new TextBox();
            currency = new ComboBox();
            converted_currency = new ComboBox();
            convert_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(194, 30);
            label1.TabIndex = 0;
            label1.Text = "Chuyển đổi tiền tệ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 80);
            label2.Name = "label2";
            label2.Size = new Size(112, 21);
            label2.TabIndex = 1;
            label2.Text = "Số tiền cần đổi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 177);
            label3.Name = "label3";
            label3.Size = new Size(105, 21);
            label3.TabIndex = 2;
            label3.Text = "Số tiền đã đổi";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 243);
            label4.Name = "label4";
            label4.Size = new Size(110, 21);
            label4.TabIndex = 3;
            label4.Text = "Tỷ giá quy đổi:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(153, 243);
            label5.Name = "label5";
            label5.Size = new Size(20, 21);
            label5.TabIndex = 4;
            label5.Text = "{}";
            // 
            // input_textBox
            // 
            input_textBox.Location = new Point(153, 77);
            input_textBox.Name = "input_textBox";
            input_textBox.Size = new Size(191, 29);
            input_textBox.TabIndex = 5;
            // 
            // output_textBox
            // 
            output_textBox.Location = new Point(153, 174);
            output_textBox.Name = "output_textBox";
            output_textBox.Size = new Size(191, 29);
            output_textBox.TabIndex = 6;
            // 
            // currency
            // 
            currency.FormattingEnabled = true;
            currency.Items.AddRange(new object[] { "d", "c", "e" });
            currency.Location = new Point(350, 78);
            currency.Name = "currency";
            currency.Size = new Size(160, 29);
            currency.TabIndex = 7;
            // 
            // converted_currency
            // 
            converted_currency.FormattingEnabled = true;
            converted_currency.Location = new Point(350, 175);
            converted_currency.Name = "converted_currency";
            converted_currency.Size = new Size(160, 29);
            converted_currency.TabIndex = 8;
            // 
            // convert_btn
            // 
            convert_btn.Location = new Point(35, 121);
            convert_btn.Name = "convert_btn";
            convert_btn.Size = new Size(309, 36);
            convert_btn.TabIndex = 9;
            convert_btn.Text = "Chuyển đổi";
            convert_btn.UseVisualStyleBackColor = true;
            convert_btn.Click += convert_btn_Click;
            // 
            // Lab01_Bai03
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(568, 316);
            Controls.Add(convert_btn);
            Controls.Add(converted_currency);
            Controls.Add(currency);
            Controls.Add(output_textBox);
            Controls.Add(input_textBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4, 4, 4, 4);
            MaximizeBox = false;
            Name = "Lab01_Bai03";
            Padding = new Padding(32);
            ShowInTaskbar = false;
            Text = "BaiTH3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox input_textBox;
        private TextBox output_textBox;
        private ComboBox currency;
        private ComboBox converted_currency;
        private Button convert_btn;
    }
}
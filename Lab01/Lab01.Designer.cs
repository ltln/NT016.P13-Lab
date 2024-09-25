namespace Lab01
{
    partial class Lab01
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
            bai1_btn = new Button();
            bai2_btn = new Button();
            bai3_btn = new Button();
            bai4_btn = new Button();
            bai5_btn = new Button();
            SuspendLayout();
            // 
            // bai1_btn
            // 
            bai1_btn.Location = new Point(45, 49);
            bai1_btn.Margin = new Padding(4);
            bai1_btn.Name = "bai1_btn";
            bai1_btn.Size = new Size(150, 48);
            bai1_btn.TabIndex = 0;
            bai1_btn.Text = "Bài 1";
            bai1_btn.UseVisualStyleBackColor = true;
            bai1_btn.Click += bai1_btn_Click;
            // 
            // bai2_btn
            // 
            bai2_btn.Location = new Point(228, 49);
            bai2_btn.Margin = new Padding(4);
            bai2_btn.Name = "bai2_btn";
            bai2_btn.Size = new Size(150, 48);
            bai2_btn.TabIndex = 1;
            bai2_btn.Text = "Bài 2";
            bai2_btn.UseVisualStyleBackColor = true;
            bai2_btn.Click += bai2_btn_Click;
            // 
            // bai3_btn
            // 
            bai3_btn.Location = new Point(45, 105);
            bai3_btn.Margin = new Padding(4);
            bai3_btn.Name = "bai3_btn";
            bai3_btn.Size = new Size(150, 48);
            bai3_btn.TabIndex = 2;
            bai3_btn.Text = "Bài 3";
            bai3_btn.UseVisualStyleBackColor = true;
            bai3_btn.Click += bai3_btn_Click;
            // 
            // bai4_btn
            // 
            bai4_btn.Location = new Point(228, 105);
            bai4_btn.Margin = new Padding(4);
            bai4_btn.Name = "bai4_btn";
            bai4_btn.Size = new Size(150, 48);
            bai4_btn.TabIndex = 3;
            bai4_btn.Text = "Bài 4";
            bai4_btn.UseVisualStyleBackColor = true;
            bai4_btn.Click += bai4_btn_Click;
            // 
            // bai5_btn
            // 
            bai5_btn.Location = new Point(45, 161);
            bai5_btn.Margin = new Padding(4);
            bai5_btn.Name = "bai5_btn";
            bai5_btn.Size = new Size(150, 48);
            bai5_btn.TabIndex = 4;
            bai5_btn.Text = "Bài 5";
            bai5_btn.UseVisualStyleBackColor = true;
            bai5_btn.Click += bai5_btn_Click;
            // 
            // Lab01
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 263);
            Controls.Add(bai5_btn);
            Controls.Add(bai4_btn);
            Controls.Add(bai3_btn);
            Controls.Add(bai2_btn);
            Controls.Add(bai1_btn);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Lab01";
            Padding = new Padding(41, 45, 41, 45);
            Text = "Lab01";
            Load += Lab01_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button bai1_btn;
        private Button bai2_btn;
        private Button bai3_btn;
        private Button bai4_btn;
        private Button bai5_btn;
    }
}

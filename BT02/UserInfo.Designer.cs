namespace BT02
{
    partial class userInfoForm
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
            usernameLabel = new Label();
            label3 = new Label();
            emailLabel = new Label();
            groupBox1 = new GroupBox();
            idLabel = new Label();
            label2 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Mona Sans", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernameLabel.Location = new Point(172, 36);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(116, 20);
            usernameLabel.TabIndex = 1;
            usernameLabel.Text = "%username%";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(96, 73);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Email";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new Font("Mona Sans", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            emailLabel.Location = new Point(172, 73);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new Size(80, 20);
            emailLabel.TabIndex = 3;
            emailLabel.Text = "%email%";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(idLabel);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(usernameLabel);
            groupBox1.Controls.Add(emailLabel);
            groupBox1.Controls.Add(label3);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(32, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(16);
            groupBox1.Size = new Size(441, 215);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new Point(172, 115);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(84, 20);
            idLabel.TabIndex = 5;
            idLabel.Text = "%userid%";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(123, 115);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(25, 20);
            label2.TabIndex = 4;
            label2.Text = "ID";
            // 
            // userInfoForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(505, 279);
            Controls.Add(groupBox1);
            Font = new Font("Mona Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "userInfoForm";
            Padding = new Padding(32);
            Text = "Thông tin";
            Load += userInfoForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label usernameLabel;
        private Label label3;
        private Label emailLabel;
        private GroupBox groupBox1;
        private Label idLabel;
        private Label label2;
    }
}

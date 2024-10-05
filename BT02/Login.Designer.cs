namespace BT02
{
    partial class Login
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
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            loginBtn = new Button();
            groupBox1 = new GroupBox();
            registerBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Top;
            label1.Location = new Point(16, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 99);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // usernameBox
            // 
            usernameBox.BorderStyle = BorderStyle.FixedSingle;
            usernameBox.Location = new Point(20, 59);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Nhập tên đăng nhập";
            usernameBox.Size = new Size(197, 27);
            usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Location = new Point(20, 122);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Nhập mật khẩu";
            passwordBox.Size = new Size(197, 27);
            passwordBox.TabIndex = 4;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.LightPink;
            loginBtn.FlatStyle = FlatStyle.Flat;
            loginBtn.Location = new Point(26, 192);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(191, 37);
            loginBtn.TabIndex = 5;
            loginBtn.Text = "Đăng nhập";
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(registerBtn);
            groupBox1.Controls.Add(loginBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(usernameBox);
            groupBox1.Controls.Add(passwordBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.FlatStyle = FlatStyle.Flat;
            groupBox1.Location = new Point(32, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(16);
            groupBox1.Size = new Size(363, 292);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng nhập vào tài khoản";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.LightPink;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Location = new Point(26, 235);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(191, 37);
            registerBtn.TabIndex = 6;
            registerBtn.Text = "Đăng ký tài khoản";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(427, 356);
            Controls.Add(groupBox1);
            Font = new Font("Mona Sans", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Login";
            Padding = new Padding(32);
            Text = "Đăng nhập";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox usernameBox;
        private TextBox passwordBox;
        private Button loginBtn;
        private GroupBox groupBox1;
        private Button registerBtn;
    }
}
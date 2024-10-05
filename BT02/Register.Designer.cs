namespace BT02
{
    partial class RegisterForm
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
            groupBox1 = new GroupBox();
            registerBtn = new Button();
            emailBox = new TextBox();
            confirmPasswordBox = new TextBox();
            passwordBox = new TextBox();
            usernameBox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(registerBtn);
            groupBox1.Controls.Add(emailBox);
            groupBox1.Controls.Add(confirmPasswordBox);
            groupBox1.Controls.Add(passwordBox);
            groupBox1.Controls.Add(usernameBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(46, 43);
            groupBox1.Margin = new Padding(4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(16);
            groupBox1.Size = new Size(392, 413);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Đăng ký tài khoản";
            // 
            // registerBtn
            // 
            registerBtn.BackColor = Color.LightPink;
            registerBtn.FlatStyle = FlatStyle.Flat;
            registerBtn.Location = new Point(22, 353);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(196, 41);
            registerBtn.TabIndex = 8;
            registerBtn.Text = "Đăng ký";
            registerBtn.UseVisualStyleBackColor = false;
            registerBtn.Click += registerBtn_Click;
            // 
            // emailBox
            // 
            emailBox.BorderStyle = BorderStyle.FixedSingle;
            emailBox.Location = new Point(19, 288);
            emailBox.Name = "emailBox";
            emailBox.PlaceholderText = "Nhập email";
            emailBox.Size = new Size(199, 27);
            emailBox.TabIndex = 7;
            // 
            // confirmPasswordBox
            // 
            confirmPasswordBox.BorderStyle = BorderStyle.FixedSingle;
            confirmPasswordBox.Location = new Point(19, 211);
            confirmPasswordBox.Name = "confirmPasswordBox";
            confirmPasswordBox.PlaceholderText = "Nhập lại mật khẩu";
            confirmPasswordBox.Size = new Size(199, 27);
            confirmPasswordBox.TabIndex = 6;
            confirmPasswordBox.UseSystemPasswordChar = true;
            // 
            // passwordBox
            // 
            passwordBox.BorderStyle = BorderStyle.FixedSingle;
            passwordBox.Location = new Point(19, 133);
            passwordBox.Name = "passwordBox";
            passwordBox.PlaceholderText = "Nhập mật khẩu";
            passwordBox.Size = new Size(199, 27);
            passwordBox.TabIndex = 5;
            passwordBox.UseSystemPasswordChar = true;
            // 
            // usernameBox
            // 
            usernameBox.BorderStyle = BorderStyle.FixedSingle;
            usernameBox.Location = new Point(19, 59);
            usernameBox.Name = "usernameBox";
            usernameBox.PlaceholderText = "Nhập tên đăng nhập";
            usernameBox.Size = new Size(199, 27);
            usernameBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 265);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 3;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 188);
            label3.Name = "label3";
            label3.Size = new Size(156, 20);
            label3.TabIndex = 2;
            label3.Text = "Xác nhận mật khẩu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 110);
            label2.Name = "label2";
            label2.Size = new Size(81, 20);
            label2.TabIndex = 1;
            label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 36);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(10F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(484, 499);
            Controls.Add(groupBox1);
            Font = new Font("Mona Sans", 11.9999981F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "RegisterForm";
            Padding = new Padding(46, 43, 46, 43);
            Text = "Đăng ký";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox emailBox;
        private TextBox confirmPasswordBox;
        private TextBox passwordBox;
        private TextBox usernameBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button registerBtn;
    }
}
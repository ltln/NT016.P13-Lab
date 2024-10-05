using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT02
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            string confirm_password = confirmPasswordBox.Text.Trim();
            string email = emailBox.Text.Trim();

            if (username == string.Empty)
            {
                MessageBox.Show("Tên đăng nhập không được để trống!");
                return;
            }

            if (password == string.Empty)
            {
                MessageBox.Show("Mật khẩu không được để trống!");
                return;
            }

            if (email == string.Empty)
            {
                MessageBox.Show("Email không được để trống!");
                return;
            }

            if (confirm_password == string.Empty || password != confirm_password)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu!");
                return;
            }

            if (!Regex.IsMatch(email, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$"))
            {
                MessageBox.Show("Email không hợp lệ!");
                return;
            }

            UserAction action = new UserAction();
            if (action.RegisterUser(username, password, email))
            {
                MessageBox.Show("Tạo tài khoản thành công! Vui lòng đăng nhập.");
            }
        }
    }
}

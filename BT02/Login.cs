using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT02
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text.Trim();
            string password = passwordBox.Text.Trim();
            UserAction action = new UserAction();
            bool UserCheck = action.LoginSession(username, password);
            if (UserCheck)
            {
                userInfoForm form = new userInfoForm();
                this.Hide();
                form.Show();
            } else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!");
            }
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
        }
    }
}

namespace BT02
{
    public partial class userInfoForm : Form
    {
        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        public userInfoForm()
        {
            InitializeComponent();
        }

        private void userInfoForm_Load(object sender, EventArgs e)
        {
            usernameLabel.Text = UserSession.Name;
            emailLabel.Text = UserSession.Email;
            idLabel.Text = UserSession.ID.ToString();
        }
    }
}

namespace Lab01
{
    public partial class Lab01 : Form
    {
        public Lab01()
        {
            InitializeComponent();
        }

        private void Lab01_Load(object sender, EventArgs e)
        {

        }

        private void bai1_btn_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 lab = new Lab01_Bai01();
            lab.ShowDialog();
        }

        private void bai2_btn_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 lab = new Lab01_Bai02();
            lab.ShowDialog();
        }

        private void bai3_btn_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 lab = new Lab01_Bai03();
            lab.ShowDialog();
        }

        private void bai4_btn_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 lab = new Lab01_Bai04();
            lab.ShowDialog();
        }

        private void bai5_btn_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 lab = new Lab01_Bai05();
            lab.ShowDialog();
        }
    }
}

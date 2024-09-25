using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai01 : Form
    {
        public Lab01_Bai01()
        {
            InitializeComponent();
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(num1_textBox.Text);
                int num2 = int.Parse(num2_textBox.Text);
                int num3 = int.Parse(num3_textBox.Text);
                int[] numbers = new int[] { num1, num2, num3 };
                Array.Sort(numbers);
                resultMin_textBox.Text = numbers[0].ToString();
                resultMax_textBox.Text = numbers[2].ToString();
            }
            catch
            {
                MessageBox.Show("Phải nhập số nguyên!");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            num1_textBox.Text = num2_textBox.Text = num3_textBox.Text = resultMax_textBox.Text = resultMin_textBox.Text = string.Empty;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

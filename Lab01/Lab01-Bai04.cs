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
    public partial class Lab01_Bai04 : Form
    {
        public Lab01_Bai04()
        {
            InitializeComponent();
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Calculate cal = new Calculate();
                int A = int.Parse(valueA_textBox.Text);
                int B = int.Parse(valueB_textBox.Text);
                resultA_label.Text = "!A = " + cal.Factorial(A).ToString();
                resultB_label.Text = "!B = " + cal.Factorial(B).ToString();
                resultS1_label.Text = "S1 = " + cal.Sum(A).ToString();
                resultS2_label.Text = "S2 = " + cal.Sum(B).ToString();
                resultS3_label.Text = "S3 = " + cal.ExponentSum(A, B).ToString();
            }
            catch
            {
                MessageBox.Show("Phải nhập số nguyên!");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            valueA_textBox.Clear();
            valueB_textBox.Clear();
            resultBox.Text = string.Empty;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

    public class Calculate
    {
        public long Factorial(int n)
        {
            long result = 1;
            for (int i = 1; i <= n; i++)
                result *= i;
            return result;
        }

        public long Sum(int n)
        {
            long result = 0;
            for (int i = 0; i <= n; i++)
                result += i;
            return result;
        }

        public long ExponentSum(int a, int b)
        {
            long result = 0;
            for (int i = 1; i <= b; i++)
            {
                result += Exponent(a, i);
            }
            return result;
        }

        public long Exponent(int a, int b)
        {
            long result = 1;
            for (int i = 1; i <= b; i++)
            {
                result *= a;
            }
            return result;
        }
    }
}

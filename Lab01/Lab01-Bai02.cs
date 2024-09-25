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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void read_btn_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(input_textBox.Text);
                string result = ProcessNumber(num);
                output_textBox.Text = result;
            }
            catch 
            {
                MessageBox.Show("Phải nhập số nguyên!");
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        static string[] digits = ["không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"];
        static string[] units = ["tỷ", "triệu", "nghìn"];

        public static string ProcessNumber(int num)
        {
            string numStr = num.ToString();
            int needZeroCount = numStr.Length % 3;
            if (needZeroCount != 0) needZeroCount = 3 - needZeroCount;
            numStr = (new string('0', needZeroCount)) + numStr;

            string[] result = new string[100];
            for (int i = 0; i < numStr.Length / 3; i++)
            {
                int numGr = int.Parse(numStr.Substring(i * 3, 3));
                int a = numGr / 100;
                int b = (numGr % 100) / 10;
                int c = (numGr % 100) % 10;

                result.Append(ReadThreeDigits(a, b, c, false));
                // result.Append(units[numStr.Length / 3 - 1 - i]);
            }

            return string.Join(" ", result);
        }

        static string ReadLastTwoDigits(int b, int c, bool hasHundred)
        {
            string[] result = [];
            switch (b)
            {
                case 0:
                    if (hasHundred && c == 0)
                        break;
                    if (hasHundred)
                        result.Append("lẻ");
                    result.Append(digits[c]);
                    break;

                case 1:
                    result.Append("mười");
                    if (c == 5) result.Append("lăm");
                    else if (c != 0) result.Append(digits[c]);
                    break;

                default:
                    result.Append(digits[b]);
                    result.Append("mươi");
                    if (c == 1) result.Append("mốt");
                    else if (c == 4) result.Append("tư");
                    else if (c == 5) result.Append("lăm");
                    else if (c != 0) result.Append(digits[c]);
                    break;
            }
            return string.Join(" ", result);
        }

        static string ReadThreeDigits(int a, int b, int c, bool readZeroHundred)
        {
            string[] result = [];

            if (a != 0 || readZeroHundred)
            {
                result.Append(digits[a]);
                result.Append("trăm");
            }

            result.Append(ReadLastTwoDigits(b, c, a != 0 || readZeroHundred));

            return string.Join(" ", result);
        }
    }
}

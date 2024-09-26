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
                long num = long.Parse(input_textBox.Text.Trim());
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
            input_textBox.Text = output_textBox.Text = string.Empty;
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        static string[] digits = ["không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"];
        static string[] units = ["", "nghìn", "triệu", "tỷ"];

        public static string ProcessNumber(long num)
        {
            string numStr = num.ToString();
            int needZeroCount = numStr.Length % 3;
            if (needZeroCount != 0) needZeroCount = 3 - needZeroCount;
            numStr = (new string('0', needZeroCount)) + numStr;

            List<string> result = new List<string>();
            for (int i = 0; i < numStr.Length / 3; i++)
            {
                int numGr = int.Parse(numStr.Substring(i * 3, 3));
                int a = numGr / 100;
                int b = (numGr % 100) / 10;
                int c = (numGr % 100) % 10;

                result.Add(ReadThreeDigits(a, b, c, false));
                if (a != 0 || b != 0 || c != 0)
                    result.Add(units[numStr.Length / 3 - 1 - i]);
            }

            return Regex.Replace(string.Join(" ", result.ToArray()), @"\s+", " ");
        }

        static string ReadLastTwoDigits(int b, int c, bool hasHundred)
        {
            List<string> result = new List<string>();
            switch (b)
            {
                case 0:
                    if (c == 0)
                        break;
                    if (hasHundred && c == 0)
                        break;
                    if (hasHundred)
                        result.Add("lẻ");
                    result.Add(digits[c]);
                    break;

                case 1:
                    result.Add("mười");
                    if (c == 5) result.Add("lăm");
                    else if (c != 0) result.Add(digits[c]);
                    break;

                default:
                    result.Add(digits[b]);
                    result.Add("mươi");
                    if (c == 1) result.Add("mốt");
                    else if (c == 4) result.Add("tư");
                    else if (c == 5) result.Add("lăm");
                    else if (c != 0) result.Add(digits[c]);
                    break;
            }
            return string.Join(" ", result.ToArray());
        }

        static string ReadThreeDigits(int a, int b, int c, bool readZeroHundred)
        {
            List<string> result = new List<string>();

            if (a != 0 || readZeroHundred)
            {
                result.Add(digits[a]);
                result.Add("trăm");
            }

            result.Add(ReadLastTwoDigits(b, c, a != 0 || readZeroHundred));

            return string.Join(" ", result.ToArray());
        }
    }
}

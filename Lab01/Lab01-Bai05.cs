using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
        }

        static bool isSecondEntry { get; set; } = false;
        static double EntryOp { get; set; } = 0;
        static string EntryCurrent { get; set; } = "0";
        static string Operation { get; set; } = "";
        static double Result { get; set; } = 0;

        void ButtonClickListener(object sender, EventArgs e)
        {
            var btn = sender as Button;

            var btnProps = btn.Name.Split('_');

            if (btnProps[0] == "op")
                OperationHandler(btnProps[1]);
            else if (btnProps[0] == "digit")
                EntryHandler(btnProps[1]);

        }

        void OperationHandler(string name)
        {
            if (name != "Negate" && !isSecondEntry)
            {
                EntryOp = double.Parse(EntryCurrent.EndsWith(".") ? EntryCurrent + "0" : EntryCurrent);
            }

            switch (name)
            {
                case "Negate":
                    if (EntryCurrent != entryBox.Text)
                        EntryCurrent = entryBox.Text;
                    EntryCurrent = (Negate(ParseDouble(EntryCurrent))).ToString();
                    entryBox.Text = EntryCurrent;
                    return;
                case "Addition":
                    Operation = "+";
                    break;
                case "Subtract":
                    Operation = "-";
                    break;
                case "Multiply":
                    Operation = "x";
                    break;
                case "Divide":
                    Operation = "/";
                    break;
            }
            isSecondEntry = true;
            entriesLabel.Text = EntryOp + " " + Operation;
            EntryCurrent = "0";
        }

        void EntryHandler(string num)
        {
            if (num == "Point")
                EntryCurrent += ".";
            else
                EntryCurrent = EntryCurrent != "0" ? EntryCurrent + num : num;

            entryBox.Text = EntryCurrent;
        }

        static double Negate(double value)
        {
            return value * -1;
        }

        private void backspace_Btn_Click(object sender, EventArgs e)
        {
            if (EntryCurrent.Length < 2)
                EntryCurrent = "0";
            else
                EntryCurrent = EntryCurrent.ToString().Remove(EntryCurrent.Length - 1);
            entryBox.Text = EntryCurrent;
        }

        private void calculate_Btn_Click(object sender, EventArgs e)
        {
            if (!isSecondEntry) return;

            if (EntryCurrent != entryBox.Text)
                EntryCurrent = entryBox.Text;

            switch (Operation)
            {
                case "+":
                    Result = EntryOp + ParseDouble(EntryCurrent);
                    break;
                case "-":
                    Result = EntryOp - ParseDouble(EntryCurrent);
                    break;
                case "x":
                    Result = EntryOp * ParseDouble(EntryCurrent);
                    break;
                case "/":
                    if (EntryCurrent == "0")
                    {
                        entryBox.Text = "Cannot divide by 0";
                        return;
                    }
                    Result = EntryOp / ParseDouble(EntryCurrent);
                    break;
            }
            entriesLabel.Text = $"{EntryOp} {Operation} {EntryCurrent} = ";
            EntryCurrent = "0";
            EntryOp = Result;
            entryBox.Text = Result.ToString();
        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            EntryCurrent = "0";
            entryBox.Text = EntryCurrent;
        }

        private void clearEntry_Btn_Click(object sender, EventArgs e)
        {
            EntryCurrent = "0";
            EntryOp = 0;
            Operation = "";
            entryBox.Text = "0";
            entriesLabel.Text = "";
            isSecondEntry = false;
        }

        static double ParseDouble(string str)
        {
            return double.Parse(str.EndsWith(".") ? str + "0" : str);
        }
    }
}

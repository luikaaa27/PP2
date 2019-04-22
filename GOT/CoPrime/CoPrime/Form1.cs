using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        static int gcd(int x, int y)
        {
            while (y != 0)
            {
                int tmp = x % y;
                x = y;
                y = tmp;
            }

            return x;
        }
        private double first = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            input.Text += "1";
        }

        private void b2_Click(object sender, EventArgs e)
        {
            input.Text += "2";
        }

        private void b3_Click(object sender, EventArgs e)
        {
            input.Text += "3";
        }

        private void b4_Click(object sender, EventArgs e)
        {
            input.Text += "4";
        }

        private void b5_Click(object sender, EventArgs e)
        {
            input.Text += "5";

        }

        private void b6_Click(object sender, EventArgs e)
        {
            input.Text += "6";
        }

        private void b7_Click(object sender, EventArgs e)
        {
            input.Text += "7";
        }

        private void b8_Click(object sender, EventArgs e)
        {
            input.Text += "8";
        }

        private void b9_Click(object sender, EventArgs e)
        {
            input.Text += "9";
        }

        private void b0_Click(object sender, EventArgs e)
        {
            input.Text += "0";
        }

        private void comma_Click(object sender, EventArgs e)
        {
            if (input.Text == "" || input.Text.IndexOf(',') != -1)
                return;
            input.Text += ',';
        }

        private void plus_Click(object sender, EventArgs e)
        {
            history.Text = '+' + input.Text;
            first = Convert.ToDouble(input.Text);
            input.Text = "";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            history.Text = '-' + input.Text;
            first = Convert.ToDouble(input.Text);
            input.Text = "";
        }

        private void mult_Click(object sender, EventArgs e)
        {
            history.Text = '*' + input.Text;
            first = Convert.ToDouble(input.Text);
            input.Text = "";
        }

        private void div_Click(object sender, EventArgs e)
        {
            history.Text = '/' + input.Text;
            first = Convert.ToDouble(input.Text);
            input.Text = "";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            double second = 0;
            if (input.Text != "")
            {
                second = Convert.ToDouble(input.Text);
            }
            if (history.Text[0] == '+')
                first += second;
            if (history.Text[0] == '-')
                first -= second;
            if (history.Text[0] == '*')
                first *= second;
            if (history.Text[0] == '/')
                first /= second;
            if (history.Text[0] == '^')
                first = Math.Pow(first, second);
            if (history.Text[0] == ':')
            {
                if (input.Text.IndexOf(',') == -1)
                {
                    first = gcd(Convert.ToInt32(first), Convert.ToInt32(input.Text));
                }
            }
            if(history.Text[0] == '#')
            {
                if (input.Text.IndexOf(',') == -1)
                {
                    int vtoroi = Convert.ToInt32(input.Text);
                    int max = Math.Max(Convert.ToInt32(first), vtoroi);
                    int min = Math.Min(Convert.ToInt32(first), vtoroi);
                    int x = max / min;
                    int y = max / min + 1;
                    if (Math.Abs(x * min - max) <= Math.Abs(y * min - max))
                        first = (x * min);
                    else
                        first = (y * min);
                }
            }
            history.Text = "";
            input.Text = first.ToString();
        }

        private void inv_Click(object sender, EventArgs e)
        {

        }

        private void mod_Click(object sender, EventArgs e)
        {

        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (history.Text != "")
            {
                equal_Click(sender, e);
            }
            input.Text = Math.Sqrt(Convert.ToDouble(input.Text)).ToString();
        }

        private void sign_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            input.Text = (-Convert.ToDouble(input.Text)).ToString();
        }

        private void allClear_Click(object sender, EventArgs e)
        {
            input.Text = "";
            history.Text = "";
        }

        private void CE_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void backspace_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            input.Text = input.Text.Substring(0, input.Text.Length - 1);
        }



        private void button1_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void history_TextChanged(object sender, EventArgs e)
        {

        }

        private void pow_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            first = Convert.ToDouble(input.Text);
            history.Text = "^" + first.ToString();
            input.Text = "";
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (input.Text.IndexOf(',') == -1)
            {
                first = Convert.ToInt32(input.Text);
                long fact = 1;
                for (int i = 1; i <= first; ++i)
                    fact *= i;
                input.Text = fact.ToString();
            }
        }

        private void coPrime_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (input.Text.IndexOf(',') == -1)
            {
                first = Convert.ToInt32(input.Text);
                history.Text = ":" + first.ToString() + "GCD ";
                input.Text = "";
            }
        }

        private void Closest_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (input.Text.IndexOf(',') == -1)
            {
                first = Convert.ToInt32(input.Text);
                history.Text = "#" + first.ToString() + "Closest";
                input.Text = "";
            }
        }
    }
}
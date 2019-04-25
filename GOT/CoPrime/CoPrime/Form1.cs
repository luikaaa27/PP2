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
        static int lcm(int x, int y)
        {
            int n1, n2;
            if (x > y)
            {
                n1 = x;
                n2 = y;
            }
            else
            {
                n1 = y;
                n2 = x;
            }
            for (int i = 1; i < n2; i++)
            {
                if ((n1 * i) % n2 == 0)
                {
                    return i * n1;
                }
            }
            return n1 * n2;
        }
        public static int Revers(int n)
        {
            int rev = 0;
            while (n > 0)
            {
                int remainder = n % 10;
                rev = (rev * 10) + remainder;
                n /= 10;
            }
            return rev;
        }
        public static int Fib(int n)
        {
            int number = n - 1;
            int[] Fib = new int[number + 1];
            Fib[0] = 0;
            Fib[1] = 1;
            for (int i = 2; i <= number; i++)
            {
                Fib[i] = Fib[i - 2] + Fib[i - 1];
            }
            return Fib[number];
        }
        public static string FromDecimalToBinary(int n)
        {
            string result = "";
            int rem = 0;
            int num = Convert.ToInt32(n);
            while (num > 0)
            {
                rem = num % 2;
                num = num / 2;
                result = rem.ToString() + result;
            }
            return result;
        }
        public static string FromDecimalToOctal(int n)
        {
            string result = "";
            int rem = 0;
            int num = Convert.ToInt32(n);
            while (num > 0)
            {
                rem = num % 8;
                num = num / 8;
                result = rem.ToString() + result;
            }
            return result;
        }
        /*  public static string FromDecimalToHex(int n)
          {

          }*/
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

        private void f_Click(object sender, EventArgs e)
        {
            input.Text += "f";
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

        double second = 0;
        private void equal_Click(object sender, EventArgs e)
        {
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
            if (history.Text[0] == 'V')
                first = Math.Pow(first, 1 / second);
            if (history.Text[0] == ':')
            {
                if (input.Text.IndexOf(',') == -1)
                {
                    first = gcd(Convert.ToInt32(first), Convert.ToInt32(input.Text));
                }
            }
            if (history.Text[0] == 'L')
            {
                if (input.Text.IndexOf(',') == -1)
                {
                    first = lcm(Convert.ToInt32(first), Convert.ToInt32(input.Text));
                }
            }
            if (history.Text[0] == '#')
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
            if (history.Text[0] == '&')
            {
                if (input.Text.IndexOf(',') == -1)
                {
                    int n = 0;
                    int m = 0;
                    int[] prime1 = new int[n];
                    int[] prime2 = new int[m];
                    int f = 0;
                    int r = 0;
                    int frt = 0;
                    int scn = 0;
                    for (int j = 1; j <= Convert.ToInt32(first); j++)
                    {
                        bool isPrime = true;
                        for (int i = 2; i < j/2; i++)
                        {
                            if (j % i == 0)
                            {
                                isPrime = false;
                            }
                        }
                        frt += j;
                    }
                    for (int j = 1; j <= Convert.ToInt32(second); j++)
                    {
                        bool isPrime = true;
                        for (int i = 2; i < j/2; i++)
                        {
                            if (j % i == 0)
                            {
                                isPrime = false;
                            }
                        }
                        scn += j;
                    }
                    first = frt + scn;
                }
            }

            /*string a = Convert.ToString(history.Text[0]);
            string c = Convert.ToString(second);
            input.Text = b + a + c;
            input.Text = first.ToString();
        } */
            if (history.Text[0] == 'B')
            {
                if (input.Text.IndexOf(',') == -1)
                {
                    first = Convert.ToDouble(FromDecimalToBinary(Convert.ToInt32(first)));
                }
            }
            if (history.Text[0] == 'O')
            {
                if (input.Text.IndexOf(',') == -1)
                {
                    first = Convert.ToDouble(FromDecimalToOctal(Convert.ToInt32(first)));
                }
            }

            if (history.Text[0] == '~')
            {
                if (input.Text.IndexOf(',') == -1)
                {
                    first = Fib(Convert.ToInt32(first));
                }
            }
            if (history.Text[0] == 'l' && history.Text[1] == 'o')
            {
                first = Math.Log10(first);
            }
            if (history.Text[0] == 'l' && history.Text[1] == 'n')
            {
                first = Math.Log(first);
            }

            history.Text = "";
            input.Text = first.ToString();
        }

        private void inv_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            first = 1 / Convert.ToDouble(input.Text);
            history.Text = "1/" + input.Text;
            input.Text = "";
            input.Text = Convert.ToString(first);

        }
        private void mod_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            first = Convert.ToDouble(input.Text) / 100;
            history.Text = input.Text + "%";
            input.Text = "";
            input.Text = Convert.ToString(first);
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

        private void Fibonacci_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (input.Text.IndexOf(',') == -1)
            {
                first = Convert.ToInt32(input.Text);
                history.Text = "~" + first.ToString() + "ByFibonacci";
                input.Text = "";
            }
        }

        private void log_click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            first = Convert.ToDouble(input.Text);
            history.Text = "log" + first.ToString();
            input.Text = "";
        }

        private void ln_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            first = Convert.ToDouble(input.Text);
            history.Text = "ln" + first.ToString();
            input.Text = "";
        }

        private void sin_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            first = Convert.ToDouble(input.Text);
            history.Text = "sin" + first.ToString();
            double degree = Math.PI * first / 180.0;
            input.Text = Math.Sin(degree).ToString();

        }

        private void cos_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            first = Convert.ToDouble(input.Text);
            history.Text = "cos" + first.ToString();
            double degree = Math.PI * first / 180.0;
            input.Text = Math.Cos(degree).ToString();
        }

        private void binary_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (input.Text.IndexOf(',') == -1)
            {
                first = Convert.ToInt32(input.Text);
                history.Text = "Binary of: " + first.ToString();
                input.Text = "";
                first.ToString();
            }
        }

        private void octal_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (input.Text.IndexOf(',') == -1)
            {
                first = Convert.ToInt32(input.Text);
                history.Text = "Octal of: " + first.ToString();
                input.Text = "";
                first.ToString();
            }
        }

        private void Hexadecimal_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;

            history.Text = "Hex of: " + input.Text;

            int i = Convert.ToInt32(input.Text);
            input.Text = Convert.ToString(i, 16);

        }

        private void sqrtY_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            first = Convert.ToDouble(input.Text);
            history.Text = "V" + first.ToString();
            input.Text = "";
        }

        private void PowOf10_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            first = Convert.ToDouble(input.Text);
            history.Text = "10^" + first.ToString();
            input.Text = Convert.ToString(Math.Pow(10, first));
        }

        private void LCM_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (input.Text.IndexOf(',') == -1)
            {
                first = Convert.ToDouble(input.Text);
                history.Text = "LCM: " + first.ToString();
                input.Text = "";
            }
        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                return;
            if (input.Text.IndexOf(',') == -1)
            {
                first = Convert.ToDouble(input.Text);
                history.Text = "Reverse of: " + first.ToString();
                input.Text = "";
                input.Text = Convert.ToString(Revers(Convert.ToInt32(first)));
            }
        }

        private void FromHexToDec_Click(object sender, EventArgs e)
        {
            if (input.Text == "")
                    return;
            if (input.Text.IndexOf(',') == -1)
            {
                /* first = Convert.ToInt32(input.Text, 16);
                 input.Text = Convert.ToString(first);*/ // from hex to dec

                    /*  string s = input.Text;
                        int b = Convert.ToInt32(s, 2);
                   input.Text = Convert.ToString(b);*/ //from binary to dec

                string s = input.Text;
                int b = Convert.ToInt32(s, 8);
                input.Text = Convert.ToString(b);
            }
           
        }

        private void SumOfPrimes_Click(object sender, EventArgs e)
        {
           if(input.Text == "")
                return;
            if (input.Text.IndexOf(',') == -1)
            {
                first = Convert.ToInt32(input.Text);
                history.Text = "&" + first.ToString() + "SumOfPrimes";
                input.Text = "";
            }
        }
        static int primeSum(int l, int r)
        {
            int sum = 0;
            for (int i = r; i >= l; i--)
            {

                // Check for prime 
                bool isPrime = checkPrime(i);
                if (isPrime)
                {

                    // Sum the prime number 
                    sum = sum + i;
                }
            }
            return sum;
        }
        static bool checkPrime(int numberToCheck)
        {
            if (numberToCheck == 1)
            {
                return false;
            }
            for (int i = 2;
                     i * i <= numberToCheck; i++)
            {
                if (numberToCheck % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
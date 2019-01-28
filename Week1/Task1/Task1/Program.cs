using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            string[] s = Console.ReadLine().Split();
            for (int i = 0; i < n; i++)
            {
                int x;
                a[i] = Convert.ToInt32(s[i]);
            }
            int cnt = 1;
            int num = 0;
            int[] b = new int[n];
            for (int i = 0; i < n; i++)
            {

                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt < 2 && a[i] != 1)
                {
                    b[num] = a[i];
                    num++;
                }
                cnt = 1;
            }
            Console.WriteLine(num);
            for (int i = 0; i < num; i++)
            {
                Console.Write(b[i] + " ");
            }

        }
    }
}

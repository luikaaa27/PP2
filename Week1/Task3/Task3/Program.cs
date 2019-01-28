using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
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
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i] + " ");
                }
            }
        }
    }
}

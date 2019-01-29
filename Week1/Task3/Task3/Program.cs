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
            n = Convert.ToInt32(Console.ReadLine());//convert from string to int
            int[] a = new int[n];//initialize an array
            string[] s = Console.ReadLine().Split();//Read the line and split to string array
            for (int i = 0; i < n; i++)
            { 
                a[i] = Convert.ToInt32(s[i]);//convert elements of array from string to int
            }
            for (int i = 0; i < a.Length; ++i)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(a[i] + " ");//output an another array of integers, where every element is repeated
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());//Convert from string to int
            int[] a = new int[n];//initialiaze an array
            for(int i=1; i <= n; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("[*]");//output the Star triangle
                }
                Console.WriteLine(" ");
            }
        }
    }
}

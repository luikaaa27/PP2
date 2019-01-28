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
            n = Convert.ToInt32(Console.ReadLine()); //convert from string to int
            int[] a = new int[n];//initialize an array
            string[] s = Console.ReadLine().Split();//Read the line and split to string array
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(s[i]);//convert elements of array from string to int
            }
            int cnt = 1;//initialize a counter of divider
            int num = 0;//initialize a number of prime numbers
            int[] b = new int[n];//make an array of prime numbers
            for (int i = 0; i < n; i++)
            {

                for (int j = 2; j < a[i]; j++)
                {
                    if (a[i] % j == 0)//one of condition 
                    {
                        cnt++;//increase the number of divider
                    }
                }
                    if (cnt < 2 && a[i] != 1) //condition of prime numbers
                    {
                        b[num] = a[i]; //add prime numbers to array
                        num++;//increase a number of primes
                    }
                    cnt = 1;//update the counter
                
            }
                Console.WriteLine(num);//write a number of primes
                for (int i = 0; i < num; i++)
                {
                    Console.Write(b[i] + " ");//output the prime numbers
                }

            
        }
    }
}

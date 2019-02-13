
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;



namespace Task2
{
    class Program
    {
        //code to check if the number is the prime and write it in another file
        static void Solve(int[] prime)
        {
            int cnt = 1;
            int num = 0;
            int[] b = new int[10000];//array only of prime number
            for (int i = 0; i < prime.Length; i++)
            {
                for (int j = 2; j < prime[i]; j++)
                {
                    if (prime[i] % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt < 2 && prime[i] != 1)//condition of prime numbers
                {
                    b[num] = prime[i];
                    num++;
                }
                cnt = 1;
            }
            
            //Write an array of prime numbers into new file "task2ans.txt"
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\asus-\source\repos\Week2\Task2\task2ans.txt"))
            {
                for(int i = 0; i < num; i++) 
                {
                    file.Write(b[i].ToString() + ' ');
                }
            }
        }

            static void Main(string[] args)
            {
            //File.Create("C:\\Users\\asus-\\source\\repos\\Task2\\task2.txt");
            //Open a file and access to read
            FileStream task2 = new FileStream(@"C:\Users\asus-\source\repos\Week2\Task2\task2.txt", FileMode.Open, FileAccess.Read);

            //create a "stream reader" and link it to the file
            StreamReader reader = new StreamReader(task2);

            //Convert string to int array 
            int[] arr = reader.ReadToEnd().Split().Select(n => int.Parse(n)).ToArray();
           
            Solve(arr);//Function of checking number is prime or not
            reader.Close();
            task2.Close();
            }

        
    }
}

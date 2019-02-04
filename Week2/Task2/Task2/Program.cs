
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
        static void Solve(int[] prime)
        {
            int cnt = 1;
            int num = 0;
            int[] b = new int[10000];
            for (int i = 0; i < prime.Length; i++)
            {
                for (int j = 2; j < prime[i]; j++)
                {
                    if (prime[i] % j == 0)
                    {
                        cnt++;
                    }
                }
                if (cnt < 2 && prime[i] != 1)
                {
                    b[num] = prime[i];
                    num++;
                }
                cnt = 1;
            }
            
            using (System.IO.StreamWriter file =
        new System.IO.StreamWriter(@"C:\Users\asus-\source\repos\Week2\Task2\task2ans.txt"))
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
            FileStream task2 = new FileStream(@"C:\Users\asus-\source\repos\Week2\Task2\task2.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(task2);
            int[] arr = reader.ReadToEnd().Split().Select(n => int.Parse(n)).ToArray();
           
            Solve(arr);
            reader.Close();
            task2.Close();
            }

        
    }
}

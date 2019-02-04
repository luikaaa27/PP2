using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Solve(string str)
        {
            bool ok = true;
            for(int i = 0; i < str.Length; ++i)
            {
                if (str[str.Length - 1 - i] != str[i])
                {
                    ok = false;
                    break;
                }
            }
            if (ok)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
        static void Main(string[] args)
        {
            FileStream task1 = new FileStream(@"C:\Users\asus-\source\repos\Week2\Task1\task1.txt",FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(task1);

            string line = reader.ReadLine();
            //Console.WriteLine(line);

            Solve(line);
            reader.Close();
            task1.Close();

        }
    }
}

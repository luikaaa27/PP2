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
        //code to determine if reading string is polindrome or not
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
            //Open a file with read access
            FileStream task1 = new FileStream(@"C:\Users\asus-\source\repos\Week2\Task1\task1.txt",FileMode.Open, FileAccess.Read);

            //create a "stream reader" and link it to the file stream
            StreamReader reader = new StreamReader(task1);
            string line = reader.ReadLine();//read string from the file

            

            Solve(line);
            reader.Close();//close the stream reader
            task1.Close();//close the stream file

        }
    }
}

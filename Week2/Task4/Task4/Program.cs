using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\asus-\source\repos\Week2\Task4\task4Path.txt";
            string path1 = @"C:\Users\asus-\source\repos\Week2\Task4\task4PathNew.txt";
            FileInfo fileInf = new FileInfo(path);
            if (fileInf.Exists)
            {
                fileInf.CopyTo(path1, true);
                fileInf.Delete();
            }
        }
    }
}

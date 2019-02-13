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
            string path = @"C:\Users\asus-\source\repos\Week2\Task4\task4Path.txt";//file in the directory path
            string path1 = @"C:\Users\asus-\source\repos\Week2\Task4";//the directory path1 where the file will be copied
            FileInfo fileInf = new FileInfo(path);
            DirectoryInfo dirInf = new DirectoryInfo(path1);
            if (fileInf.Exists && dirInf.Exists)//condition that will allow to copy file
            {
                fileInf.CopyTo(path1 + @"\task4NewPath.txt", true);//copy from path to the directory path1
                fileInf.Delete();//delete the file with path
            }
        }
    }
}

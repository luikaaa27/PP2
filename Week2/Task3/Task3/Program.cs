using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
        static void Tree(DirectoryInfo root, string level)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDir = null;
            files = root.GetFiles("*.*");
           
            if (files != null)
            {
                subDir = root.GetDirectories();
                foreach (DirectoryInfo dirInfo in subDir)
                {
                    Console.WriteLine(level + dirInfo.Name);
                    Tree(dirInfo, level + "   ");
                }
                foreach (FileInfo fi in files)
                {
                    Console.WriteLine(level + fi.Name);
                }
            }

        }
        static void Main(string[] args)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\asus-\source\repos");
            Tree(dirInfo, "");
        }
    }
}
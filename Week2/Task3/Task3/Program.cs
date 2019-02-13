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
        //Code to write in console all the files and directories
        static void Tree(DirectoryInfo root, string level)
        {
            FileInfo[] files = null;
            DirectoryInfo[] subDir = null;

            //returns the names of files in the specified directory
            files = root.GetFiles("*.*");
           
            if (files != null)
            {
                subDir = root.GetDirectories();//get directories from the specified directory
                foreach (DirectoryInfo dirInfo in subDir)
                {
                    Console.WriteLine(level + dirInfo.Name);//print out the name of directories
                    Tree(dirInfo, level + "   ");
                }
                foreach (FileInfo fi in files)
                {
                    Console.WriteLine(level + fi.Name);//print out the name of files
                }
            }

        }
        static void Main(string[] args)
        {
            //specify the directories that I will use:
            DirectoryInfo dirInfo = new DirectoryInfo(@"C:\Users\asus-\source\repos");
            Tree(dirInfo, "");//go to draw a "tree" of directories and files

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WEEK2
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream file1 = new FileStream("D:\\test.txt", FileMode.Open);
            StreamReader reader = new StreamReader(file1);
            Console.WriteLine(reader.ReadToEnd());
            reader.Close();
        }
    }
}

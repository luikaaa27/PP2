using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student
    {
        public string name;
        public int id;
        public int year;
        
        public Student (string name,int id, int year)
        {
            this.name = name;
            this.id = id;
            this.year = year;
        }
        public Student()
        {
            name = Console.ReadLine();
            id = Convert.ToInt32(Console.ReadLine());
            year = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintInfo()
        {
            Console.WriteLine(name);
            Console.WriteLine(id);
            Console.WriteLine(year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.PrintInfo();
        }
    }
}

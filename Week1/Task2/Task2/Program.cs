using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Student//create a new class Student
    {
        //declare a name, id, year of student
        public string name;
        public string id;
        public int year;

        public Student(string name, string id, int year)
        {
            //Use this to qualify the name, id and year:
            this.name = name;
            this.id = id;
            this.year = year;
        }
        public Student()
        {
            //reading the Student properties
            name = Console.ReadLine();
            id = Console.ReadLine();
            year = Convert.ToInt32(Console.ReadLine());
        }
        public void PrintInfo()//Method to print out the information about the student
        {
            Console.WriteLine(name + " " + id + " " + year);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();//create a new Student Object
            student.PrintInfo();//Print out the information about the student
            student.year += 1;//increment the year of study
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Task1
{
    [Serializable]
    public class ComplexNumber
    {
        public double a{ get; set; }
        public double b { get; set; }
        public static ComplexNumber operator +(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber { a = num1.a + num2.a, b = num1.b + num2.b };
        }
        public static ComplexNumber operator -(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber { a = num1.a - num2.a, b = num1.b - num2.b };
        }
        public static ComplexNumber operator *(ComplexNumber num1, ComplexNumber num2)
        {
            return new ComplexNumber { a = (num1.a * num2.a) - (num1.b * num2.b), b = (num1.b * num2.a) + (num2.b * num1.a) };
        }
        public static ComplexNumber operator /(ComplexNumber num1, ComplexNumber num2)
        {
            double D = (num2.a * num2.a + (num2.b * num2.b));
            return new ComplexNumber { a = (num1.a * num2.a + num1.b * num2.b) / D, b = -(num1.a * num2.b - num1.b * num2.a) / D };
        }

        public void output()
        {
            if (a != 0)
                Console.Write(a.ToString());
            
            if (b == 0)
                return;
            if (b > 0 && a != 0)
                Console.Write('+');
            Console.WriteLine(b.ToString() + 'i');
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            ComplexNumber A = new ComplexNumber { a = x, b = y };
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            ComplexNumber B = new ComplexNumber { a = x, b = y };
            ComplexNumber C = A + B;
           C.output();
            Ser(C);
            //Deser();
        }
        static void Ser(ComplexNumber c)
        {
            FileStream fs = new FileStream("ComplexNumber.txt", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumber));
            xs.Serialize(fs, c);
            fs.Close();
        }
        static void Deser()
        {
            FileStream fs = new FileStream("ComplexNumber.txt", FileMode.Open, FileAccess.Read);
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumber));
            ComplexNumber t = xs.Deserialize(fs) as ComplexNumber;
            t.output();
            fs.Close();
        }
    }
}

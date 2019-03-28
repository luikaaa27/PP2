using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task1
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Thread[] threadArray = new Thread[3];
            threadArray[0] = new Thread(MethodName);
            threadArray[0].Name = "Thread1";
            threadArray[1] = new Thread(MethodName);
            threadArray[1].Name = "Thread2";
            threadArray[2] = new Thread(MethodName);
            threadArray[2].Name = "Thread3";
            for (int i = 0; i < 3; i++)
            {
                threadArray[i].Start();
            }
            
        }
        static void MethodName()
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }   
        }
        
    }
}

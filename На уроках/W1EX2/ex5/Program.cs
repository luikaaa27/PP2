﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            string s = Console.ReadLine();
            bool res = int.TryParse(s, out x);
            if (res == true)
            {
                Console.WriteLine("ok " + x);
            }
            else
            {
                Console.WriteLine("no " + x);
            }
        }
    }
}

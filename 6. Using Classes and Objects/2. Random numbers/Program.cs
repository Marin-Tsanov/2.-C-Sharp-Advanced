﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Random_numbers
{
    class Program
    {
        static void Main()
        {
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(r.Next(100,201));
            }

        }
    }
}

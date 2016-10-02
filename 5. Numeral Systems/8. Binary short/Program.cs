using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Binary_short
{
    class Program
    {
        static void Main()
        {
            short str = short.Parse(Console.ReadLine());

            string number = Convert.ToString(str, 2).PadLeft(16, '0');
            Console.WriteLine(number);
        }
    }
}

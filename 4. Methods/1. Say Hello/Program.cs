using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Say_Hello
{
    class Program
    {
        static void Name(string name)
        {
            
            Console.WriteLine("Hello, {0}!",name);
        }

        static void Main()
        {
            string name = Console.ReadLine();
            Name(name);
        }
    }
}

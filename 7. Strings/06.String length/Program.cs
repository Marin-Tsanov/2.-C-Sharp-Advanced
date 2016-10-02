using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.String_length
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            s = s.Replace(@"\", string.Empty);
            Console.WriteLine(s.PadRight(20, '*'));
        }
    }
}

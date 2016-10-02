using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Reverse_number
{
    class Program
    {
        static void Reverse(char[] elements)
        {
            Array.Reverse(elements);
            foreach(char element in elements)
            {
                Console.Write(element);
            }
            Console.WriteLine();
        }
        
        static void Main()
        {
            string number = Console.ReadLine();
            char[] array = number.ToCharArray(); 

            Reverse(array);
        }
    }
}

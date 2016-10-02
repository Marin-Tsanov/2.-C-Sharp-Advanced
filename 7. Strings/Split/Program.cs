using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Split
{
    class Program
    {
        static void Main()
        {
            //var numbers = "1 ---- 2    3 ==  4 5 6    7   8 --9".Split(new[] {' ','-','='},StringSplitOptions.RemoveEmptyEntries);

            string fileData = "   111 $  %    Ivan Ivanov  ### s   ";
            Console.WriteLine(fileData.Trim(new[] { ' ', '1', '$', '%', '#', 's' }));            

        }
    }
}

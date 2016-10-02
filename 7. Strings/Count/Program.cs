using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    class Program
    {
        static void Main()
        {
            var text = "bacon stuff ba con stuff stuff baconbacon";
            var splitText = text.Split(new[] { "bacon" }, StringSplitOptions.None);
            Console.WriteLine(splitText.Length-1);
        }
    }
}

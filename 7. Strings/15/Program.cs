using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15
{
    class Program
    {
        static void Main()
        {
            // Step 1: Create a dictionary 
            // with items and their replacements
            var Replace = new Dictionary<string, string>()
            {
                { "<a href=\"", "[URL="  }, //
                { "\">"       , "]"      }, //a
                { "</a>"      , "[/URL]" }  //
            };

            var toParse = Console.ReadLine();

            foreach (var tag in Replace)
            {
                toParse = toParse
                    .Replace(
                        tag.Key,
                        tag.Value);
            }

            Console.WriteLine(toParse);
        }
    }
}

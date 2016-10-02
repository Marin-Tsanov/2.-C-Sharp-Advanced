using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parse_string
{
    class Program
    {
        static void Main()
        {

            string input = "We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";

            List<int> Parse = new List<int>();

            int open = input.IndexOf("<upcase>");
            int close = input.IndexOf("</upcase>");

            while (open != -1 && close != -1)
            {
                if (open >= 0)
                {
                    Parse.Add(open);
                }
                if (close > 0)
                {
                    Parse.Add(close);
                }

                open = input.IndexOf("<upcase>", open + 8);
                close = input.IndexOf("</upcase>", close + 8);
            }

            for (int i = 1; i < Parse.Count; i += 2)
            {
                Parse[i] = Parse[i] + 9;
            }

            StringBuilder builder = new StringBuilder();

            builder.Append(input);
            Console.WriteLine(builder.ToString());

            for (int i = 0; i < Parse.Count; i += 2)
            {
                builder.Replace(input.Substring(Parse[i], Parse[i + 1] - Parse[i]),
                                input.Substring(Parse[i], Parse[i + 1] - Parse[i]).Replace("<upcase>", "").Replace("</upcase>", "").ToUpper());

            }

            Console.Write(builder.ToString());
        }
    }
}

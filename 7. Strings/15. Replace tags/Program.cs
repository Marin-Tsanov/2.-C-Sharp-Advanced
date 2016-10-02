using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _15.Replace_tags
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            string[] parse = text.Split(new string[] { "<a href=\"", "</a>" }, StringSplitOptions.None);
            
            //for (int i = 0; i < parse.Length; i++)
            //{
            //    Console.WriteLine(parse[i]);
            //}

            StringBuilder builder = new StringBuilder();

            foreach (var word in parse)
            {
                int indexStart = word.IndexOf("\">");

                if (indexStart>0)
                {
                    builder.Append("[")
                           .Append(word.Substring(indexStart+2))
                           .Append("](")
                           .Append(word.Substring(0,indexStart))
                           .Append(")");
                }

                else
                {
                    builder.Append(word);
                }
            }

            Console.WriteLine(builder.ToString());



        }
    }
}

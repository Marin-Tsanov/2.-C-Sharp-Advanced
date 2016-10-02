using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Strings
{
    class Program
    {  static List<int> Find(string text,string word)
            {
            var indices = new List<int>();
            int index = text.IndexOf(word);

            while (index!=-1)
            {
                indices.Add(index);
                index = text.IndexOf(word, index + 1);    
            }

            return indices;
            }
        static void Main()
        {
            var text = @"bacon bacon ipsum dolor amet filet mignon short loin pork chop, pastrami corned beef shankle drumstick sausage hamburger meatloaf. Tri-tip bresaola cow shank ham ball tip swine chicken filet mignon bacon. Ball tip sirloin chuck andouille bacon salami. Leberkas alcatra turducken, shank pig cupim t-bone filet mignon bresaola brisket spare ribs pork chop pork belly. Tail drumstick ribeye pork belly turducken pork chop bacon prosciutto pastrami strip steak. Pastrami pork chop ribeye brisket pork belly ball tip turkey venison ham hock meatball sausage beef drumstick. Frankfurter fatback meatball, jowl sausage prosciutto cow ribeye swine bresaola corned beef capicola.";

            //text.Contains

            //Console.WriteLine(text.IndexOf("bacon"));

            var indices = Find(text,"bacon");

            Console.WriteLine(string.Join(", ",indices));
        }
    }
}

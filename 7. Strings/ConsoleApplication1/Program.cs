using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static List<int> FindOccurences(string text,string word)
        {
            var indices = new List<int>();

            int indexOfNextBacon = text.IndexOf("bacon");
            while (indexOfNextBacon != -1)
            {
                indices.Add(indexOfNextBacon);
                indexOfNextBacon = text.IndexOf("bacon", indexOfNextBacon + 1);
            }

            return indices;
        }

        static void Main()
        {
            var text = @"Bacon ipsum dolor amet bacon filet mignon short loin pork chop, pastrami corned beef shankle drumstick sausage hamburger meatloaf. Tri-tip bresaola cow shank ham ball tip swine chicken filet mignon bacon. Ball tip sirloin chuck andouille bacon salami. Leberkas alcatra turducken, shank pig cupim t-bone filet mignon bresaola brisket spare ribs pork chop pork belly. Tail drumstick ribeye pork belly turducken pork chop bacon prosciutto pastrami strip steak. Pastrami pork chop ribeye brisket pork belly ball tip turkey venison ham hock meatball sausage beef drumstick. Frankfurter fatback meatball, jowl sausage prosciutto cow ribeye swine bresaola corned beef capicola.";
            
            var indices = FindOccurences(text,"bacon");

            Console.WriteLine(string.Join(", ",indices));
        }
    }
}

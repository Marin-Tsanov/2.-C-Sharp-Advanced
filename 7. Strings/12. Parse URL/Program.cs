using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Parse_URL
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string protocol = "://";
            int index1 = input.IndexOf(protocol);
            string server = "/";
            int index2 = input.IndexOf(server, index1 + protocol.Length);

            string substringProtocol = input.Substring(0,index1);
            string substringServer = input.Substring(index1 + protocol.Length, index2-index1-protocol.Length);
            string substringResource = input.Substring(index2);

            Console.WriteLine("[protocol] = {0}", substringProtocol);
            Console.WriteLine("[server] = {0}",substringServer);
            Console.WriteLine("[resource] = {0}",substringResource);
        }
    }
}

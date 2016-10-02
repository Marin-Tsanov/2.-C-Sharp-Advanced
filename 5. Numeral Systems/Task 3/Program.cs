using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main()
        {
            int coder = 0;
            int food = 0;
            int deadlock = 0;

            string resultFinal = "Coder souls collected: " + coder.ToString()
                 + "\r\n" + "Food collected: " + food.ToString()
                 + "\r\n" + "Deadlocks: " + deadlock.ToString();


            Console.WriteLine(resultFinal);


            //int counter = 0;

            //string resultFinal = "You are deadlocked, you greedy kitty!"
            //        + "\r\n" + "Jumps before deadlock: "
            //        + counter.ToString();

            //Console.WriteLine(resultFinal);


        }
    }
}

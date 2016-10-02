using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task_2
{
    class Program
    {
        static string Method(char[] a, long[] path, long coder, long food,
                            long deadlock, long counter,
                            long b)
        {
            string resultFinal = "";
            bool kitty = true;

            for (long i = 0; i < path.Length; i++)
            {
                b += path[i];

                if (b < 0)
                {
                    while (b < 0 /*&& b>=a.Length-1*/)
                    {
                        b = a.Length + b;
                    }
                }
                else if (b > a.Length - 1)
                {
                    while (/*b >= 0 &&*/ b > a.Length - 1)
                    {
                        b = b - (a.Length /*- 1*/);
                    }
                }

                char result = a[b];

                if (result == '0')
                {
                    counter++;
                    continue;
                }

                else if (result == '@')
                {
                    coder += 1;
                    a[b] = '0';
                    counter++;
                }
                else if (result == '*')
                {
                    food += 1;
                    a[b] = '0';
                    counter++;
                }

                else if (result == 'x')
                {
                    if (b % 2 == 0)
                    {
                        if (coder > 0)
                        {
                            coder -= 1;
                            deadlock += 1;
                            counter++;
                        }

                        else if (coder <= 0)
                        {
                            counter += 1;
                            kitty = false;
                            break;
                        }
                    }

                    else if (b % 2 == 1)
                    {
                        if (food > 0)
                        {
                            food -= 1;
                            deadlock += 1;
                            counter++;
                        }

                        else if (food <= 0)
                        {
                            counter += 1;
                            kitty = false;
                            break;
                        }
                    }
                }
            }

            if (kitty == true)
            {
                resultFinal = "Coder souls collected: " + coder.ToString()
                     + "\r\n" + "Food collected: " + food.ToString()
                     + "\r\n" + "Deadlocks: " + deadlock.ToString();

            }
            else
            {
                resultFinal = "You are deadlocked, you greedy kitty!"
                    + "\r\n" + "Jumps before deadlock: "
                    + counter.ToString();
            }

            return resultFinal;
        }


        static void Main()
        {
            char[] a = Console.ReadLine().ToCharArray();
            long[] path = Console.ReadLine()
                                   .Split(' ')
                                 .Select(long.Parse)
                                 .ToArray();

            long coder = 0;
            long food = 0;
            long deadlock = 0;
            long counter = 0;

            long b = 0;

            if (a[0] == '@')
            {
                coder = 1;
                a[0] = '0';
                Console.WriteLine(Method(a, path, coder,
                    food, deadlock, counter, b));
            }

            else if (a[0] == '*')
            {
                food = 1;
                a[0] = '0';
                Console.WriteLine(Method(a, path, coder,
                            food, deadlock, counter, b));
            }

            else if (a[0] == 'x')
            {
                Console.WriteLine("You are deadlocked, you greedy kitty!"
                    + "\r\n" + "Jumps before deadlock: "
                    + counter.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Exception_handling
{
    class Program
    {
        static void Method2()
        {
            throw new Exception("Exception from method 2");
        }

        static void Method1()
        {
            Console.WriteLine("Before method 2");
            try
            {
                Method2();
            }
            catch (Exception ex)
            {
                throw; // throw gives the whole error message involving all the methods in the error
                       // throw ex gives the error message excluding the last method in which it appeared
                       // there is a difference between throw and throw ex
                       // check Kotseto lection 25.05.2016    57 min. 

            } 
            Console.WriteLine("After method 2");
        }

        static void Main()
        {
            try
            {
                Method1();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
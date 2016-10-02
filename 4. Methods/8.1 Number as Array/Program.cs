using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1_Number_as_Array
{
    class Program
    {
        static void Main()
        {
            //int[] array = new int[] { 3, 3 };
            //int[] array1 = new int[] { 0, 3, 9, 3, 2 };
            //int[] array2 = new int[] { 5, 9, 5, 1, 7 };

            //int[] array1 = new int[] { 1, 1 };
            //int[] array2 = new int[] { 1, 9 };

            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] array2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


            if (array[0] < array[1])
            {
                Calculte(array1, array2);
            }
            else if (array[0] > array[1])
            {
                Calculte(array2, array1);
            }
            else
            {
                Calculte1(array1, array2);
            }
        }

        static void Calculte(int[] array1, int[] array2)
        {
            List<int> intList = new List<int>();

            int ednonaum = 0;
            int number = 0;
            int number1 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                number = array1[i] + array2[i] + ednonaum;
                ednonaum = 0;
                if (number >= 10)
                {
                    number = number % 10;
                    ednonaum = 1;
                    intList.Add(number);
                }
                else
                {
                    intList.Add(number);
                }

            }
            for (int j = array1.Length; j < array2.Length; j++)
            {
                number1 = array2[j] + ednonaum;
                ednonaum = 0;

                if (number1 == 10)
                {
                    number1 = number1 % 10;
                    ednonaum = 1;
                    intList.Add(number1);
                }
                else
                {
                    intList.Add(number1);
                }

                if (j == array2.Length - 1 && ednonaum == 1)
                {
                    intList.Add(ednonaum);
                }
                else
                {
                    continue;
                }

            }
            foreach (var item in intList)
            {
                Console.Write("{0} ", item);
            }
        }

        static void Calculte1(int[] array1, int[] array2)
        {

            List<int> intList = new List<int>();

            int ednonaum = 0;
            int number = 0;
            int number1 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                number = array1[i] + array2[i] + ednonaum;
                ednonaum = 0;
                if (number >= 10)
                {
                    number = number % 10;
                    ednonaum = 1;
                    intList.Add(number);
                }
                else
                {
                    intList.Add(number);
                }

                if (i == array2.Length - 1 && ednonaum == 1)
                {
                    intList.Add(ednonaum);
                }
                else
                {
                    continue;
                }
            }
            foreach (var item in intList)
            {
                Console.Write("{0} ", item);
            }
        }




    }
}


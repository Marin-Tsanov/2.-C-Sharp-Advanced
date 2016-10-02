using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3_Lover_of_3
{
    class Program
    {
        static void Main()
        {
            long[] array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long[,] multiarray = new long[array[0], array[1]];

            long rowfill = -3;

            for (int row = multiarray.GetLength(0)-1; row >=0; row--)
            {
                rowfill += 3;
                long colfill = rowfill;

                for (int col = 0; col < multiarray.GetLength(1); col++)
                {
                    multiarray[row, col] = colfill;
                    colfill += 3;
                }
            }

            int n = int.Parse(Console.ReadLine());
            string[] direct = {""};
            string[] d = new string[n];
            int[] k = new int[n];  

            for (int i = 0; i < n; i++)
            {
                direct = Console.ReadLine().Split(' ');
                d[i] = direct[0];
                k[i] = int.Parse(direct[1]);
            }

            long rowWork = array[0]-1;
            long colWork = 0;
            long sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (d[i]== "UR" || d[i] == "RU")
                {
                    while (((rowWork != array[0]) && (rowWork != -1)) && 
                            ((colWork != array[1]) && (colWork!=-1)) &&
                            k[i]!=0)
                    {
                        sum += multiarray[rowWork, colWork];
                        multiarray[rowWork, colWork] = 0;
                        rowWork--;
                        colWork++;
                        k[i]--;
                    }
                    rowWork += 1;
                    colWork -= 1;
                }

                else if (d[i] == "UL" || d[i] == "LU")
                {
                    while (((rowWork != array[0]) && (rowWork != -1)) &&
                            ((colWork != array[1]) && (colWork != -1)) &&
                            k[i] != 0)
                    {
                        sum += multiarray[rowWork, colWork];
                        multiarray[rowWork, colWork] = 0;
                        rowWork--;
                        colWork--;
                        k[i]--;
                    }
                    rowWork += 1;
                    colWork += 1;
                }

                else if (d[i] == "DR" || d[i] == "RD")
                {
                    while (((rowWork != array[0]) && (rowWork != -1)) &&
                            ((colWork != array[1]) && (colWork != -1)) &&
                            k[i] != 0)
                    {
                        sum += multiarray[rowWork, colWork];
                        multiarray[rowWork, colWork] = 0;
                        rowWork++;
                        colWork++;
                        k[i]--;
                    }
                    rowWork -= 1;
                    colWork -= 1;
                }

                else if (d[i] == "DL" || d[i] == "LD")
                {
                    while (((rowWork != array[0]) && (rowWork != -1)) &&
                            ((colWork != array[1]) && (colWork != -1)) &&
                            k[i] != 0)
                    {
                        sum += multiarray[rowWork, colWork];
                        multiarray[rowWork, colWork] = 0;
                        rowWork++;
                        colWork--;
                        k[i]--;
                    }
                    rowWork -= 1;
                    colWork += 1;
                }
            }

            Console.WriteLine(sum);
        }
    }
}

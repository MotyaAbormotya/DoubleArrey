using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] array = new string[7, 7];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array.GetLength(1) / 2 <= j || i >= array.GetLength(0) / 2)
                    {
                        array[j, i] = "0";
                    }
                    else
                    {
                        array[j, i] = "X";
                    }

                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

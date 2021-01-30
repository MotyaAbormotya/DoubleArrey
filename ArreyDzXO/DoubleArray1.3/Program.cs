using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray1._3
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
                    if (i <= array.GetLength(1) / 2 && j >= i && j <= array.GetLength(1) - i - 1 || i >= array.GetLength(1) / 2 && j <= i && j >= array.GetLength(1) - i - 1)
                    {
                        array[i, j] = "X";
                    }
                    else
                    {
                        array[i, j] = "0";
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

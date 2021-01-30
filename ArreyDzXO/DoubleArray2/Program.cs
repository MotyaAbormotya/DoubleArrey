using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 4];
            int resultJ = 1;
            int resultI = 0;
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(0, 15 + 1);
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
            for (int i = 0; i < array.GetLength(0); i++)
            {
                resultJ *= array[i, 0];
            }

            for (int j = 0; j < array.GetLength(1); j++)
            {
                resultI += array[1, j];
            }

            Console.Write(resultI + " " + resultJ);

            Console.ReadKey();
        }
    }
}

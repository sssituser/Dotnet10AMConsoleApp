using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            int[,] array1 = { { 1, 2 }, { 3, 4 } };
            int[,] array2 = { { 5, 6 }, { 7, 8 } };

            Console.WriteLine("====Array-1 Elements=======");
            for (int row = 0; row < 2; row++) { 
                for(int col = 0; col < 2; col++)
                {
                    Console.Write($"{array1[row, col]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("====Array-2 Elements=======");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{array2[row, col]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("====Sum of Array-1 and Array-2 Elements=======");
            for (int row = 0; row < 2; row++)
            {
                for (int col = 0; col < 2; col++)
                {
                    Console.Write($"{array1[row, col]+ array2[row, col]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}

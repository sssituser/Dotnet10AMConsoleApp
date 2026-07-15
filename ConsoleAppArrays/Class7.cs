using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            int[,] array = { {1,2,3 },{ 4, 5, 6 },{ 7, 8, 9 } };

            Console.WriteLine("Arrays elements in terms rows and cols");
            for(int row = 0; row < 3; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    Console.Write($"{array[row,col]}\t");
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("=========Diagonal Elements==========");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                  if(row==col || row + col == 2)
                    {
                        Console.Write($"{array[row,col]}\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("=========Diagonal Elements==========");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    if (row == col || row + col == 2)
                    {
                       
                        Console.Write("\t");
                    }
                    else
                    {
                        Console.Write($"{array[row, col]}\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}

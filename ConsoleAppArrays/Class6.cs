using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            int[,] ints = new int[2,3]{{12,34,56},   {78,90,88}  };

            Console.WriteLine("Displaying the elements using for loop ");
            for(int row = 0; row < 2; row++)// row = 0  0<2-T  row = 1 1<2-T row = 2 2<2-F
            {
                for(int col = 0; col < 3; col++) // col = 0 0<3 - T col++ col = 1; 1<3-T col = 2 2<3-T
                {                                // col=3 3<3-F
                    Console.WriteLine(ints[row,col]); // 12  34  56 ,78  90  88
                }

            }

            Console.WriteLine("Displayig the elements using foreach loop");

            foreach(int element in ints)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("===Displaying the elements  rows and col======");
            for(int row = 0;row<2; row++)
            {
                for(int col = 0; col < 3; col++)
                {
                    Console.Write($"{ints[row, col]}\t");
                }
                Console.WriteLine();
            }


        }
    }
}

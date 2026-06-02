using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    /*Write program to generate number from 1 to given nuumber
     * num = 20  1 4 7 11 15 19
     * 
     * Write program to generate number square of the given number from 1
     * num = 5          1   4   9   16  25
     * num = 10         1   4   9   16  25  36  49  64  81  100
     */
    internal class Class4
    {
        static void Main(string[] args)
        {
            //write a program to generate the numbers from the given number to 1
            // num = 5   res = 5 4 3 2 1  // 25 16 9 4 1
            // num = 10   res = 10 9 8 7 6 5 4 3 2 1
            Console.Write("Enter a number : ");
            int start = int.Parse(Console.ReadLine()); // start = 5
            int end = 1;

            do
            {
                Console.WriteLine(start); // start = 5 start = 4 start = 3 start = 2 start = 1
                start = start - 1; // start = 4 start = 3 start = 2 start = 1 start = 0
            }
            while (start >= end); //5>=1 -T 4>=1 -T 3>=1 T 2>=1 T  1>=1 - True 0>=1-F

        }
    }
}

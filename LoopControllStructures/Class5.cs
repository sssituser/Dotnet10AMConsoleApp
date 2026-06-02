using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// write a program to find the sum of n number ?
// num = 5  sum = 1+2+3+4+5 => 15
namespace LoopControllStructures
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // num = 5
            int start = 1;
            int sum = 0;

            while (start <= num) // 1<=5-T 2<=5 3<=5 4<=5 5<=5 6<=5->F
            {
                Console.WriteLine(start); // 1 2 3 4 5
                sum = sum + start; // sum = 1 sum = 3 sum = 6 sum = 10 sum = 15
                start = start + 1; // start = 2,3,4,5,6

            }
            Console.WriteLine($"Sum is : {sum}");

        }
    }
}

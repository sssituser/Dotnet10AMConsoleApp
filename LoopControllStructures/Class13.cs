using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number to find the factors : ");
            int num = int.Parse(Console.ReadLine()); //num = 24
            int start = 1;
            Console.Write($"{num} Factors are   ");
            while (start <= num)// 1<=24-T
            {
                if (num % start == 0)
                {
                    Console.Write($"{start}    ");
                }
                start = start + 1;
            }

        }
    }
}
//12  -> 1,2,3,4,6
//8 -> 1,2,4,8

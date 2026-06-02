using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class2
    {
        //Write program to generate numbers from 1 to given number
        //Example Enter number : 5     1 2 3 4  5
        //Enter number : 10   1 2 3 4 5 6 7 8 9 10
        static void Main(string[] args)
        {
            int start = 1;
            Console.Write("Enter End value : ");
            int end = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(start);
                start = start + 1;
            }
            while (start <= end);


        }
    }
}

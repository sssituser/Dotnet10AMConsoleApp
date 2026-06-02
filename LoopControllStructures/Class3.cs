using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class3
    {/*Write a program to generate numbers from 1 to given number
      * num = 20    1,3,5,7,9,11,13,15,17,19
      */
        static void Main(string[] args)
        {
            int start = 1;
            Console.Write("Enter End value : ");
            int end = int.Parse(Console.ReadLine());
            do
            {
                Console.WriteLine(start);
                start = start + 2;
            } while (start <= end);
        }
    }
}

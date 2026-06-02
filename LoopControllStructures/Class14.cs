using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    //Write program to count the factors of a given number
    // num = 12     factors = 1,2,3,4,6,12====> 12 has 6 factors
    internal class Class14
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int count = 0;
            int sum = 0;
            while (start <= num)
            {
                if (num % start == 0)
                {
                    Console.WriteLine(start); // displaying factor
                    sum = sum + start; // sum of the factors
                    count++; // counting factors
                }
                start = start + 1;
            }

            Console.WriteLine($"{num} has {count} factors"); // displaying the count
            Console.WriteLine($"{num} factors sum is {sum}"); // displaying

        }
    }
}

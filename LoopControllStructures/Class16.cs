using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    // Write a program to check given number is perfect or not
    // num = 6   1+ 2+ 3=>6 
    //num = 10   1,2,5 => 8
    // num = 12  1,2,3,4,6=>16
    // num = 28  1,2,4,7,14=>28 is prefect numger
    internal class Class16
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int sum =0;

            while (start < num)
            {
                if (num % start == 0)
                {
                    sum = sum + start;
                }
                start++;

            }
            if (sum == num)
            {
                Console.WriteLine($"{num} is a perfect number ");
            }
            else
            {
                Console.WriteLine($"{num} is not a Perfect number ");
            }
        }
    }
}

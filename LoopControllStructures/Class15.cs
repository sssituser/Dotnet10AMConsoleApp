using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class15
    {
        // Prime number : If a number is perfectly divisible by 1 and iteself is called primenumber
        //Prime number has 2 factors
        // write a program to check the given number is prime or not
        // 7 has 2 factors=> 7 is prime number
        // 5 has 2 factors > 5 is prime number
        // 13 has 2 factors => 13 is prime number
        // 10 has 1,2,5,10 => 10 is not a prime number
        // 15 has 1,3,5,15 => 15 is not a prime number
        // 17 has 1,17 => 17 prime number
        static void Main(string[] args)
        {
            Console.Write("Enter a number to Check Prime or Not : ");
            int num = int.Parse(Console.ReadLine());
            int start = 1;
            int count = 0;
            while (start <= num)
            {
                if (num % start == 0)
                {
                    count++;
                }
                start++;
            }
            if (count == 2)
            {
                Console.WriteLine($"{num} is a Prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a Prime number");
            }

        }
    }
}

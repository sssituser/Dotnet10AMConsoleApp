using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class23
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); //145
            int OriginalNumber = num;int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;// separte the digit
                
                int start = 1; int fact = 1; // factorial code
                while (start <= digit)
                {
                    fact = fact * start;
                    start++;
                }

                sum = sum + fact; // sum of the factorial
                num = num / 10;
            }
            if (sum == OriginalNumber)
            {
                Console.WriteLine($"{OriginalNumber} is a Strong number");
            }
            else
            {
                Console.WriteLine($"{OriginalNumber} is not a Strong number");
            }
        }
    }
}

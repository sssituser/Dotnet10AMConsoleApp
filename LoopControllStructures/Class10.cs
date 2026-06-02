using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // num = 654
            int max = num % 10; // int max = 4
            while (num > 0) // 654>0-T 65>0-T 6>0-T 0>0-F
            {
                int digit = num % 10; // digit = 654%10 digit = 4 digit =65%10 digit = 5 digit = 6%10 digit = 6
                if (max < digit)
                {
                    max = digit;// max = 5 max = 6
                }
                num = num / 10; // num = 654/10 num = 65 num = 65/10 num = 6/10 num = 0
            }
            Console.WriteLine($"Max digit is {max}");
        }
    }
}

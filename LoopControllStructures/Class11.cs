using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // num = 456
            int rev = 0;
            while (num > 0) // 456>0 45>0 4>0-T 0>0
            {
                int digit = num % 10; // digit = 456%10 digit = 6 digit = 45%10 digit = 5 digit = 4
                rev = rev * 10 + digit; // rev = 6 rev = 65 rev = 654
                num = num / 10; // num = 456/10 num = 45/10 num = 4/10 num = 0
            }
            Console.WriteLine($"Reverse number is : {rev}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            while (num > 0) {
                int digit = num % 10;
                sum = sum + digit;
                num = num / 10;
            }
            Console.WriteLine($"Sum of the digits of the above number is :{sum}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            int start = 1;
            while (start <= num)
            {
              
                fact = fact * start;
                start = start + 1;
            }
            Console.WriteLine($"Factorial of  {num} is : {fact}");
        }
    }
}

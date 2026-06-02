using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            while (num > 0)
            {
                int digit = num % 10;
                count++;
                num = num / 10;
            }
            Console.WriteLine($"No digis present in the above numer is :{count}");
        }
    }
}

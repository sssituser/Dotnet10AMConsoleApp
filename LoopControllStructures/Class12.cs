using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); // num = 153
            int copy = num; // copy = 153  num = 153
            int sum = 0;    // sum = 0

            while (num > 0) // 153>0-T 15>0-T 1>0-T 0>0-F num = 0
            {
                int digit = num % 10;// digit = 153%10 digit = 3 digit = 15%10 digit = 5 digit =1%10 digit = 1
                sum = sum + digit * digit * digit; // sum = 0+27 sum = 27 sum = 27+125 => sum = 152 sum = 152+1 => 153
                num = num / 10;// num = 153/10 num = 15 num = 15/10 num = 1/10 num = 0

            }
            if (copy == sum)
            {
                Console.WriteLine($"{copy} Is An Armstrong Number");
            }
            else
            {
                Console.WriteLine($"{copy} Is Not An Armstrong Number");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class23
    {
        // Create method which can calculate sum of n numbers
        public static int Sum(int num) // num = 5 num = 4 num = 3 num = 2 num = 1 num == 0
        {
            if (num == 0) // 5==0 -F 4==0-F 3==0 -F 2 == 0 -F 1 == 0 -F 0 == 0 -T
            {
                return 0; // 0
            }
            return num + Sum(num - 1);// 5+10=
        }
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine($"Sum of {num} numbers is {Sum(num)} ");
            num = 10;
            Console.WriteLine($"Sum of {num} numbers is {Sum(num)} ");

        }
    }
}

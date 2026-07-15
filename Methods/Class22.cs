using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class22
    {
        public static int Factorial(int num) // num = 5 num = 4 num = 3 num = 2 num = 1
        {
            if (num == 1) // 5==1 - F  4==1 - F 3==1 -F  2 == 1 -F 1==1-T
            {
                return 1;
            }
            return num * Factorial(num - 1); // 5*24=> return 120
        }
        static void Main(string[] args)
        {
            int num = 5;
            Console.WriteLine($"{num}! is {Factorial(num)}");
            num = 4;
            Console.WriteLine($"{num}! is {Factorial(num)}");
        }
    }
}

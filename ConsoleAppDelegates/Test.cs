using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegates
{
    internal class Test
    {
        public static void Sum(int num1,int num2)
        {
            Console.WriteLine($"Sum is : {num1+num2}");
        }
        public static void Sub(int num1, int num2)
        {
            Console.WriteLine($"Sub is : {num1 - num2}");
        }
        public  void Mul(int num1, int num2)
        {
            Console.WriteLine($"Mul is : {num1 * num2}");
        }
        public  void Div(int num1, int num2)
        {
            Console.WriteLine($"Quo is : {num1 / num2}");
        }
    }
}

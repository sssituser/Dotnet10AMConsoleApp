using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class7
    {
        static void Main(string[] args)
        {
            /*
             
             * 
             * Write program to read to numbers and find the maximum number.
             */

            Console.Write("Enter   number-1  : "); // 10
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number-2 : "); //20
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1>num2 ? $"{num1} is Max":$"{num2} is Max");
        }
    }
}










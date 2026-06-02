using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            Console.Write("enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            int sum = num1 + num2;
            Console.Write($"num1 + num2 :{sum} ");
            int sub = num1 - num2;
            Console.Write($"num1 - num2 :{sub} ");
            int mul = num1 * num2;
            Console.Write($"num1 * num2 : {mul}");
            int mod = num1 % num2;
            Console.Write($"num1 % num2 :{mod} ");
               

              

            //Console.WriteLine($"{num1 + num2}\n{num1 - num2}\n{num1 * num2}\n{num1 % num2}");

        }
    }
}

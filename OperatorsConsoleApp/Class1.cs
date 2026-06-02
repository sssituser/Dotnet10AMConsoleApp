using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Num1 : {num1}\tNum2 : {num2}");
            Console.WriteLine($"Sum : {num1+num2}\tSub : {num1-num2}\tMul : {num1*num2}\tQuo : {num1/num2}\tRem : {num1%num2}");

        }
    }
}

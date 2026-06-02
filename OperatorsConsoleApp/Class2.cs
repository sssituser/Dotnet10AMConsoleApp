using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter num3 : ");
            int num3 = int.Parse(Console.ReadLine());

            int sum = 0;
            sum = num1 + num2 + num3;
            int avg = 0;
            avg = sum / 3;
            Console.WriteLine($"num1 = {num1}\nnum2 = {num2}\nnum3 = {num3}\nSum = {sum}\tAverage : {avg}");


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.Write("Enter num1 : "); // 5
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter num2 : "); // 2
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} > {num2} -> {num1>num2}");
            Console.WriteLine($"{num1} >= {num2} -> {num1>=num2}");
            Console.WriteLine($"{num1} < {num2} -> {num1<num2}");
            Console.WriteLine($"{num1} <= {num2} -> {num1<=num2}");
            Console.WriteLine($"{num1} == {num2} -> {num1==num2}");
            Console.WriteLine($"{num1} != {num2} -> {num1!=num2}");






        }
    }
}

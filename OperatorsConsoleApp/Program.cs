using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            // Initialization
            int a = 5;
            int b = 2;

            // Displaying
            Console.WriteLine($"{a+b}\n{a-b}\n{a*b}\n{a/b}\n{a%b}");
            Console.WriteLine($"a = {a}\t b = {b}");
            Console.WriteLine($"Sum : {a + b}\nSub : {a - b}\nMul : {a * b}\nQuo : {a / b}\nRem : {a % b}");
        }
    }
}

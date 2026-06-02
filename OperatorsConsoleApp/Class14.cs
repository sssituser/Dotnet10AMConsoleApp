using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class14
    {
        static void Main(string[] args)
        {
            int a = 20;
            Console.WriteLine($"a = {a}"); // a = 20

            Console.WriteLine($"a = {a--}"); // a = 20

            Console.WriteLine($"a = {a}"); // a = 19
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class12
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Sub1 Marks : ");
            int sub1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Sub2 Marks : ");
            int sub2 = int.Parse(Console.ReadLine());
            Console.Write("Enter sub3 Marks : ");
            int sub3 = int.Parse(Console.ReadLine());
            string res = sub1 < 35 || sub2 < 35 || sub3 < 35 ? "Failed" : "Passed";
            Console.WriteLine($"Student {res}");

        }
    }
}

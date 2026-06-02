using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Subject-1 Marks : "); // 50
            int sub1 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject-2 Marks : "); //40
            int sub2 = int.Parse(Console.ReadLine());
            Console.Write("Enter Subject-3 Marks : "); //60
            int sub3 = int.Parse(Console.ReadLine());
            Console.WriteLine(sub1>34 && sub2>34 && sub3>34);
            string res = sub1 > 34 && sub2 > 34 && sub3 > 34 ? "Bye" : "Hi";
            Console.WriteLine(res);

        }
    }
}

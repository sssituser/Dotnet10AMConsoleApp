using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace App2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Class1.Mul(5, 6));
            Console.WriteLine(Class1.Div(7, 2));
            Class1 s = new Class1();
            Console.WriteLine(s.Add(5,2));
            Console.WriteLine(s.Sub(5,2));
        }
    }
}

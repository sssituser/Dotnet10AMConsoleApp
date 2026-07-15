using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(25));
            Console.WriteLine(Math.Pow(2, 3));
            Console.WriteLine(Math.Pow(3, 3));
            Console.WriteLine(Math.Floor(5.7));
            Console.WriteLine(Math.Ceiling(7.8));
            Console.WriteLine(Math.Max(56, 78));
            Console.WriteLine(Math.Min(1, 2));
            Console.WriteLine(Math.Sin(90));
            Console.WriteLine(Math.Cos(0));
            Console.WriteLine($"Quo : {Math.DivRem(5, 2, out int result)} Rem :{result}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    class Mover
    {
        public static void Area(int l,int b)
        {
            Console.WriteLine($"Area of  Rectangle is : {l*b}");
        }
        public static void Area(double r)
        {
            Console.WriteLine($"Area of a Circle is : {3.14*r*r}");
        }
        public static void Area(int s)
        {
            Console.WriteLine($"Area of a square : {s*s}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Mover.Area(6.7);
            Mover.Area(5);
            Mover.Area(5, 7);
        }
    }
}

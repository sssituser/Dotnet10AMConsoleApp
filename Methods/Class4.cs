using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a".CompareTo("b"));
            Console.WriteLine("a".CompareTo("c"));
            Console.WriteLine("a".CompareTo("d"));
            Console.WriteLine("a".CompareTo("e"));
            Console.WriteLine("a".CompareTo("f"));

            Console.WriteLine("b".CompareTo("a"));
            Console.WriteLine("c".CompareTo("a"));
            Console.WriteLine("d".CompareTo("a"));
            Console.WriteLine("e".CompareTo("a"));
            Console.WriteLine("f".CompareTo("a"));
            Console.WriteLine("g".CompareTo("a"));
            Console.WriteLine("g".CompareTo("g"));
            Console.WriteLine("a".CompareTo("a"));
            Console.WriteLine("b".CompareTo("b"));
        }
    }
}

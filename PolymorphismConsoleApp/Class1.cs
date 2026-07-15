using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    class Test
    {
        public void Show(int x,int y)
        {
            Console.WriteLine($"x = {x}\t y = {y}");
        }
        public void Show(string x, string y)
        {
            Console.WriteLine($"x = {x}\t y = {y}");
        }
        public void Show(double x, double y)
        {
            Console.WriteLine($"x = {x}\t y = {y}");
        }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            Test  t1 = new Test();
            t1.Show(5,6);
            Test t2 = new Test();
            t2.Show("abc", "def");
            Test t3 = new Test();
            t3.Show(5.6,7.9);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Calcy
    {
        public void Sum(int x,int y)
        {
            Console.WriteLine($"Sum is : {x+y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"Sub is : {x - y}");
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine($"Mul is : {x * y}");
        }
    }
}

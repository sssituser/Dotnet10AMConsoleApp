using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class SciCalcy : Calcy // Inheritnce
    {
        public void Sine(int val)
        {
            Console.WriteLine($"Sine {val} is {Math.Sin(val)}");
        }
        public void Cos(int val)
        {
            Console.WriteLine($"Cos {val} is {Math.Cos(val)}");
        }
        
    }
}

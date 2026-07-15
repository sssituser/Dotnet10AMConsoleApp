using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            SciCalcy sc =  new SciCalcy();
            sc.Sine(90);
            sc.Cos(0);
            sc.Sum(5, 2);
            sc.Sub(5, 2);
            sc.Mul(4,5);
            
        }
    }
}

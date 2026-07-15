using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calcy cal = new Calcy();
            cal.Sum(10, 20);
            cal.Sub(30, 20);
            cal.Mul(5, 2);
        }
    }
}

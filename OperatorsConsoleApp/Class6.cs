using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            // ? :   con ? stmt1 : stmt2 con->True stmt1 execute con->False stmt2 can be execute
            //        a>b? x : y   a = 5  b = 20   x = 10  y = 20   Ans :x (10) y(20)
            // x+y + is binary opertors
            // -y  - is unary operator
            // x-y  - is binary operator
            int a = 5;
            int b = 2;
            int x = 10;
            int y = 20;
            Console.WriteLine(a<b?x:y);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class LogincalOperators
    {
        static void Main(string[] args)
        {
            Console.WriteLine(true && true && true && true); // true
            Console.WriteLine(true && true && true && false); // false
            Console.WriteLine(false || false || false || false);//false
            Console.WriteLine(false|| true ||false || false);//true
        }
    }
}

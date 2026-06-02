using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{

    // Home Work  Convert Rupees into Dollars
    // Convert Deg into Fh
    // Convert Fh into Deg
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter no of Dollars to Convert Into Indian Rupee : ");
            int dollars = int.Parse(Console.ReadLine());
            Console.WriteLine($"{dollars}$ Equals Rs.{dollars*90}");
        }
    }
}

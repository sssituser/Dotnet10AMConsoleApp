using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet10AMConsoleApp
{
    internal class Class14
    {
        //Console.Read Example
        static void Main(string[] args)
        {
            Console.Write("Enter a character : ");
            int res = Console.Read();
            Console.WriteLine($"ASCII Value of the above Character is : {res}");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp.Properties
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("ONE");
            } else if (num == 2)
            {
                Console.WriteLine("TWO");
            } else if (num == 3)
            {
                Console.WriteLine("THREEE");
            }
            else
            {

                Console.WriteLine("Entered number is other than 1,2,3");

            }
        }
    }
}

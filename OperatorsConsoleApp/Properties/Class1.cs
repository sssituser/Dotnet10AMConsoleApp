using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp.Properties
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("Enter  a number : ");
            int num = int.Parse(Console.ReadLine()); // -200
            if (num > 0) //-200>0-F
            {
                if (num < 10) // <10-T
                {
                    Console.WriteLine($"{num} is +ve and single digit");
                }
                else
                {
                    Console.WriteLine($"{num} is +ve but not a single digit");
                }

            }
            else
            {
                Console.WriteLine("Entred Number is not a +ve");
            }
        }
    }
}

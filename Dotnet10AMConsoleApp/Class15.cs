using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet10AMConsoleApp
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name : "); // output method
            string name = Console.ReadLine(); //input method read string

            Console.Write("Enter Date of Birth :");
            int age = int.Parse(Console.ReadLine());


            Console.WriteLine($"Name : {name}\tAge : {age}");
        }
    }
}

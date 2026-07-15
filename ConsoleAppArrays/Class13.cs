using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class13
    {
        static void Main(string[] args)
        {
            string s = "welcome";
            Console.WriteLine($"Given string is : {s}"); // lower case
            s.ToUpper();
            Console.WriteLine($"Given string after conversion : {s}"); // welcome WELCOME
        }
    }
}

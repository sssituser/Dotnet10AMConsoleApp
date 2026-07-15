using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class1
    {
        static void Main(string[] args)
        {//Example String Immutablity
            string s = "welcome";
            Console.WriteLine($"Given string is : {s}"); // lower case
            string res =  s.ToUpper();
            Console.WriteLine($"Result is string :{res}");
            Console.WriteLine($"Given string after conversion : {s}"); // welcome 
        }
    }
}

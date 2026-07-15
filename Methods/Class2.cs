using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            string res = "sssit";
            Console.WriteLine(res.IndexOf('s'));
            Console.WriteLine(res.LastIndexOf('s'));
            Console.WriteLine(res.ElementAt(4));
            Console.WriteLine(res.Contains("it"));
            Console.WriteLine(res.Contains("IT"));
            Console.WriteLine(res.Substring(0,2));

        }
    }
}

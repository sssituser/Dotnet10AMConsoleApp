using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegates
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Program s = new Program();
            int res = s.Rev(123);
            Console.WriteLine(res);
            Console.WriteLine(s.Dts(10));
        }
    }
}

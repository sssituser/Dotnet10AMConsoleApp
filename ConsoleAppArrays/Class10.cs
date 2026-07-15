using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[3][];
            jarray[0] = new int[3];
            jarray[1] = new int[2];
            jarray[2] = new int[4];

            Console.WriteLine($"Size of Jarray :{jarray.Length}");
            Console.WriteLine($"Size of jarray[0] : {jarray[0].Length}");
            Console.WriteLine($"Size of jarray[1] : {jarray[1].Length}");
            Console.WriteLine($"Size of jarray[2] : {jarray[2].Length}");
        }
    }
}

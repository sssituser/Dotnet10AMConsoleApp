using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ints = { 45, 56, 78, 90, 34, 21, 35, 88 };
            Console.WriteLine($"Total Eelements Present in the array :{ints.Length}");
            Console.WriteLine($"Sum of the Array Elements : {ints.Sum()}");
            Console.WriteLine($"Maximum element in the Array : {ints.Max()}");
            Console.WriteLine($"Minimum element in the Array : {ints.Min()}");
            Console.WriteLine($"Averages of the elements in the Array : {ints.Average()}");
        }
    }
}

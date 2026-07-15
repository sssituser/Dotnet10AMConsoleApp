using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 1, 2, 4, 3, 8, 6, 9, 7 };
            Console.WriteLine("Array elements are");
            foreach(int num in nums)
            {
                Console.Write($"{num} ");
            }
            Console.WriteLine("\nArray elements in Ascending order");
            int[] ascends = nums.OrderBy(x => x).ToArray();

            foreach(int num in ascends)
            {
                Console.Write($"{num}  ");
            }

            Console.WriteLine("\nArray elements in Ascending order");
            int[] descends = nums.OrderByDescending(x => x).ToArray();

            foreach (int num in descends)
            {
                Console.Write($"{num}  ");
            }


        }
    }
}

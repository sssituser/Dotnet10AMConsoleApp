using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            int[] nums = { 21,45,12,21,56,78,90,67,78,56,91,88,87,87 };
          
            Console.WriteLine("========Array elements are============");
            foreach(int num in nums)
            {
                Console.Write($"{num}  ");
            }
            Console.WriteLine("\n========Array elements are after removing duplicates============");
            int[] result = nums.Distinct().ToArray();

            foreach(int num in result)
            {
                Console.Write($"{num}  ");
            }
            Console.WriteLine("\n=====================Duplicate elements in the array======");
            
            int[] duplicates = nums.GroupBy(x => x)
                .Where(num => num.Count() == 2)
                .Select(g => g.Key).ToArray();

            foreach(int num in duplicates)
            {
                Console.Write($"{num}  ");
            }

            Console.WriteLine("\n=====================Uniqueue elements in the array======");

            int[] uniques = nums.GroupBy(x => x)
                .Where(num => num.Count() == 1)
                .Select(g => g.Key).ToArray();

            foreach (int num in uniques)
            {
                Console.Write($"{num}  ");
            }

        }
    }
}

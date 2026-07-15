using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            int[] ints = { 45, 56, 78, 90, 34, 21, 35, 88, 37, 87 };

            int[] odds = ints.Where(num => num % 2 != 0).ToArray();

            Console.WriteLine("Displaying oddnumbers using for loop  :  ");
            for(int i = 0; i < odds.Length; i++)
            {
                Console.Write($"{odds[i]}\t");
            }

            Console.WriteLine("\nDisplaying oddnumbers using foreach : ");
            foreach(int num in odds)
            {
                Console.Write($"{num}\t");
            }


        }
    }
}

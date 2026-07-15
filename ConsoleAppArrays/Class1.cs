using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int[] ints = { 45, 56, 78, 90, 34, 21, 35, 88,37,87 };

            // Linq(Language Interated Query)

            int[] evennums = ints.Where(num => num % 2 == 0).ToArray();
          
            
            
            Console.WriteLine("=====Displaying the even numbers using for=====");
            for (int i = 0; i < evennums.Length; i++)
            {
                Console.WriteLine(evennums[i]);
            }
            Console.WriteLine("=====Displaying the even numbers using foreach=====");

            foreach(int element in evennums)
            {
                Console.WriteLine(element);
            }




        }
    }
}

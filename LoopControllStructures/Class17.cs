using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{ //Write a progam to generate number for the given number from 1.
// Example num = 5    1 2 3 4 5
    internal class Class17
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter End value : ");
            int end = int.Parse(Console.ReadLine());

            for(int start = 1; start <= end; start++)
            {
                Console.WriteLine(start);
            }

        }
    }
}

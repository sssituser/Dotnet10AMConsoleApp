using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class20
    {
        // Write a program to generate the tables for the given number form 1 table
        // to given number table
        //Example num = 3   
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); 
            for (int start = 1; start <= num; start++)
            {
              
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{start} * {j} = {start*j}");
                }
                Console.WriteLine("************");
            }
        }
    }
}

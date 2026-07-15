using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    // Write a program to genreate multiplcation table for the given number
    internal class Class19
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); 
            for(int start = 1; start <= 10; start++) 
            {
                Console.WriteLine($"{num} * {start} = {num*start}");
            }
        }
    }
}

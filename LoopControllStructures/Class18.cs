using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    //Write program to generate the numbers 1,2,3,4,5,6,7,8,9,10;
    internal class Class18
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine());
            for(int start = 1; start <= 10; start++)
            {
                Console.WriteLine($" {num}  x   {start} = {num*start}  ");
            }
        }
    }
}

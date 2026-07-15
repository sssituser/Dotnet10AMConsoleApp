using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class21
    {
        static void Main(string[] args)
        {
            int num = 5;
            int val = 1;
            for(int start = 1; start <= num; start++)
            {
                for(int j = 1; j <= start; j++)
                {
                    Console.Write($"{val++}\t");
                }
                Console.WriteLine("\n");
               
            }
        }
    }
}

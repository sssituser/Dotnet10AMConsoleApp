using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class22
    {
        static void Main(string[] args)
        {
            int num = 5;
            int val = 1;
            for (int i = 1; i <= num; i++) { 
                for(int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}\t");
                    val++;
                }
                Console.WriteLine();
            }

            for(int i = num - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j}\t");
                    val++;
                }
                Console.WriteLine();
            }
        }
    }
}

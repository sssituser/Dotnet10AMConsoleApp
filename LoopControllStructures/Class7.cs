using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    /*		

        3.Write a program to separate the digits of a number ?
		num = 123  digits = 3   2   1
    % -- mode operator   123%10 ->  3    12%10 ->2   1%10    10)1(0
                                                                0
                                                                --
                                                                 1
    / -> quo   123/10->12
    */
    internal class Class7
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number : ");
            int num = int.Parse(Console.ReadLine()); 
            while (num > 0)  
            {
                int digit = num % 10;  
                Console.WriteLine(digit);  
                num = num / 10; 
            }
        }
    }
}

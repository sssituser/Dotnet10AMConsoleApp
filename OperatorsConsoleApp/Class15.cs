using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class15
    {
        static void Main(string[] args)
        {
            // = +=  -=  *= /=
            int num1 = 10;
            int num2 = 20;
            Console.WriteLine($"num1 = {num1}\tnum2 = {num2}"); // num1 = 10  num2 = 20


            num1 += num2; // num1 = num1+num2
            Console.WriteLine($"num1 = {num1}"); // num1 = 30
            num1 -= num2; // num1 = num1-num2
            Console.WriteLine($"num1 = {num1}"); // num2 = 10
            num1 *= num2;  // num1 = num1*num2
            Console.WriteLine($"num1 = {num1}"); // num2 = 200
            num1 /= num2; // num1 =  num1/num2;
            Console.WriteLine($"num1 = {num1}"); // num2 = 10
                                                 // 







           
        }
    }
}

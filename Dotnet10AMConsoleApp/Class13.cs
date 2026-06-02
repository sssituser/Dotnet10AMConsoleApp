using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet10AMConsoleApp
{
    internal class Class13
    {/*
      * Create a Console Appication or Write a proram to read two numbers and perform
      * sum of operation
      */
        static void Main(string[] args)
        {
            Console.Write("Enter Num1 : ");
            string num1 = Console.ReadLine();
            Console.Write("Enter Num2 : ");
            string num2 = Console.ReadLine();

            Console.WriteLine($"num1 = {num1}\tnum2 =  {num2}");
            Console.WriteLine($"Sum : {num1+num2}");
        }
    }
}

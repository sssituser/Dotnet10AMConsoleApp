using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class HomeWork
    {
        public static void Swap(int num1, int num2)
        {
			Console.WriteLine($"numbers before swapping num1 = {num1}\tnum2 = {num2}");
			int temp = num1;
            num1 = num2;
            num2 = temp;
            Console.WriteLine($"numbers after swapping num1 = {num1}\tnum2 = {num2}");
        }
        static void Main(string[] args)
        {
            Console.Write("Enter  number1  : ");
            int num1 = int.Parse(Console.ReadLine());
			Console.Write("Enter  number2  : ");
			int num2 = int.Parse(Console.ReadLine());
            Swap(num1, num2);

		}
    }
}

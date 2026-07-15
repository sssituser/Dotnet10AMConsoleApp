using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; // lib or .dll file or Assemblies

namespace Methods // Application
{
    internal class Class6 // class
    {
        //1 . Created the Methods
        //2 . Consume the method (Call Method)
        //3 . Sub Mul Div Rem
        public static int AddNumbers(int num1, int num2)
        {
           
            return num1+num2;
        }
        public static int Subtract(int num1,int num2)
        {
            return num1 - num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public static int Division(int num1, int num2)
        {
            return num1 / num2;
        }
        public static int Remainder(int num1, int num2)
        {
            return num1 % num2;
        }
        static void Main(string[] args) // Method
        {
            int res = AddNumbers(5, 2); // calling the method
            Console.WriteLine($"sum of two numbers is : {res}");
            Console.WriteLine($"Addition of two numbers is  : {AddNumbers(4,2)}");

            int sub = Subtract(5, 2);
            int mul = Multiply(5, 2);
            int quo = Division(5, 2);
            int rem = Remainder(5, 2);
            Console.WriteLine($"Sub : {sub}\tMul : {mul}\t Quo : {quo}\tRem : {rem}");
            Console.WriteLine($"Sub : {Subtract(5,2)}\tMul : {Multiply(5,2)}\t Quo : {Division(5,2)}\tRem : {Remainder(5,2)}");


        }
    }
}

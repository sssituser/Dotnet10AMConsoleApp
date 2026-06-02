using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp.Properties
{
    internal class Class3
    {
        static void Main(string[] args)
        {
           
            Console.Write("Enter number 1 : ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter number 2 : ");
            int num2 = int.Parse(Console.ReadLine());

        Menu:
            Console.Write("1.ADD\n2.SUB\n3.MUL\n4.DIV\n5.Rem\nEnter Your choice : ");
            int choice = int.Parse(Console.ReadLine());

            switch(choice){
                case 1:
                    Console.WriteLine($"Sum is : {num1 + num2}");
                    goto Menu;
                case 2:
                    Console.WriteLine($"Sub is : {num1 - num2}");
                    goto Menu;
                case 3:
                    Console.WriteLine($"Mul is : {num1 * num2}");
                    goto Menu;
                case 4:
                    Console.WriteLine($"Quo is : {num1 / num2}");
                    goto Menu;
                case 5:
                    Console.WriteLine($"Rem is : {num1 % num2}");
                    goto Menu;
                default:
                    Console.WriteLine("Invalid choice...");
                    break;
            }




        }
    }
}

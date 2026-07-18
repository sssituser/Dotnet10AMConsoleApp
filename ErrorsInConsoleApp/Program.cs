using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsInConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                   
                    Console.Write("Enter number1 : ");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.Write("Enter number2 : ");
                    int num2 = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Sum : {num1 + num2}");
                    Console.WriteLine($"Sub : {num1 - num2}");
                    Console.WriteLine($"Mul : {num1 * num2}");
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException("You can't Divide Any number with 0...");
                    }
                    Console.WriteLine($"Quo : {num1 / num2}");
                   
                }
                catch (DivideByZeroException dx)
                {
                    Console.WriteLine($"Error : {dx.Message}");
                    Console.WriteLine($"Suggestion : Number 2 Can't be zero");
                }
                catch (FormatException fx)
                {
                    Console.WriteLine($"Error : {fx.Message}");
                    Console.WriteLine("Suggestion : Enter Only Numbers Without decimal values");
                }


                catch (Exception ex ) 
                {
                    Console.WriteLine($"Error occured.... : {ex.Message}");
                }

                finally
                {
                    Console.WriteLine("Thank you visit again");
                }
            }
        }
    }
}

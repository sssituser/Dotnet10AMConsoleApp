using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErrorsInConsoleApp
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter Age : ");
                    int age = int.Parse(Console.ReadLine());
                    if(age<0 || age >= 110)
                    {
                        throw new InvalidAgeException("Age Can't be lessthan zero or not >=110");
                    }
                    Console.WriteLine("Entered Age is Valid");

                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error Message : {ex.Message}");
                }
            }
        }
    }
}

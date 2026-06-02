using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet10AMConsoleApp
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi Iam class-6");
            int age = 23;
            string name = "kiran";
            double salary = 10000.00;
            string dept = "IT";
            Console.WriteLine($"{age}    {name}     {salary}      {dept}");
            Console.WriteLine($"Age : {age}    Name : {name}     Salary : {salary}      Department : {dept}");
        }
    }
}

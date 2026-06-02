using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet10AMConsoleApp
{
    internal class Class12
    {
        /*
         * 
         * Write  a program or Create Console Application which Reads 
         * 1.Name,Age,Gender,Qualification, and Address
         * 2.Display them
         */
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Age : ");
            string age = Console.ReadLine();
            Console.Write("Enter Gender : ");
            string gen = Console.ReadLine();
            Console.Write("Enter Qulificatin : ");
            string qual = Console.ReadLine();
            Console.Write("Enter Address : ");
            string address = Console.ReadLine();
            Console.WriteLine("==============Entered Details Are========");
            Console.WriteLine($"Name : {name}\nAge : {age}\nGender : {gen}\nQualification : {qual}\nAddress : {address}");

        }


    }
}

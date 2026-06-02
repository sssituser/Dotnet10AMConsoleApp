using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet10AMConsoleApp
{
    internal class Class17
    {
        static void Main(string[] args)
        { //Reading Data
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Age : ");
            int age =int.Parse(Console.ReadLine());
            Console.Write("Enter Gender : ");
            string gen = Console.ReadLine();
            Console.Write("Enter Contact Number : ");
            string contact = Console.ReadLine();
            Console.Write("Enter Address : ");
            string addres = Console.ReadLine();
            Console.WriteLine("Entred Details Are");
            // Display the Data

            Console.WriteLine($"\nName : {name}\tAge : {age}\tGender : {gen}\tContact : {contact}\tAddress : {addres}");



            

        }
    }
}

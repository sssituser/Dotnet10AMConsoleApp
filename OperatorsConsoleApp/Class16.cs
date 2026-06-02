using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class16
    {
        /*Write program to to implement if-else
         * Write a program to find a number which is is +ve and single digit?
         */
        static void Main(string[] args)
        {
            Console.Write("Enter UserName : ");
            string uname = Console.ReadLine();
            Console.Write("Enter Password : ");
            string pasword = Console.ReadLine();
            if(uname=="admin" && pasword == "admin")
            {
                Console.WriteLine("Welcome to Admin");
            }
            else
            {
                Console.WriteLine("Invalid UserName or Password");
            }
        }
    }
}

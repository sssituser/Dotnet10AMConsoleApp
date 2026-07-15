using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class10
    {
        public static string Encrypt(string input) // abc;
        {
            input = input.ToLower();
            string res = string.Empty;
            string alpha = "abcdefghijklmnopqrstuvwxyz";
          
            foreach(char ch in input) // ch = a
            {
                res = res + alpha.ElementAt(25-alpha.IndexOf(ch));
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Your Encrypted Name is : {Encrypt(name)}");
        }
    }
}

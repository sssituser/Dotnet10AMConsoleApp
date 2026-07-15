using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class11
    {
        // Write program or create a conosle application which finds namescore
        // example: name = "abc"  score = 1+2+3=> 6

        public static int NameScore(string name) // name ="abc"
        {
            string alphabets = "abcdefghijklmnopqrstuvwxyz";
            int sum = 0;
            foreach(char ch in name) // abc
            {
                sum = sum + alphabets.IndexOf(ch) + 1;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.WriteLine($"Name Score of  : {name} is  {NameScore(name)} ");
        }
    }
}

/*
 * Method Name    : NameScore
 * Parameters     : 1 string parameter
 * return Type    : int
 * Accessmodifier : public static
 */
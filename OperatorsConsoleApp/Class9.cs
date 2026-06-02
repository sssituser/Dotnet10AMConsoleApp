using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");//10
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num%2==0 ? $"{num} is even":$"{num} is odd"); // % -> Rem
                      
        }
    }
}
              
              
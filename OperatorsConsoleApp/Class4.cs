using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsConsoleApp
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            //Relational Operators
            Console.Write("Enter num1 : "); // num1 = 5
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : "); // num2 = 2
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine(num1+num2);

            //Relational Operators or Comparision operators can result boolean values(True or False)
            Console.WriteLine(num1>num2); //5>2 True
            Console.WriteLine(num1<num2); // 5<2 False
            Console.WriteLine(num1>=num2); // 5>=2  True
            Console.WriteLine(num1<=num2); //5<=2  False
            Console.WriteLine(num1==num2); //5==2  False
            Console.WriteLine(num1!=num2); // 5!=2 True

        }
    }
}

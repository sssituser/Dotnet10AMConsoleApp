using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{ /* Create a console application which can reverse the given string.
   * Method Name     : reverse
   * Parameters      : 1 parameter string
   * return Type     : string
   * Access Modifier : public static
   */
    internal class Class12
    {
        // str = "abc"
        public static string Reverse(string input)
        {
            string result =string.Empty;
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result = result + input[i];
            }
            return result;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter string : ");
            string input = Console.ReadLine();
            Console.WriteLine($"Reverse of Given String : {input} is : {Reverse(input)}");
        }
    }
}

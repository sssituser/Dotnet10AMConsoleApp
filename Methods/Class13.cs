using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /*
     * Write  a program to reverse the number
     * input = 123   res = 321
     * Method Name      : ReverseNum
     * Parameters       : 1 Integer
     * Returun Type     : int
     * Access Modifier  : public static
     */
    internal class Class13
    {
        public static int ReverseNum(int num) // num = 123
        {
            int rev = 0;
            while (num > 0) // 123>0 12>0 1>0-T 0>0
            {
                int digit = num % 10;// digit = 123%10 digit = 3 digit = 12%10 digit = 2 digit  = 1%10 digit = 1
                rev = rev * 10 + digit; // rev = 3  rev = 32 rev = 321
                num /= 10; // num = 123/10 num = 12/10 num = 1/10 num = 0
            }
            return rev;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter  a Number : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine($"Reverse of  Given number : {num} is : {ReverseNum(num)}");
        }
    }
}

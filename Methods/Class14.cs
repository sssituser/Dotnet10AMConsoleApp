using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class14
    {   /*
         * Number and Its Reverse Number , if they are equal the given number is Palindrome
         * Method Name      : IsPalindrome
         * Parameters       : 1 Integer
         * Return Types     : boolean
         * Access Modifier  : public static
        */
        public static int ReverseNum(int num)
        {
            int rev = 0;
            while (num != 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
        public static bool IsPalindrome(int num) // 123  // IsArmstrong  IsPrime  IsPerfect IsStrong
        {
            
            return num == ReverseNum(num);

        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(123));
            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(1234));
        }
    }
}

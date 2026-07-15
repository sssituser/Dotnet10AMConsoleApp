using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class16
    {
        /*
         * Write  a program or create and application which can generate List of
         * 1.Palindrome numbers for the given  start and end value.
         *  Example :
         *      start = 100   to 150
         *      Result = 101,111,121,131,141.
         *      start  = 1  end = 10
         *      1,2,3,4,5,6,7,8,9.
         *      Method Name : GenPalinList
         *      Paramters   : 2 Integers
         *      Return Type : string
         *      Access Mod  : public
         *      Alogarithm
         *      1. Take Inputs
         *      2. Arrange them In for loop
         *      3. Check Each number is Palindrome or not
         *      4. If it is Paindrome add to the string with come
         *      5. If it is not Palindrome don't add
         */
        public static int Reverse(int num)
        {
            int rev = 0;
            while (num > 0)
            {
                rev = rev * 10 + num % 10;
                num /= 10;
            }
            return rev;
        }
        public static bool IsPalindrome(int num)
        {
            return num == Reverse(num);
        }
        public static string GenPalinList(int start,int end) // 100 , 150
        {
            string res = string.Empty;
            for(int i =start; i <= end; i++)
            {
                if (IsPalindrome(i))
                {
                    res = res + i + ",";
                }
            }
            return res.Substring(0,res.Length-1)+".";
        }
        static void Main(string[] args)
        {
            Console.Write("Enter Start Value : ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter End Value : ");
            int end = int.Parse(Console.ReadLine());
            Console.WriteLine(GenPalinList(start,end));
        }
    }
}

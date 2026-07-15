using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /*
     * num = 153     1cube + 5 cube+ 3 cube => 153
     * num = 1634    1pow4 + 6pow4+3pow4+4pow4 => 1634
     * steps
     * Take a number
     * count the digits
     * separate the each digit
     * find power value of each digit and sum
     * compare sum with original value 
     * Method Name : IsArmstrong
     * Parameter   : 1 Integer Parameter
     * Return Type : boolean
     * AccessModifier : public staticc
     * 
     * Method Name : DigitCount
     * Paramter    : 1 Integer
     * Return Type : Integer
     * AccessModifer : public static
     * 
     * Method Name : Power
     * Parameter   : 2 Integer Parameter
     * Reurn type  : int
     * AM          :public static
     */
    internal class Class15
    {
        public static int DigitCount(int num) // num = 123
        {
            int count = 0;
            while (num > 0) // 123>0-T 12>0-T 1>0 0>0-F
            {
                int digit = num % 10; // digit = 123%10 digit = 3 digit = 12%10 digit = 2 digit = 1%10 digit = 1
                count++; // count = 1 count = 2 count = 3
                num = num / 10; // num = 123/10 num = 12/10 num = 1 num=1/10 num = 0
            }
            return count;
        }
        public static int Power(int bas,int pow)// bas = 2  pow = 3
        {
            int res = 1;
            for(int i = 1; i <= pow; i++) // i = 1 1<=3-T i = 2 2<=3-T i = 3 3<=3-T i = 4 4<=3-F
            {
                res = bas * res; // res = 2 res = 4 res = 8
            }
            return res;
        }
        public static bool IsArmstrong(int num)
        {
            int count = DigitCount(num);
            int copy = num; // copy = 153
            int sum = 0;
            while (num > 0) // num = 153 num=15>0-T 1>0 0>0-F
            {
                int digit = num % 10; // digit = 153%10 digit = 3 digit = 15/10 digit = 5 digit = 1%10 digit = 1
                sum = sum+Power(digit,count);  // sum = 27 sum = 27+125 sum = 152 sum = 152+1 => sum = 153
                num = num / 10; // num = 153/10 num = 15/10 num = 1/10 num = 0
            }

            return copy == sum;


        }
        static void Main(string[] args)
        {
            Console.WriteLine(IsArmstrong(153)); // True
            Console.WriteLine(IsArmstrong(123)); // False
            Console.WriteLine(IsArmstrong(370)); // True
            Console.WriteLine(IsArmstrong(1234)); // False
            Console.WriteLine(IsArmstrong(1634)); // True
            Console.WriteLine(IsArmstrong(9474)); // True
            
        }
    }
}

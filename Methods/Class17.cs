using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    //Find the Lucky Number for the given date of birth
    // Example "19-Jan-2020"  19+1+2020=>2040=>2+0+4+0=> Your Lucky Number : 6
    //"18-jan-2010" 18+1+2010 =>19+2010=>2029=>    2+0+2+9=>13=>1+3=> 4
    /*
    Method Name : GetLuckyNumber
    Parameter   : 1 string dob 
    Return Type : Integer
    Access M    : public static

    Method Name : ConvertToMonthTextToNum
    Paramter    : 1string
    Return Type : 1 - Integer
    Access Modi : public static
    Method Name : DigitSum
    Parameter   : 1 Integer 
    return typ  : 1 Integer
    AccessModif : public static
     */
    internal class Class17
    {
        public static int DigitSum(int num) // 123=>6
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum = sum + digit;
                num /= 10;
            }
            return sum;
        }
        public static int ConvertToMonthTextToNum(string month) // March
        {
            month = month.ToLower(); // month = march
            string[] months = {"jan","feb","mar","apr","may","jun","jul","aug","sep","oct","nov","dec" };
            for (int i = 0; i < months.Length; i++) // i = 0 ,i = 1,i=2
            {
                if (month.Contains(months[i]))
                {
                    return i + 1;
                }
            }
            return 0;
        }
        public static int GetLuckNumber(string dob) // "17-Feb-2010"
        {
            string[] res = dob.Split('-');
            int date = int.Parse(res[0]); // date = 17
            int month = ConvertToMonthTextToNum(res[1]);
            int year = int.Parse(res[2]);
            int sum = date + month + year;
            while (sum > 9)
            {
                sum = DigitSum(sum);
            }
            return sum;

        }
        static void Main(string[] args)
        {
            string dob = "21-Aug-2003"; // 21+8+2003 =>29+2003=>2032=>7
            string[] res = dob.Split('-');

            Console.WriteLine($"Your Lucky Number : {GetLuckNumber(dob)}");
           
        }
    }
}

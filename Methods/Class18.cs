using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    /*
        Find the MinNumbr from the given array  of elements
        int[] array = {123,654,788,987,432};
                        {3, 6,  8, 9, 4}
                        
                           34689
           Given Array
       GetMaxDigitArray
       SortArrayDesc
       ConvertArrayToNumber

    -------------------------------------
        Method Name : GetMaxNumber
        parameter   : int[] array
        Return Type : int
        Access Modi : public static

        Method Name : GetMaxDigitArray
        Paramter    : int[] array
        Return Type : int[] array
        Access Modi : public static

        Method Name : SortArrayDesc
        Paramter    : int[] array
        Return Type : int[] array
        Access Mo   : public static

        Method Name : ArrayToNum
        Parameter   : int[] array
        Return      : int
        Access Mode : public statici

       Method Name : GetMaxDigit
       Paramter    : 1 Int
       Return      : int
       Access Mod  : public static

     */
    internal class Class18
    {
        public static int GetMaxNumber(int[] array)
        {
          return   ArrayToNum(SortArrayDesc(GetMaxDigitArray(array)));
        }

       public static int[] GetMaxDigitArray(int[] array)
        {
            int[] maxdigitrray = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                maxdigitrray[i] = GetMaxDigit(array[i]);
            }
            return maxdigitrray;
        }
        public static int[] SortArrayDesc(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
        public static int ArrayToNum(int[] array)// {6,4,2}
        {
            int res = 0;
            for(int i = 0; i < array.Length; i++)
            {
                res = res * 10 + array[i]; //res = 642
            }
            return res;
        }
        public static int GetMaxDigit(int num) // num = 321
        {
            int max = num % 10; // max = 321%10 max = 1
            while (num > 0) //321>0 -T 32>0 3>0-T 0>0-F
            {
                int digit = num % 10; // digit = 321%10 digit = 1 digit = 32%10 digit = 2 digit = 3%10 digit = 3
                if (digit > max) // 1>1-F 2>1-T 3>2-T
                {
                    max = digit; // max = 2 max = 3
                }
                num /= 10; // num = 321/10 num = 32/10 num = 3/10 num = 0
            }
            return max;
        }
        static void Main(string[] args)
        {
            int[] array = { 123, 654, 788, 987, 432 };
            Console.WriteLine($"Max Number from the array is {GetMaxNumber(array)}");

        }
    }
}

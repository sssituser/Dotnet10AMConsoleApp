using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class19
    {
        
        public static int GetMinNum(int[] array)
        {
           return  ArrayToNum(SortArrayAsc(GetMinDigitArray(array)));
        }
        public static int[] GetMinDigitArray(int[] array)
        {
            int[] MinDigitArray = new int[array.Length];
            for(int i = 0; i < array.Length; i++)
            {
                MinDigitArray[i] = GetMinDigit(array[i]);
            }
            return MinDigitArray;
        }
        public static int[] SortArrayAsc(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int copy = array[i];
                        array[i] = array[j];
                        array[j] = copy;
                    }
                }
            }
            return array;
        }
        public static int ArrayToNum(int[] array) // {5,7,4}
        {
            int res = 0;
            for(int i = 0; i < array.Length; i++)
            {
                res = res * 10 + array[i];
            }
            return res;
        }
        public static int GetMinDigit(int num)// num = 123
        {
            int min = num % 10;
            while (num > 0)
            {
                int digit = num % 10;
                if (min > digit)
                {
                    min = digit;
                }
                num /= 10;
            }
            return min;
        }
        static void Main(string[] args)
        {
            int[] array = { 123, 654, 788, 987, 432 };
            Console.WriteLine($"Mininum Number is : {GetMinNum(array)}");

        }
    }
}

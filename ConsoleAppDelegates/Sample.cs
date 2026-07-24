using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegates
{
    public delegate int CheckNums(int num);
    
    internal class Sample
    {
       
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

        public int DigitSum(int num)
        {
            int sum = 0;
            for(int i=1;i<=num;i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}

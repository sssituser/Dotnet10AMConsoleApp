using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class8
    {
        // 1 . Method createdd
        public static string GenNums(int start,int end) // 1,5 
        {
            string res = string.Empty;
            for(int i = start; i <= end; i++)
            {
                res = res + i+" ";
            }
            return res;
        }
        static void Main(string[] args)
        {
            // calling the Method
            string s = GenNums(1, 5);
            Console.WriteLine(s);
            Console.WriteLine(GenNums(100,150));
        }
    }
}

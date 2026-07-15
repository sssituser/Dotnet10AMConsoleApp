using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class9
    {
        public static string GenSquares(int start,int end)
        {
            string res = string.Empty;
            for(int i= start; i <= end; i++)
            {
                res = res + (i * i) + ",";
            }
            return res.Substring(0,res.Length-1)+".";
        }
        static void Main(string[] args)
        {
            string s = GenSquares(1, 5);
            Console.WriteLine(s);
            Console.WriteLine(GenSquares(1,10));
        }
    }
}

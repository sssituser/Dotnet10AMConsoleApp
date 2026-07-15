using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            string str1 = "abc";
            string str2 = "aac";
            Console.WriteLine(str1.CompareTo(str2));

            string s1 = "abcdefhigjkl";
            string s2 = "abcdefhigjkm";
            Console.WriteLine(s1.CompareTo(s2));
            Console.WriteLine(s2.CompareTo(s1));
        }
    }
}

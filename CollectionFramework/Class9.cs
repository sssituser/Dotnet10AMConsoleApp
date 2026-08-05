using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class9
    {
        static void Main(string[] args)
        {
            SortedSet<string> set = new SortedSet<string>();
            set.Add("kalyani");
            set.Add("maruthi");
            set.Add("fayaz");
            set.Add("arun");
            Console.WriteLine("=========================Names in the Set Are=======");
            foreach(string s in set)
            {
                Console.WriteLine(s);
            }
            var res = set .OrderByDescending(x => x);
            Console.WriteLine("=============Elements in the Descending order=========");
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }
    }
}

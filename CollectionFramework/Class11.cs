using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class11
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(111, "Kalyani");
            dict.Add(112, "Maruthi");
            dict.Add(110, "Fayaz");
            dict.Add(113, "Raj");
            //dict.Add(111, "Ravi"); Duplicate keys can't be added

            Console.WriteLine("=======================Keys in the dictornary=================");
            foreach(int k in dict.Keys)
            {
                Console.WriteLine(k);
            }
            Console.WriteLine("=======================Values in the dictornary=================");
            foreach (string v in dict.Values)
            {
                Console.WriteLine(v);
            }

            Console.WriteLine("Displaying key and values pairs");
            foreach(KeyValuePair<int,string> kvp in dict)
            {
                Console.WriteLine(kvp);
            }

            Console.WriteLine("Displaying key values pairs by using keys");
            foreach(int k in dict.Keys)
            {
                Console.WriteLine($"{k}   {dict[k]}");
            }


        }
    }
}

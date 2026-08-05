using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class8
    {
        static void Main(string[] args)
        {
            SortedSet<int> set = new SortedSet<int>();
            set.Add(4);
            set.Add(2);
            set.Add(3);
            set.Add(1);

            Console.WriteLine("Elements in the set are");
            foreach(int i in set)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"No Elements in the Set are : {set.Count}");
            Console.WriteLine($"No Elements in the Set are : {set.Count()}");

            //Console.WriteLine($"{set.Contains(3)}");
            //Console.WriteLine($"{set.Contains(5)}");
            //Console.WriteLine($"{set.ElementAt(0)}");
            //Console.WriteLine($"{set.ElementAt(3)}");
            //Console.WriteLine($"{set.Remove(4)}");
            //Console.WriteLine($"{set.Remove(5)}");
            //Console.WriteLine($"{set.Remove(2)}");
            //set.Clear();
            Console.WriteLine("Elements in the set are");
            foreach (int i in set)
            {
                Console.WriteLine(i);
            }
        }
    }
}

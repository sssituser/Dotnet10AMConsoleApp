using System;
using System.Collections;


namespace CollectionFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(100);
            list.Add(7.8);
            list.Add(true);
            list.Add("abc");
            list.Add(100);
            list.Add(null);
            Console.WriteLine("Elements in the Arraylist are");
            foreach(var k in list)
            {
                Console.WriteLine(k);
            }
            list.Remove(100);
            list.Remove(true);

            Console.WriteLine("Elements in the Array list are");
            foreach (var k in list)
            {
                Console.WriteLine(k);
            }
        }
    }
}

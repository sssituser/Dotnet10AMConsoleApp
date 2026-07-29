using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            list.Add(10);
            list.Add(8);
            list.Add(6);
            list.Add(9);
            list.Add(7);

            Console.WriteLine(list[0]);

            Console.WriteLine("Displayig elements using foreach");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Sort();
            Console.WriteLine("Displayig elements after sorting using foreach");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            list.Reverse();
            Console.WriteLine("Displayig elements after sorting using foreach");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(list.Remove(10));
            Console.WriteLine(list.Remove(8));
            Console.WriteLine(list.Remove(9));
            Console.WriteLine("Displayig elements after sorting using foreach");
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}

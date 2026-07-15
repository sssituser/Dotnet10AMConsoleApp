using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            string[] names = { "Maruthi", "Faiaz", "Kalyani", "Afreen", "Priya" };
            Console.WriteLine("Diaplaying the elments using for loop");
            for (int index = 0; index < names.Length; index++)
            {
                Console.WriteLine(names[index]);
            }

            string[] ascnames = names.OrderBy(name => name).ToArray();// Linq Query

            Console.WriteLine("=========Names In Ascending Order============");

            foreach(string name in ascnames)
            {
                Console.WriteLine(name);
            }

            string[] descnames = names.OrderByDescending(name => name).ToArray();

            Console.WriteLine("=========Names In Descending Order============");
            for(int index = 0; index < descnames.Length; index++)
            {
                Console.WriteLine(descnames[index]);
            }


        }
    }
}

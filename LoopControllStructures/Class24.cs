using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class24
    {
        static void Main(string[] args)
        {
            string name = "Arunkumar";
            Console.WriteLine($"Name : {name}");
            Console.WriteLine("Dispalying the Individual characters of given string");

            foreach(char element in name)
            {

                Console.WriteLine(element);
            }
        }
    }
}

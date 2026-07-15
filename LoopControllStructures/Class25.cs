using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class25
    {
        static void Main(string[] args)
        {
            string[] names = new string[5]; // Declaration of the array or Instanciation of the array
            names[0] = "Maruthi"; // Initlization 
            names[1] = "Faiaz";
            names[2] = "Kalyani";
            names[3] = "Priya";
            names[4] = "Arun";

            Console.WriteLine("========Displaying values Directly==========");
            //1 - Way Direct Variables
            Console.WriteLine(names[0]);
            Console.WriteLine(names[1]);
            Console.WriteLine(names[2]);
            Console.WriteLine(names[3]);
            Console.WriteLine(names[4]);
            Console.WriteLine("========Displaying values using for loop========");

            for (int i = 0; i < names.Length; i++) // i = 0;0<5-T  1<5-T  2<5-T 3<5  4<5 5<5
            {
                Console.WriteLine(names[i]); // Maruthi  Faiaz kalyani Priya Arun
            }

            Console.WriteLine("========Displaying values using for each loop========");

            foreach(string s in names)
            {
                Console.WriteLine(s);
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopControllStructures
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 10;


            do
            {
                Console.WriteLine($"{start}.WELCOME TO DOTNET TRINING");//5.WELCOME TO DOTNET 
                start++;// start = 2 start = 3 start = 4 start = 5 start = 6
            } while (start <= end);//1<5->T 2<5-T 3<5-T 4<5-T 5<=5-T 6<=5-F



        }
    }
}

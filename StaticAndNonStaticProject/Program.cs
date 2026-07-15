using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("========================Person1=============");
            Home person1= new Home();
            person1.Spent(2000);
            Console.WriteLine("========================Person2=============");
            Home person2= new Home();
            person2.Spent(1000);
            Console.WriteLine("========================Person3=============");
            Home person3 = new Home();
            person3.BalChec();

        }
    }
}

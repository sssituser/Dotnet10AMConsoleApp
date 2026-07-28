using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Customers
    {
        private int age;

        public int Age
        {
            get {
                
                return age;
            
            }


            set {


                if (value >= 18)
                    age = value;
                else
                    Console.WriteLine("Age must be >17");
            
            
            }
        }

    }
    internal class Class8
    {
        static void Main(string[] args)
        {

            Customers cu = new Customers();
            cu.Age = 18;
            Console.WriteLine($"Age is :{cu.Age}");
            Customers cu1 = new Customers();
            cu1.Age = 16;
            Console.WriteLine(cu1.Age);
           
        }
    }
}

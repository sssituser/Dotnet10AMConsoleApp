using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Employee
    {
        
        static Employee()
        {
            Console.WriteLine("Iam Static Constructor");
        }
       
        public Employee()
        {
            Console.WriteLine("Hi Iam Default Constructor");
        }
    }
}

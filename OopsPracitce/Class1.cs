using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracitce
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==============================Employee Object-1========");
            Employee emp1 = new Employee();
            emp1.SetEmployee(111, "kiran", 60000);
            emp1.GetEmployee();
            Console.WriteLine("==============================Employee Object-2========");
            Employee emp2 = new Employee();
            emp2.SetEmployee(112, "Raj", 50000);
            emp2.GetEmployee();
        }
    }
}

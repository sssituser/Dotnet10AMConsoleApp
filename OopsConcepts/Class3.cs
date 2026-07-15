using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Employeee
    {
        public int EmpId;
        public string EmpName;
        public int EmpSalary;
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====================Empolyeee - 1 Object ========================");
            Employeee emp1 = new Employeee();
            emp1.EmpId = 111;
            emp1.EmpName = "RAj";
            emp1.EmpSalary = 50000;
            Console.WriteLine(emp1.EmpId);
            Console.WriteLine(emp1.EmpName);
            Console.WriteLine(emp1.EmpSalary);
            Console.WriteLine("=========================Employeee - 2 Object===================");
            Employeee emp2 = new Employeee();
            emp2.EmpId = 4444;
            emp2.EmpName = "Ravi";
            emp2.EmpSalary = 40000;
            Console.WriteLine(emp2.EmpId);
            Console.WriteLine(emp2.EmpName);
            Console.WriteLine(emp2.EmpSalary);



        }
    }
}

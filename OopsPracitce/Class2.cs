using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracitce
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===============Student-1 Object");
            Student s1 = new Student();
            s1.SetStudent(123, "Raj", 5000);
            s1.GetStudent();
            Console.WriteLine("===============Student-2 Object");
            Student s2 = new Student();
            s2.SetStudent(345,"kalyani",6000);
            s2.GetStudent();
        }
    }
}

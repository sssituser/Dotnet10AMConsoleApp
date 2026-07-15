using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    // static members can be called using classname
    //
    internal class Class2
    {
        static void Main(string[] args)
        {
            Student.SetCollegeInfo("Arun","Narayana Jr College","KPHB","RRDIST");
            Student.ShowCollegeInfo();

            Student s1 = new Student();
            s1.SetStudent(111, "Priaya", 500);
            Student s2 = new Student();
            s2.SetStudent(112,"Kalyani",500);
            Student s3 = new Student();
            s3.SetStudent(113,"Maruthi",500);
            Student s4 = new Student();
            s4.SetStudent(114, "Fayaz", 450);
            Console.WriteLine("=====Student-1 Object==============");
            s1.GetStudent();
            Console.WriteLine("=====Student-2 Object==============");
            s2.GetStudent();
            Console.WriteLine("=====Student-3 Object==============");
            s3.GetStudent();
            Console.WriteLine("=====Student-4 Object==============");
            s4.GetStudent();





        }
    }
}

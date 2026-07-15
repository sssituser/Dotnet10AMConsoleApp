using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            Students s1 = new Students();
            Students s2 = new Students(112,"kiran",22);
            Students s3 = new Students(113,"Raj",34);
            Students s4 = new Students(114,"Ram",55);
            Console.WriteLine("============Stdudent-1 Object=======================");
            s1.ShowStudent();
            Console.WriteLine("============Stdudent-2 Object=======================");
            s2.ShowStudent();
            Console.WriteLine("============Stdudent-3 Object=======================");
            s3.ShowStudent();
            Console.WriteLine("============Stdudent-4 Object=======================");
            s4.ShowStudent();

        }
    }
}

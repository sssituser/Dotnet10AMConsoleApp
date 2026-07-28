using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Student
    {
        public int StudentId {private get; set; }
        public string StudentName {private get; set; }

        public int StudentMarks {private get; set; }


    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.StudentId = 111;// write only property
            student1.StudentName = "kiran";
            student1.StudentMarks = 100;

           



        }
    }
}

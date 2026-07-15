using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Students
    {
        int StudentId;
        string StudentName;
        int StudentAge;
        public Students()
        {
            Console.WriteLine("Hi Iam Default Constructor");
            StudentId = 111;
            StudentName = "ABCD";
            StudentAge = 21;
        }
        public Students(int StudentId, string StudentName, int StudentAge)
        {
            Console.WriteLine("Constructor with Parameter");
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.StudentAge = StudentAge;
        }
        public void ShowStudent()
        {
            Console.WriteLine($"Student ID : {StudentId}");
            Console.WriteLine($"Student Name : {StudentName}");
            Console.WriteLine($"Student Age : {StudentAge}");
        }
    }
}

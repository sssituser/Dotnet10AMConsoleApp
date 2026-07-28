using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Students
    {
        public static string CollegeName { get; private set; } = "ABC College";
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int StudentMarks { get; set; }
    }
    internal class Class6
    {
        static void Main(string[] args)
        {
            Students s1 = new Students();
            s1.StudentId = 111;
            s1.StudentName = "kiran";
            s1.StudentMarks = 500;

            Console.WriteLine($"ID : {s1.StudentId}\nName : {s1.StudentName}\nMarks : {s1.StudentMarks}\nCollege : {Students.CollegeName}");




        }
    }
}

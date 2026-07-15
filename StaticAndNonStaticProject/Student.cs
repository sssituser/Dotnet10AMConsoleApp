using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Student
    {
        static string Principal;
        static string CollegeName;
        static string Address;
        static string City;

        int StudentId;
        string StudentName;
        int Marks;

        public static void SetCollegeInfo(string Principal, string CollegeName, string Address, string City)
        {
           
                Student.Principal = Principal;
                Student.CollegeName = CollegeName;
                Student.Address = Address;
                Student.City = City;
        }
        public static void ShowCollegeInfo()
        {
            Console.WriteLine($"Princiapal Name : {Principal}");
            Console.WriteLine($"College Name    : {CollegeName}");
            Console.WriteLine($"College Address : {Address}");
            Console.WriteLine($"City            : {City}");
        }
        public void SetStudent(int StudentId, string StudentName, int Marks)
        {
            
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.Marks = Marks;
        }
        public void GetStudent()
        {
            Console.WriteLine($"Student ID :{StudentId}");
            Console.WriteLine($"Student Name :{StudentName}");
            Console.WriteLine($"Student Marks :{Marks}");
        }
    }
}

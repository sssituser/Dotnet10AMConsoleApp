using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracitce
{
    internal class Student
    {
        private int StudentId;
        private string StudentName;
        private int StudentMarks;
        public void SetStudent(int StudentId,string StudentName,int StudentMarks)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
            this.StudentMarks = StudentMarks;
        }
        public void GetStudent()
        {
            Console.WriteLine($"Student Id : {StudentId}");
            Console.WriteLine($"Student Name : {StudentName}");
            Console.WriteLine($"Student Marks : {StudentMarks}");
        }
    }
}

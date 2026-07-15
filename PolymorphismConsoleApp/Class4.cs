using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    
    class Student  
    {
        int StudentId;
        string StudentName;
        public void SetStudent(int StudentId, string StudentName)
        {
            this.StudentId = StudentId;
            this.StudentName = StudentName;
        }
      

        public override string ToString()
        {
            return $"Student ID : {StudentId}\tStudent Name : {StudentName}.....###";
        }
    }
    internal class Class4
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.SetStudent(111, "abc");
            Console.WriteLine(s);

        }
    }
}

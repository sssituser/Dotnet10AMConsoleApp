using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    internal class Student
    {
        int StuId;
        string StuName;
        string Course;
        public Student(int StuId,string StuName,string Course)
        {
            this.StuId = StuId;
            this.StuName = StuName;
            this.Course = Course;
        }
        public override string ToString()
        {
            return $"StudentId : {StuId}\tStudent Name : {StuName}\tCourse : {Course}";
        }
    }
}

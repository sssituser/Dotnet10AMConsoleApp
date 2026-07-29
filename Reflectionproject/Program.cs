using System;
using System.Reflection;

namespace Reflectionproject
{
    class Student
    {
        private int studentId;

        private string studentName;

        private int marks;

        public Student()
        {
            
        }
        public Student(int studentId,string studentName,int marks)
        {
            this.studentId = studentId;
            this.studentName = studentName;
            this.marks = marks;

        }

        public int Marks
        {
            get { return marks; }
            set { marks = value; }
        }

        public string StudentName
        {
            get { return studentName; }
            set { studentName = value; }
        }

        public int StudentId
        {
            get { return studentId; }
            set { studentId = value; }
        }

        public void GetStudentInfo()
        {
            Console.WriteLine($"Student Id : {studentId}\tStudentNamae :{studentName}\tMarks : {marks}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Type type = typeof(Student);

            Console.WriteLine($"NameSpace Name : {type.Namespace}  ClassName : {type.Name}");
            Console.WriteLine($"FullName : {type.FullName}");
            Console.WriteLine("Constructors information");
            foreach(var t in type.GetConstructors())
            {
                Console.WriteLine(t.Name);
            }
            Console.WriteLine("Methods Inside the class");
            foreach(var t in type.GetMethods())
            {
                Console.WriteLine($"{t.Name}\t\t\t{t.ReturnType}");
            }
            Console.WriteLine("Properties Inside the class");
            foreach (PropertyInfo t in type.GetProperties())
            {
                Console.WriteLine($"{t.Name}\t\t\t{t.MemberType}");
            }

            Console.WriteLine("Properties Inside the class");
            foreach (var t in type.GetRuntimeFields())
            {
                Console.WriteLine($"{t.Name}\t\t{t.MemberType}");
            }
            
            Object obj = Activator.CreateInstance(type);
            

            MethodInfo method = type.GetMethod("GetStudentInfo");
            method.Invoke(obj, null);
            
            


        }
    }
}

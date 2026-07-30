using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class4
    {
        
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            studentList.Add(new Student() { StudentId = 111, StudentName = "Maruthi", Marks = 500 });
            studentList.Add(new Student() { StudentId = 110, StudentName = "Kalyani", Marks = 550 });
            studentList.Add(new Student() { StudentId = 112, StudentName = "Fayaz", Marks = 560 });
            studentList.Add(new Student() { StudentId = 114, StudentName = "Ravi", Marks = 455 });
            studentList.Add(new Student() { StudentId = 113, StudentName = "Ramesh", Marks = 555 });
            studentList.Add(new Student() { StudentId = 115, StudentName = "vijay", Marks = 655 });
            Console.WriteLine("=========================Displaying the Students using for loop=============");
            for (int index = 0; index < studentList.Count; index++)
            {
                Console.WriteLine(studentList[index]);
            }
            Console.WriteLine("=========================Displaying the Students using foreach loop=============");
            foreach(Student stu in studentList)
            {
                Console.WriteLine(stu);
            }
            Console.WriteLine("=========================Displaying the Students using foreach loop using var=============");
            foreach(var stu in studentList)
            {
                Console.WriteLine(stu);
            }
            Console.WriteLine("=========================Displaying the Students using AdvancedForEach loop=============");
            studentList.ForEach(stu => Console.WriteLine(stu));

        }
    }
}

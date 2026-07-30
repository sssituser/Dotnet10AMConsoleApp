using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class6
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
            studentList.Sort(new Student());
            Console.WriteLine("=========================Displaying the Students using for loop after sorting=============");
            for (int index = 0; index < studentList.Count; index++)
            {
                Console.WriteLine(studentList[index]);
            }








        }
    }
}

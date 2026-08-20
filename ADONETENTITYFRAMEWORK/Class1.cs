using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETENTITYFRAMEWORK
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.Write("1.Add\n2.Delete\n3.Update\n4.Find\n5.Find All\nEnter Your choice : ");
            int choice = int.Parse(Console.ReadLine());
            Table_Student student = new Table_Student();
            BusinesLogic bl = new BusinesLogic();
            switch(choice)
            {
                case 1:
                    Console.Write("Enter Student ID : ");
                    student.StudentId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Student Name : ");
                    student.StudentName = Console.ReadLine();
                    Console.Write("Enter Student Marks : ");
                    student.StuddentMarks=int.Parse(Console.ReadLine());
                    if (bl.AddStudent(student))
                    {
                        Console.WriteLine("Student added");
                    }
                    else
                    {
                        Console.WriteLine("Student Not Added");
                    }
                    break;
            }
        }
    }
}

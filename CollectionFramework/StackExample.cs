using System;
using System.Collections;
namespace CollectionFramework
{
    internal class StackExample
    {
        static void Main(string[] args)
        { 
            Stack st = new Stack();
            st.Push(10);
            st.Push(56.8);
            st.Push("abc");
            st.Push(new Employee() { EmployeeId = 10, EmployeeName = "abc", EmployeeSal = 5000 });
            st.Push(new Student() { StudentId = 10, StudentName = "kiran", Marks = 500 });
            st.Push(10);
            st.Push(null);
            Console.WriteLine("=============Elements in the Stack====================");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Deleted element is :{st.Pop()}");
            Console.WriteLine($"Deleted element is :{st.Pop()}");

            Console.WriteLine("After deleting the elements in the stack are");
            foreach (var item in st)
            {
                Console.WriteLine(item);
            }
        }
    }
}

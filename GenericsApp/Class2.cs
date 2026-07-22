using System;

namespace GenericsApp
{
    class AdvancedGeneric<T,S>
    {
        public static void Show(T x,S y)
        {
            Console.WriteLine($"x = {x}");
            Console.WriteLine($"y = {y}");
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            AdvancedGeneric<int,double>.Show(45,6.7);
            AdvancedGeneric<string,int>.Show("kiran",100);
            AdvancedGeneric<Student, Employee>.Show(new Student(111,"kiran","B.Tech E"),new Employee(111,"Raj",50000));
        }
    }
}

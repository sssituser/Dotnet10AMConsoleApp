using System;
namespace GenericsApp
{
    class GenericExample<T>
    {
       public static void Show(T x, T y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericExample<int>.Show(1,2);
            GenericExample<double>.Show(1.4,2.5);
            GenericExample<string>.Show("abc", "def");
            Employee emp1 = new Employee(111,"abc",50000);
            Employee emp2 = new Employee(112,"def",60000);
            GenericExample<Employee>.Show(emp1,emp2);
            GenericExample<Employee>.Show(new Employee(113,"kiran",4000) ,new Employee(114,"Raj",5000));
        }
    }
}

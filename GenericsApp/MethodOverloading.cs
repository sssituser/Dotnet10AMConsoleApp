using System;
namespace GenericsApp
{
    class Test
    {
        public static void Show(int x, int y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
        public static void Show(double x, double y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
        public static void Show(string x, string y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
        public static void Show(Employee x, Employee y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
    }
    internal class MethodOverloading
    {
        static void Main(string[] args)
        {
            Test.Show(1, 2);
            Test.Show(1.4, 2.5);
            Test.Show("abc", "def");
            Employee emp1 = new Employee(111, "abc", 50000);
            Employee emp2 = new Employee(112, "def", 60000);
            Test.Show(emp1, emp2);
            Test.Show(new Employee(113, "kiran", 4000), new Employee(114, "Raj", 5000));


        }
    }
}

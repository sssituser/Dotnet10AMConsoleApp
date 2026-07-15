using System;
namespace Inheritance
{
    class A
    {
        protected int a = 5,b = 2;
    }
    class B : A
    {
        public void Sum()
        {
            Console.WriteLine($"Sum of a and b is : {a+b}");
        }
        public void Sub()
        {
            Console.WriteLine($"Sub of a and b is : {a-b}");
        }
    }
    class C : B
    {
        public void Mul()
        {
            Console.WriteLine($"Mul of a and b is : {a*b}");
        }
        public void Div()
        {
            Console.WriteLine($"Quo of a and b is : {a/b}");
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            C p=new C();
            p.Sum();
            p.Sub();
            p.Mul();
            p.Div();
        }
    }
}

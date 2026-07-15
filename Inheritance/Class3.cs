using System;
namespace Inheritance
{
    class AA
    {
      protected  int a, b;
        public void Readab()
        {
            Console.Write("Enter a value ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value ");
            b = int.Parse(Console.ReadLine());

        }
    }
    interface BB
    {
        void Sum(); // undefined methods or abstract methods
        void Sub();
    }
    interface CC
    {
        void Mul();
        void Div();
    }
    class DD : AA,BB,CC
    {
        public void Showab()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
        public void Sum()
        {
            Console.WriteLine($"Sum of a and b is :{a+b}");
        }
        public void Sub()
        {
            Console.WriteLine($"Sub of a and b is :{a - b}");
        }
        public void Mul()
        {
            Console.WriteLine($"Mul of a and b is : {a*b}");
        }
        public void Div()
        {
            Console.WriteLine($"Quo of a and b is : {a / b}");
        }

    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            DD p = new DD();
            p.Readab(); // class AA
            p.Showab(); //  class DD
            p.Sum(); // Interface BB
            p.Sub(); // Interface BB
            p.Mul(); // Interface CC
            p.Div(); // Interface CC
        }
    }
}

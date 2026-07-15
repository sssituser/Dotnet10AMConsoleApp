using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    class Sample
    {
        int a ,b ;
        public void Readab()
        {
            Console.Write("Enter a value : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            b = int.Parse(Console.ReadLine());
        }
        public void Showab()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
        public static Sample operator+(Sample FirstObject,Sample SecondObject)
        {
            Sample res = new Sample();
            res.a = FirstObject.a + SecondObject.a;
            res.b = FirstObject.b + SecondObject.b;
            return res;
        }
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================s1 object===================");
            Sample s1 = new Sample();
            s1.Readab();
            s1.Showab(); // a = 1   b = 2
            Console.WriteLine("======================s2 object===================");
            Sample s2 = new Sample();
            s2.Readab();
            s2.Showab(); // a = 4   b = 6
            Console.WriteLine("======================s3 object===================");
            Sample s3 = new Sample();
            s3 = s1 + s2;
            s3.Showab(); // a = 5   b = 8
        }
    }
}

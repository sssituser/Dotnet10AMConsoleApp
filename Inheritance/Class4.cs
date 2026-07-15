using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    interface IC
    {
       void Show();
        void Sum();
    }
    class Result:IC
    {
        int a, b;
        public void Read()
        {
            Console.Write("Enter a value : ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b value : ");
            int b = int.Parse(Console.ReadLine());
        }
        public void Show()
        {
            Console.WriteLine($"a = {a}\tb = {b}");
        }
        public void Sum()
        {
            Console.WriteLine($"Sum of a and b is : {a+b}");
        }

    }
    internal class Class4
    {
        static void Main(string[] args)
        {
           
            Result r = new Result();
            r.Read();
            r.Show();
            r.Sum();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAbstractProject
{
    abstract class AbsClass
    {
       protected int num1;
       protected int num2;
        public void ReadNumbers()
        {
            Console.Write("Enter num1 : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter num2 : ");
            num2 = int.Parse(Console.ReadLine());
        }
        public void ShowNumbers() // non abstract methods
        {
            Console.WriteLine($"num1 : {num1}\t num2 : {num2}");
        }
        public abstract void Sum(); // abstract methods
        public abstract void Sub();
        public abstract void Mul();
    }
    class Test : AbsClass
    {
        public override void Mul()
        {
            Console.WriteLine($"Mul : {num1*num2}");
        }

        public override void Sub()
        {
            Console.WriteLine($"Sub : {num1-num2}");
        }

        public override void Sum()
        {
            Console.WriteLine($"Sum : {num1+num2}");
        }
        public void Quo()
        {
            Console.WriteLine($"Quo :{num1/num2}");
        }
        
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            // AbsClass a = new AbsClass(); Error Can't create Object(Instace)  for Abstract class
            Test t = new Test();
            t.ReadNumbers();
            t.ShowNumbers();
            t.Sum();
            t.Sub();
            t.Mul();
            t.Quo();
        }
    }
}

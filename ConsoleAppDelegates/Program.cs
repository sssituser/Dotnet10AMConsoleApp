using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegates
{
    public delegate void Delegate(int fnum, int snum);

    public class Program
    {
        
       public Delegate d1 = new Delegate(Test.Sum);
       public Delegate d2 = new Delegate(Test.Sub);
       public Delegate d3 = new Delegate(new Test().Mul);
       public Delegate d4 = new Delegate(new Test().Div);
       public CheckNums Rev = new CheckNums(Sample.Reverse);
       public CheckNums Dts = new CheckNums(new Sample().DigitSum);

        static void Main(string[] args)
        {
            Program p = new Program();
            Delegate d5 = p.d1 + p.d2 + p.d3 + p.d4;


            d5(5, 2);
          
           
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    internal class GenricEx2<T>
    {
        public void Display(T x,T y)
        {
            Console.WriteLine($"x = {x}\ty = {y}");
        }
    }
}

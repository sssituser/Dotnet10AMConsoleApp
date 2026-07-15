using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Productts
    {
        public int ProductId;
        public string ProductName;
        public int ProductPrice;
    }
    internal class Class2
    {
        static void Main(string[] args)
        {
            Productts p1 = new Productts();
            p1.ProductId = 111;    // Initialization
            p1.ProductName = "abc";
            p1.ProductPrice = 500;

            // Displaying the values
            Console.WriteLine(p1.ProductId);
            Console.WriteLine(p1.ProductName);
            Console.WriteLine(p1.ProductPrice);
            
        }
    }
}

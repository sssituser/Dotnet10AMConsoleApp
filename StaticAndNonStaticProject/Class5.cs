using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====================p1 Object===========");
            Product p1 = new Product();
            p1.GetProduct();
           
            Console.WriteLine("====================p2 Object===========");
            Product p2 = new Product(235);
            p2.GetProduct();

            Console.WriteLine("====================p3 Object===========");
            Product p3 = new Product(236, "Dove");
            p3.GetProduct();

            Console.WriteLine("====================p4 Object===========");
            Product p4 = new Product(234, "Lux", 70);
            p4.GetProduct();

        }
    }
}

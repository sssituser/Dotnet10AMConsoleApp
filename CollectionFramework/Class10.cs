using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            SortedSet<Product> products = new SortedSet<Product>();
            products.Add(new Product() { ProdId=111,ProdName="def",ProdPrice=500});
            products.Add(new Product() { ProdId=112,ProdName="jkl",ProdPrice=550});
            products.Add(new Product() { ProdId=110,ProdName="abc",ProdPrice=570});
            products.Add(new Product() { ProdId=111,ProdName="ghi",ProdPrice=600});
            products.Add(new Product() { ProdId=113,ProdName="mno",ProdPrice=800});

            Console.WriteLine("==============Products in the Set are==========");
            foreach (Product product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}

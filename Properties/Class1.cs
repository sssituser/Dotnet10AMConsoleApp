using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Product
    {
        int productId;
        string productName;
        int productPrice;
        public int ProductId
        {
            
            set
            {
                productId = value;
            }
        }
        public string ProductName  // Write Only
        {

            set
            {
                productName = value;
            }
        }

        public int ProductPrice
        {

            set
            {
                productPrice = value;
            }
        }
    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.ProductId = 1;
            p1.ProductName = "abc";
            p1.ProductPrice = 100; // Write Only Property


       
        }
    }
}

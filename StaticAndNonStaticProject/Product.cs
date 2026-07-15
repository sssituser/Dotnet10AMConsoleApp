using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Product
    {
        int ProductId;
        string ProductName;
        int ProductPrice;
        public Product() {
            Console.WriteLine("===Default Constructor=====");
        }
        public Product(int ProductId, string ProductName,int ProductPrice)
        {
            Console.WriteLine("==========Parameterised Constrctor==========");
            this.ProductId = ProductId;
            this.ProductName = ProductName;
            this.ProductPrice = ProductPrice;
        }
        public Product(int ProductId)
        {
            Console.WriteLine("==========Parameterised Constrctor with  ID==========");
            this.ProductId = ProductId;
            
        }
        public Product(int ProductId, string ProductName)
        {
            Console.WriteLine("==========Parameterised Constrctor ID and Name==========");
            this.ProductId = ProductId;
            this.ProductName = ProductName;
           
        }
        public void GetProduct()
        {
            Console.WriteLine($"Product ID : {ProductId}");
            Console.WriteLine($"Product Name : {ProductName}");
            Console.WriteLine($"Product Price : {ProductPrice}");
        }

        ~Product()
        {
            Console.WriteLine("Hi Iam Destructor.......");
            Console.ReadLine();
            Console.ReadLine();
        }


    }
}

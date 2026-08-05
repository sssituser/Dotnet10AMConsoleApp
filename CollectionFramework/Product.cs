using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Product : IComparable<Product>
    {
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public int ProdPrice { get; set; }
        //=================Namewise Sroting===========
        public int CompareTo(Product other)
        {
            return this.ProdName.CompareTo(other.ProdName);
        }

        //===================Price Sorting
        //public int CompareTo(Product other)
        //{
        //    if (this.ProdPrice < other.ProdPrice)
        //    {
        //        return -1;
        //    }
        //    if(this.ProdPrice > other.ProdPrice)
        //    {
        //        return 1;
        //    }
        //    return 0;
        //}
        //============================
        // ID Sorting
        //==============================
        //public int CompareTo(Product other)
        //{
        //    if (this.ProdId < other.ProdId)
        //    {
        //        return -1;
        //    }
        //    if (this.ProdId > other.ProdId)
        //    {
        //        return 1;
        //    }
        //    return 0;
        //}

        public override string ToString() // Runtime Polymorphism
        {
            return $"Product Id : {ProdId}\tProduct Name : {ProdName}\tProduct Price : {ProdPrice}";
        }
    }
}

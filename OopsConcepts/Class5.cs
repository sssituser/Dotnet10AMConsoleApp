using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Customer
    {
        //1.Non Static or Intance Private Global Data
        private int CustomerId;
        private string  CustomerName;
        private string CustomerEmail;
        private string CustomerPhone;
        
        public void SetCustomer(int CustomerId, string CustomerName, string CustomerEmail, string CustomerPhone)
        {   // this.CustomerId is Global data
            // CustomerId --> local data
            this.CustomerId = CustomerId;
            this.CustomerName = CustomerName;
            this.CustomerEmail = CustomerEmail;
            this.CustomerPhone = CustomerPhone;
        }
        public void GetCustomer()
        {
            Console.WriteLine("=======Customer Infomration is==============");
            Console.WriteLine($"Customer Id : {CustomerId}");
            Console.WriteLine($"Customer Name : {CustomerName}");
            Console.WriteLine($"Customer Email : {CustomerEmail}");
            Console.WriteLine($"Customer Phome : {CustomerPhone}");

        }

    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=====Customer Object-1================");
            Customer customer1= new Customer();
            customer1.SetCustomer(111, "abc", "abc@gmail.com", "999999999");
            customer1.GetCustomer();
            Console.WriteLine("=====Customer Object-2================");
            Customer customer2 = new Customer();
            customer2.SetCustomer(112, "def", "def@gmail.com", "8888888888");
            customer2.GetCustomer();
        }
    }
}

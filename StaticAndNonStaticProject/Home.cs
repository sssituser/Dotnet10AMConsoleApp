using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Home
    {
       static int TotalAmount = 10000;
        public void Spent(int amount)
        {
            Console.WriteLine($"Total Amount is : {TotalAmount}");
            Console.WriteLine($"Amount Spent is : {amount}");
           
            TotalAmount = TotalAmount - amount;
            Console.WriteLine($"Balance Total Amount :{TotalAmount}");

        }
        public void BalChec()
        {
            Console.WriteLine($"Total Amount is : {TotalAmount}");
        }
    }
}

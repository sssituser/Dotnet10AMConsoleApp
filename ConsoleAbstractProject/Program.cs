using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAbstractProject
{
    interface ILoan
    {
        void RateOfInterest(); // 
    }
    class GoldLoan : ILoan
    {
        public void RateOfInterest()
        {

            Console.WriteLine("Rate of Interset of Gold Loan : 12%");
        }
    }

    class HomeLoan : ILoan
    {
        public void RateOfInterest()
        {
            Console.WriteLine("Rate of Intereset Home Loan: 18%");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            GoldLoan gl = new GoldLoan();
            gl.RateOfInterest();
            HomeLoan hl =new HomeLoan();
            hl.RateOfInterest();
        }
    }
}

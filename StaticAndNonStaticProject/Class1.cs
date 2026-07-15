using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============Player - Rohit====================");
            Cricket Rohit = new Cricket();
            Rohit.ShowPeronalScore(0);
            Rohit.ShowTotalScore();
            Rohit.ShowPeronalScore(30);
            Rohit.ShowTotalScore();
            Console.WriteLine("============Player - virat====================");
            Cricket virat = new Cricket();
            virat.ShowPeronalScore(0);
            Rohit.ShowTotalScore();
            virat.ShowPeronalScore(50);
            Rohit.ShowTotalScore();
        }
    }
}

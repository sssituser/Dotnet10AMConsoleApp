using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Class6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================Movie-1 Object==============");
            Movie m1 = new Movie();
            m1.GetMovie();

            Console.WriteLine("===================Movie-2 Object==============");
            Movie m2 = new Movie("Bahubali", "Prabhas", 5);
            m2.GetMovie();
            Console.WriteLine("===================Movie-3 Object==============");
            Movie m3 = new Movie("Darling", "Prabhas", 4.5);
            m3.GetMovie();

            Console.WriteLine("===================Movie-4 Object==============");
            Movie m4 = new Movie(m2);
            m4.GetMovie();

        }
    }
}

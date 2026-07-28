using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Movie
    {
        public int MovieId { get; private set; } = 111;
        public string MovieName { get; private set; } = "abc";
        public double MovieRating { get;private set; } = 4.5;
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            Movie m = new Movie();
            Console.WriteLine(m.MovieId);
            Console.WriteLine(m.MovieName);
            Console.WriteLine(m.MovieRating);

        }

    }
}

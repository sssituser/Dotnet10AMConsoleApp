using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndNonStaticProject
{
    internal class Movie
    {
        string MovieName;
        string MovieHero;
        double MovieRating;
        public Movie()
        {
            Console.WriteLine("Hi Iam Default Constructor");
        }
        public Movie(string MovieName, string MovieHero, double MovieRating)
        {
            Console.WriteLine("Hi Iam Parameterised Constructor");
            this.MovieName = MovieName;
            this.MovieHero = MovieHero;
            this.MovieRating = MovieRating;
        }

        public Movie(Movie movie)
        {
            Console.WriteLine("Hi Iam Copy Constructor");
            this.MovieName=movie.MovieName;
            this.MovieHero=movie.MovieHero;
            this.MovieRating=movie.MovieRating;
        }
        public void GetMovie()
        {
            Console.WriteLine($"Movie Name : {MovieName}");
            Console.WriteLine($"Movie Hero : {MovieHero}");
            Console.WriteLine($"Movie Rating : {MovieRating}");
        }
        ~Movie()
        {
            Console.WriteLine("Hi Iam Destructor");
            Console.ReadLine();
            Console.ReadLine();
        }
    }
}

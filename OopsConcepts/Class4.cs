using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Moviee
    {
        
        //1. Private non static global data
        private   int MovieeId;
        private  string MovieeName;
        private   double MovieRating; // Privte members can't be accessed outside of the class
        private string Hero;
        private string Heroin;
        //2. non static(Instance) method        
                                            //local prameters
        public void SetMovie(int movieId ,string movieName,double movieRating,string hero,string heroin)
        {
            MovieeId = movieId;
            MovieeName = movieName;
            MovieRating = movieRating;
            Hero = hero;
            Heroin = heroin;
        }
        public void GetMovieInfo()
        {
            Console.WriteLine($"Movie ID :{MovieeId}\nMovie Name : {MovieeName}\nMovie Rating : {MovieRating}\nHero : {Hero}\nHeroin : {Heroin}");
        }
    }
    internal class Class4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=======================Movie 1- Object======================");
            Moviee m1 = new Moviee();
            m1.SetMovie(123, "Bhaubali", 5.0, "Prabhas", "Anushka");
            m1.GetMovieInfo();
            Console.WriteLine("=======================Movie 2- Object======================");
            Moviee m2 = new Moviee();
            m2.SetMovie(124, "singham", 5.0, "Surya", "Anushka");
            m2.GetMovieInfo();
        }
    }
}

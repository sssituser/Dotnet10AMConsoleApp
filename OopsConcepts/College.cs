using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    internal class College
    {
        static string CollegeName;  // static Data
        static string Area;

        int StudentId;    // Non static Data or Instance Data
        string StudentName;
        int StudentAge;

       static void SetCollegeInfo()  // static methods
        {
            Console.WriteLine("Hi this Set CollegeInfo static method");
        }
        static void GetCollegeInfo()
        {
            Console.WriteLine("Hi this is GetColleggeInfo method");
        }
        void SetStudent()  // non static metods
        {
            Console.WriteLine("Hi this is SetStudent Non Static methdos");
        }
        void GetStudent()
        {
            Console.WriteLine("Hi this GetStudent Non static method");
        }
    }
}

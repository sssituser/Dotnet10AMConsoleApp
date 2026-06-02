using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dotnet10AMConsoleApp
{
    internal class Class10
    {
        static void Main(string[] args)
        {
            string name = "kiran";
            int age = 21;
            string gender = "Male";
            string eduction = "Graduate";
            double per = 8.7;
            string adderss = "Hyd"; // Initializing.


            Console.WriteLine(name); // Displaying data
            Console.WriteLine(age);
            Console.WriteLine(gender);
            Console.WriteLine(eduction);
            Console.WriteLine(per);
            Console.WriteLine(adderss);

            Console.WriteLine("=================================");
            Console.WriteLine("{0}    {1}      {2}      {3}       {4}       {5}",name,age,gender,eduction,per,adderss);
            Console.WriteLine("Name : {0}    Age : {1}      Gender : {2}    Education :  {3}     Percentage :  {4}      Address : {5}",name,age,gender,eduction,per,adderss);
            Console.WriteLine("===================================");
            Console.WriteLine($"{name}   {age}    {gender}   {eduction}    {per}   {adderss}");
            Console.WriteLine($"Name : {name}   Age : {age}    Gen : {gender}   Qulification : {eduction}    Percentage : {per}  Address : {adderss}");



        }
    }
}

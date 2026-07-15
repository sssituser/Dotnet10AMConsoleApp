using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConcepts
{
    class Employe
    {
        public static string CName;         // static data
        public static string Address;      // static data

        public int EmpId;  // non static data
        public string EmpName; // non static data
        public void SetEmployee()  // non static method
        {
            Console.Write("Enter Employee ID : ");
            EmpId = int.Parse(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            EmpName = Console.ReadLine();
        }
        public void GetEmployee()  // Accessmodifer returntype MethodName()
        {
            Console.WriteLine($"Employee ID : {EmpId}\nEmployeeName : {EmpName}");
        }
        public static void SetCompanyInfo()
        {
            Console.Write("Enter Company Name : ");
            CName = Console.ReadLine();
            Console.Write("Enter Company Address : ");
            Address = Console.ReadLine();
        }
        public static void GetCompanyInfo()
        {
            Console.WriteLine($"Compny Name :{CName}\nAddress : {Address} ");
        }

    }
    internal class Class1
    {
        static void Main(string[] args)
        {
            Employe.SetCompanyInfo();
            Employe.GetCompanyInfo();

            Employe emp1 = new Employe();
            emp1.SetEmployee();
            emp1.GetEmployee();

        }
    }
}

using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Properties
{
    class Employ
    {
        public int EmployeeId { get; private set ; }
        public  string  EmployeeName { get;private set; }
        public int EmployeeSalary { get; set; }

        public void SetEmployee(int EmployeeId, string EmployeeName, int EmployeeSalary)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.EmployeeSalary = EmployeeSalary;
        }
        public void GetEmloyee()
        {
            Console.WriteLine($"Employee ID :{EmployeeId}\tEmployee Name : {EmployeeName}\tEmployee Salary : {EmployeeSalary}");
        }
    }
    internal class Class11
    {
       

        static void Main(string[] args)
        {
            Type t = typeof(Employ);
            Console.WriteLine($"Class name : {t.Name}");
            Console.WriteLine($"Namespace : {t.Namespace}");
            Console.WriteLine("Properties Information");
           foreach(PropertyInfo info in t.GetProperties())
            {
                Console.WriteLine($"{info.Name}\t{info.PropertyType}");
            }
            Console.WriteLine("=============Methods information============");
           foreach(MethodInfo minfo in t.GetMethods())
            {
                Console.WriteLine($"{minfo.Name}");
            }
        }
    }
}

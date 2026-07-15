using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismConsoleApp
{
    class Employee
    {
        int EmpId;
        string EmpName;
        int EmpSal;
        public void SetEmployee(int EmpId, string EmpName, int EmpSal)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSal = EmpSal;
        }
        public virtual  void Show()
        {
            Console.WriteLine($"Emplyee ID : {EmpId}\tEmployee Name : {EmpName}\tEmployee Salary : {EmpSal}");
        }

    }

    class Department :Employee
    {
        int DeptId;
        string DeptName;
        public  Department(int DeptId,string DeptName)
        {
            this.DeptId = DeptId;
            this.DeptName = DeptName;
        }
        public override void Show()
        {
            Console.WriteLine($"Deptartment ID : {DeptId}\tDepartName : {DeptName}");
        }
    }
    class Testt : Employee
    {
        public override void Show()
        {
            Console.WriteLine("Hi this is  Show Method from Testt Class");
        }
    }
    internal class Class3
    {
        static void Main(string[] args)
        {
            Employee emp;
            emp = new Employee();
            emp.SetEmployee(111, "kiran", 5000);
            emp.Show(); // Employee Detials
            emp = new Department(123,"HR");
            emp.Show(); // Department Detials
            emp = new Testt();
            emp.Show();
        }
    }
}

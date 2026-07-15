using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPracitce
{
    internal class Employee
    {
        private int EmployeeId;
        private string EmployeeName;
        private int EmployeeSalary;
        public void SetEmployee(int EmployeeId,string EmployeeName,int EmployeeSalary)
        {
            this.EmployeeId = EmployeeId;
            this.EmployeeName = EmployeeName;
            this.EmployeeSalary = EmployeeSalary;
        }
        public void GetEmployee()
        {
            Console.WriteLine($"Employee ID : {EmployeeId}\nEmployee Name : {EmployeeName}\tEmployee Salary : {EmployeeSalary}");
        }

    }
}

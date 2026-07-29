using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSal { get; set; }

        public override string ToString()
        {
            return $"Emploee ID :{EmployeeId}\tEmployee Name : {EmployeeName}\tEmployee Salary : {EmployeeSal}";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Employee : IComparable<Employee>
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int EmployeeSal { get; set; }
        // sorting based on the salary
        public int CompareTo(Employee other)
        {
            if(this.EmployeeSal < other.EmployeeSal)
                return -1;
            if (this.EmployeeSal > other.EmployeeSal)
                return 1;
            return 0;
        }

        ////Sort Based on the Name
        //public int CompareTo(Employee other)
        //{
        //    return EmployeeName.CompareTo(other.EmployeeName);
        //}
        // Sort Based on the ID
        //public int CompareTo(Employee other)
        //{
        //    if (this.EmployeeId < other.EmployeeId)
        //    {
        //        return -1;
        //    }
        //    if (this.EmployeeId > other.EmployeeId)
        //    {
        //        return 1;
        //    }
        //    return 0;
        //}

        public override string ToString()
        {
            return $"Emploee ID :{EmployeeId}\tEmployee Name : {EmployeeName}\tEmployee Salary : {EmployeeSal}";
        }
       
    }
}

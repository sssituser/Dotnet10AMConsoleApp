using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsApp
{
    internal class Employee
    {
        protected int EmpId;
        protected string EmpName;
        protected int EmpSal;
        public Employee(int EmpId,string EmpName,int EmpSal)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
            this.EmpSal = EmpSal;
        }
        public override string ToString()
        {
            return $"Employee ID : {EmpId}\tEmployee Name :{EmpName}\tEmployee Salary : {EmpSal}";
        }
    }
}

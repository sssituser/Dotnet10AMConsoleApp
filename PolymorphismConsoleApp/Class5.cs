using System;

namespace PolymorphismConsoleApp
{
    class Employ
    {
      protected  int EmpId; // They can be Inherited
      protected string EmpName;
        public Employ(int EmpId,string EmpName)
        {
            this.EmpId = EmpId;
            this.EmpName = EmpName;
        }
        public override string ToString()
        {
            return $"EmpId : {EmpId}\tEmpName : {EmpName}";
        }
    }
    class Dept :Employ
    {
        int DeptId;
        string DeptName;
        public Dept(int DeptId,string DeptName,int EmpId,string EmpName):base(EmpId,EmpName)
        {
            this.DeptId = DeptId;
            this.DeptName = DeptName;
        }
        public override string ToString()
        {
            return $"EmployeeID : {EmpId}   Employee Name :{EmpName} DeptID : {DeptId}\tDeptName : {DeptName}";
        }
    }
    internal class Class5
    {
        static void Main(string[] args)
        {
            Dept dept = new Dept(1234,"HR",111,"kiran");
            Console.WriteLine(dept);
        }
    }
}
// Base keyword can be used to transfer the data from child class constructor to
// to the parent class constructor.
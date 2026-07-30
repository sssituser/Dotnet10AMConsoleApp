using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class3
    {
        static void Main(string[] args)
        {
            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(new Employee() { EmployeeId=111,EmployeeName="raj",EmployeeSal=40000});
            employeeList.Add(new Employee() { EmployeeId=110,EmployeeName="kiran",EmployeeSal=45000});
            employeeList.Add(new Employee() { EmployeeId=113,EmployeeName="charan",EmployeeSal=43000});
            employeeList.Add(new Employee() { EmployeeId=115,EmployeeName="deepak",EmployeeSal=50000});
            employeeList.Add(new Employee() { EmployeeId=112,EmployeeName="lakshmi",EmployeeSal=45000});
            employeeList.Add(new Employee() { EmployeeId=114,EmployeeName="jenita",EmployeeSal=60000});
            Console.WriteLine("=================Employees Inforamtion=================");
            foreach (Employee employee in employeeList)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("=================Employees Inforamtion Using var keyword=================");
            foreach (var emp in employeeList)
            {
                Console.WriteLine(emp);
            }
            Console.WriteLine("=================Employees Inforamtion Using Advanced ForEach=================");

            employeeList.ForEach(employee => Console.WriteLine(employee));
            Console.WriteLine("=================Employees Inforamtion using For Loop=================");
            for (int i = 0; i < employeeList.Count; i++)
            {
                Console.WriteLine(employeeList[i]);
            }

















        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee() {EmployeeId=111,EmployeeName="abc",EmployeeSal=200000 });
            employees.Add(new Employee() {EmployeeId=113,EmployeeName="ghi",EmployeeSal=250000 });
            employees.Add(new Employee() {EmployeeId=112,EmployeeName="def",EmployeeSal=190000 });
            employees.Add(new Employee() {EmployeeId=114,EmployeeName="klm",EmployeeSal=210000 });
            Console.WriteLine("Employees Object are");
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
        
        }
    }
}

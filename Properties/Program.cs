using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Employee
    {
        private int employeeId = 111; // public non static fields 
        private string employeeName = "kiran";
        private int employeeSal = 60000;

        public  int EmployeeId
        {
            get
            {
                return employeeId;  // Read only Property
            }
           
        }

        public string EmployeeName
        {
            get
            {
                return employeeName;  // Read Only Property
            }
           
        }

        public int EmployeeSal
        {
            get
            {
                return employeeSal;  // Read Only Property
            }

           
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
          


            Console.WriteLine(emp1.EmployeeId); // Reading the data
            Console.WriteLine(emp1.EmployeeName);
            Console.WriteLine(emp1.EmployeeSal);
           

        }
    }
}
// Privte Protected public Acessmodifers.
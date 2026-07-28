using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Test1
    {
        private int employeeId;

        public int EmployeeId
        {
            get { return employeeId; }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Employee Id can't -ve or 0");
                }
                else
                {
                    employeeId = value;
                }
            }
        }

    }
    internal class Class10
    {
        static void Main(string[] args)
        {
            Test1 t=new Test1();
            t.EmployeeId = 111;
            Console.WriteLine($"Employee Id : {t.EmployeeId}");
            Test1 t1 = new Test1();
            t1.EmployeeId = -3;
                
        }
    }
}

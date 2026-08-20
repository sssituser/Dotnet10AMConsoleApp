using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADONETENTITYFRAMEWORK
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ADODBEntities db=new ADODBEntities();
            tbl_employee emp = new tbl_employee();
            emp.eid = 567;
            emp.ename = "abc";
            emp.esal = 40000;
            db.tbl_employee.Add(emp);
           if(db.SaveChanges() == 1)
            {
                Console.WriteLine("Record added");
            }
            else
            {
                Console.WriteLine("Record Insertion Failed");
            }
            
        }
    }
}

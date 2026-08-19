using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAdoFramework
{
    internal class Class2
    {
        static void Main(string[] args)
        {
           DisConnectedBuisnessLogic bl=new DisConnectedBuisnessLogic();
            Employee emp = new Employee();
        Menu:
            Console.Write("1.AddEmployee\n2.Delete\n3.Update\n4.Find\n5.GetEmployees\nEnter Your choice : ");
            int choice = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (choice)
            {
                case 1:
                    Console.Write("Enter EmployeeID : ");
                    emp.EmpId=int.Parse(Console.ReadLine());
                    Console.Write("Enter Employee Name : ");
                    emp.EmpName = Console.ReadLine();
                    Console.Write("Enter Employee Sal   : ");
                    emp.EmpSal = int.Parse(Console.ReadLine());
                    if (bl.AddEmployee(emp))
                    {
                        Console.WriteLine("Record Added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Record InsertionFailed");
                    }
                    goto Menu;
                case 2:
                    Console.Write("Enter Employee Id   : ");
                    emp.EmpId = int.Parse(Console.ReadLine());

                    if (bl.DeleteEmployee(emp))
                    {
                        Console.WriteLine("Record Deleted Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Record Deletion Failed");
                    }
                    goto Menu;
                case 3:
                    Console.Write("Enter Employee Id   : ");
                    emp.EmpId = int.Parse(Console.ReadLine());
                    Console.Write("Enter Employee Name : ");
                    emp.EmpName = Console.ReadLine();
                    Console.Write("Enter Employee Sal   : ");
                    emp.EmpSal = int.Parse(Console.ReadLine());
                    if (bl.UpdateEmployee(emp))
                    {
                        Console.WriteLine("Record Updated Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Record Updation Failed");
                    }
                    goto Menu;
                case 4:
                    Console.Write("Enter Employee Id   : ");
                    emp.EmpId = int.Parse(Console.ReadLine());
                    emp = bl.FindEmployee(emp);
                    Console.WriteLine("--------------Employee Information----------------------");
                    Console.WriteLine($"Employee Name : {emp.EmpName}\tEmployee Salary : {emp.EmpSal}");
                    Console.WriteLine("---------------------------------------------------------");
                    goto Menu;
                case 5:
                    DataSet ds = bl.GetEmployees();
                    DataTable dt = ds.Tables["tbl_employe"];

                    if (dt.Rows.Count > 0)
                    {
                        Console.WriteLine("-------------------------------------------------------");
                        Console.WriteLine("EmpId\tEmpName\tEmpSal");
                        Console.WriteLine("-------------------------------------------------------");
                        foreach (DataRow row in dt.Rows)
                        {
                            Console.WriteLine($"{row[0]}\t{row[1]}\t{row[2]}");
                        }
                        Console.WriteLine("-------------------------------------------------------");
                    }
                    else
                    {
                        Console.WriteLine("Records Not Avialable");
                    }
                    goto Menu;
                default:
                    Console.WriteLine("Invalid choice, Enter Proper Choice..");
                    break;
            }
        }
    }
}

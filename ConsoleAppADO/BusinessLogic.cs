using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using System.Data;
using System.Runtime.InteropServices;
using Microsoft.Extensions.Logging;
namespace ConsoleAppADO
{
    internal class BusinessLogic
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataReader reader;
        DataTable dataTable;
        public BusinessLogic()
        {
            connection = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ADODB;Integrated Security=True;Encrypt=False");
            command = new SqlCommand();
            command.Connection = connection;
            connection.Close();
        }
        public bool AddEmployee(Employee emp)
        {
            command = new SqlCommand($"insert into tbl_employee values({emp.EmployeeId},'{emp.EmployeeName}',{emp.EmployeeSalary})");
            connection.Open();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res == 1;
        }
        public bool UpdateEmployee(Employee emp)
        {
            command = new SqlCommand($"update tbl_employee set ename = '{emp.EmployeeName}',esal = {emp.EmployeeSalary} where eid = {emp.EmployeeId}");
            connection.Open();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res == 1;
        }
        public bool DeleteEmployee(Employee emp)
        {
            command = new SqlCommand($"delete from tbl_employee where eid = {emp.EmployeeId}");
            connection.Open();
            int res = command.ExecuteNonQuery();
            connection.Close();
            return res == 1;
        }
        public DataTable GetEmployee()
        {
            command = new SqlCommand("select * from tbl_employee");
            connection.Open();
            reader = command.ExecuteReader();
            dataTable = new DataTable();
            dataTable.Load(reader);
            connection.Close();
            return dataTable;
        }
    }
}

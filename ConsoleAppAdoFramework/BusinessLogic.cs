using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Net.Http.Headers;
namespace ConsoleAppAdoFramework
{
    internal class BusinessLogic
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dt;
        public BusinessLogic() 
        {
            con=new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ADO10AMDB;Integrated Security=True;Encrypt=False");
            cmd = new SqlCommand();
            cmd.Connection = con;
            con.Close();
        }
        public bool AddEmployee(Employee emp)
        {
            cmd.CommandText = $"insert into tbl_employe(ename,esal)values('{emp.EmpName}',{emp.EmpSal})";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res == 1;
        }
        public bool UpdateEmployee(Employee emp)
        {
            cmd.CommandText = $"update tbl_employe set ename ='{emp.EmpName}', esal = {emp.EmpSal} where eid = {emp.EmpId}";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res == 1;
        }
        public bool DeleteEmployee(Employee emp)
        {
            cmd.CommandText = $"delete from tbl_employe where eid = {emp.EmpId}";
            con.Open();
            int res = cmd.ExecuteNonQuery();
            con.Close();
            return res == 1;
        }

        public DataTable GetEmployees()
        {
            cmd.CommandText = "select * from tbl_employe";
            con.Open();
            dr = cmd.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            con.Close();
            return dt;
        }
        public Employee GetEmployeeById(Employee emp)
        {
            cmd.CommandText = $"select * from tbl_employe where eid = {emp.EmpId}";
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                emp.EmpName = dr[1].ToString();
                emp.EmpSal = int.Parse(dr[2].ToString());
            }
            con.Close();
            return emp;
        }
    }
}

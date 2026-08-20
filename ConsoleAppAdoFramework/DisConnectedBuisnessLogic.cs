
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
namespace ConsoleAppAdoFramework
{
    internal class DisConnectedBuisnessLogic
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataSet ds;
        DataRow row;
        public DisConnectedBuisnessLogic()
        {

            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ADO10AMDB;Integrated Security=True;Encrypt=False");
            da = new SqlDataAdapter("select * from tbl_employe", con);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds,"tbl_employe");
            da.Update(ds,"tbl_employe");
            ds.Tables["tbl_employe"].Constraints.Add("eid_pk",ds.Tables["tbl_employe"].Columns["eid"],true);
            
        }
        public bool AddEmployee(Employee emp)
        {
            try
            {
                row = ds.Tables["tbl_employe"].NewRow();
                row[0] = emp.EmpId;
                row[1] = emp.EmpName;
                row[2] = emp.EmpSal;
                ds.Tables["tbl_employe"].Rows.Add(row);
                int res = da.Update(ds, "tbl_employe");
                return res == 1;
            }
            catch (ConstraintException ex)
            {
                Console.WriteLine($"Given Id Already Exists : {emp.EmpId}");
                return false;
            }
        }
        public bool UpdateEmployee(Employee emp)
        {
            row = ds.Tables["tbl_employe"].Rows.Find(emp.EmpId);
            if (row == null)
            {
                return false;
            }
            else
            {
                row[1] = emp.EmpName;
                row[2] = emp.EmpSal;
                int res = da.Update(ds, "tbl_employe");
                return res == 1;
            }
          
        }
        public bool DeleteEmployee(Employee emp)
        {
            try
            {
                DataRow row = ds.Tables["tbl_employe"].Rows.Find(emp.EmpId);
                if (row == null)
                {
                    return false;
                }
                ds.Tables["tbl_employe"].Rows.Find(emp.EmpId).Delete();
                int res = da.Update(ds, "tbl_employe");
                return res == 1;
            }catch(Exception )
            {
                return false;
            }
        }

        public Employee FindEmployee(Employee emp)
        {
            row = ds.Tables["tbl_employe"].Rows.Find(emp.EmpId);
            if(row== null)
            {
                return null;
            }
            emp.EmpName = row[1].ToString();
            // emp.EmpSal = int.Parse(row[2].ToString());
            emp.EmpSal = Convert.ToInt32(row[2].ToString());
            return emp;

        }
        public DataSet GetEmployees()
        {
            return ds;
        }

    }
}

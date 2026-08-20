using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ADONETENTITYFRAMEWORK
{
    internal class BusinesLogic
    {
        KMDBEntities kdb;
       
        public BusinesLogic()
        {
            kdb = new KMDBEntities();
           
        }
        public bool AddStudent(Table_Student student)
        {
            try
            {
                kdb.Table_Student.Add(student);
                return kdb.SaveChanges() == 1;
            }
            catch
            {
                return false;
            }
        }
        public Table_Student GetStudentById(Table_Student student)
        {
            student = kdb.Table_Student.Find(student.StudentId);
            if (student == null)
            {
                return null;
            }
            else
            {
                return student;
            }
        }
        public bool DeleteStudent(Table_Student student)
        {
            student = kdb.Table_Student.Find(student.StudentId);
            if(student == null)
            {
                return false;
            }
            else
            {
                kdb.Table_Student.Remove(student);
                return kdb.SaveChanges() == 1;
            }
        }

        public List<Table_Student> GetStudents()
        {
            return kdb.Table_Student.ToList();
        }


        public bool UpdateStudent(Table_Student student)
        {
            Table_Student studentex = kdb.Table_Student.Find(student.StudentId);
            if(studentex == null)
            {
                return false;
            }
            else
            {
                studentex.StudentName=student.StudentName;
                studentex.StuddentMarks=student.StuddentMarks;
                return kdb.SaveChanges()==1;
            }
        }
    }
}

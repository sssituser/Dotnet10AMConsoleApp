using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionFramework
{
    internal class Student : Comparer<Student>
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }

        public int Marks { get; set; }
        /*Sorting based on the Studnt ID
        public override int Compare(Student s1, Student s2)
        {
            if (s1.StudentId < s2.StudentId)
            {
                return -1;
            }
            if (s1.StudentId > s2.StudentId)
            {
                return 1;
            }
            return 0;
        }
        */
        /* Sorting based on the Studnt Name
         public override int Compare(Student s1, Student s2)
         {
             return s1.StudentName.CompareTo(s2.StudentName);
         }


         */

        public override int Compare(Student x, Student y)
        {
            if(x.Marks < y.Marks) return -1;
            if (x.Marks > y.Marks) return 1;
            return 0;

        }
        public override string ToString()
        {
            return $"StudentId : {StudentId}\tStudent Name :{StudentName}\tMarks : {Marks}";
        }
    }
}

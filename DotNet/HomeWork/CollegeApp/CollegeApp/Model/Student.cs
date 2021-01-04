using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeApp.Model;

namespace CollegeApp.Model
{
    public class Student
    {
        private int _rollNo;
        private string _studentName;

        public int getRollNo { get => _rollNo; }
        public string getStudentName { get => _studentName; }

        public Student(int rollno, string studentName)
        {
            _rollNo = rollno;
            _studentName = studentName;
        }
        
    }
}

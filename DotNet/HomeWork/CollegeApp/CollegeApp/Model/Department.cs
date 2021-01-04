using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollegeApp.Model;

namespace CollegeApp.Model
{
    class Department : College
    {
        private int _departmentID;
        private string _departmentName;
        private string _collegeName;

        public int DepartmentID { get => _departmentID; }
        public string DepartmentName { get => _departmentName; }
        public string CollegeName { get => _collegeName;}

        public Department(int departmentID, string departmentName,string collegeName) : base(departmentID,collegeName)
        {
            
            _departmentID = departmentID;
            _departmentName = departmentName;
            _collegeName = collegeName;
        }
        public override string ToString()
        {
            return "\nDepartment Code :" + _departmentID + "\nDepartment Name :" + _departmentName + "\nCollege Name :" + _collegeName + "\n";
        }
    }
}

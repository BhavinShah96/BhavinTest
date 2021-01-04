using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    class Employee : Department
    {
        private int _empCode;
        private string _empName;
        private string _department;
        public int EmpCode { get => _empCode; }
        public string EmpName { get => _empName; }
        public string Department { get => _department;}

        public Employee(int code, string empName,string department) : base(code,empName,department)
        {
            _empCode = code;
            _empName = empName;
            _department = department;
        }

        public override string ToString()
        {
            return "\nEmployee Code :" + _empCode + "\nEmployee Name :" + _empName + "\nDepartment Name :" + _department + "\n";
        }
    }
}

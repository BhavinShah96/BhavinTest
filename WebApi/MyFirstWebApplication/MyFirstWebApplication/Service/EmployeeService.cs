using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MyFirstWebApplication.Models;
using MyFirstWebApplication.DTO;

namespace MyFirstWebApplication.Service
{
    public class EmployeeService
    {
        public static List<Employee> employee = new List<Employee>()
       {
           new Employee(){ID=Guid.NewGuid(),EmpName="Bhavin",Designation = "IT Engineer",Salary=35000},
           new Employee(){ID=Guid.NewGuid(),EmpName="Inder",Designation = "IT Engineer",Salary=30000}
       };

        public List<Employee> getEmployee()
        {
            return employee;
        }

        public List<Employee> ADD(EmployeeDTO dTO)
        {
            employee.Add(new Employee { ID = Guid.NewGuid(), EmpName = dTO.EmpName, Designation = dTO.Designation, Salary = dTO.Salary });
            return employee;
        }

        public Employee GetEmployeeByID(EmployeeDTO dto)
        {
            Employee emp = employee.Single(e => e.ID == dto.ID);
            return emp;
        }
        public void DelEmployee(EmployeeDTO dto)
        {
            Employee details = employee.Single(e => e.ID == dto.ID);
            employee.Remove(details);
        }
    }
}
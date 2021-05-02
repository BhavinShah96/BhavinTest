using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using MyFirstWebApplication.Service;
using MyFirstWebApplication.DTO;
using MyFirstWebApplication.Models;

namespace MyFirstWebApplication.Controllers
{
    public class EmployeeController : ApiController
    {
        EmployeeService service = new EmployeeService();
        public IHttpActionResult GetEmployees()
        {
            
            return Ok(service.getEmployee());
        }

        [HttpPost]
        public IHttpActionResult Post(EmployeeDTO empDTO)
        {
            service.ADD(empDTO);
            return Ok("Post is Working");
        }

        [HttpPut]
        public IHttpActionResult Put(EmployeeDTO employeeDTO)
        {
            Employee employee = service.GetEmployeeByID(employeeDTO);
            employee.ID = employeeDTO.ID;
            employee.EmpName = employeeDTO.EmpName;
            employee.Designation = employeeDTO.Designation;
            employee.Salary = employeeDTO.Salary;
            return Ok("Put is Working");
        }

        [HttpDelete]
        public IHttpActionResult Delete(EmployeeDTO employeeDTO)
        {
            service.DelEmployee(employeeDTO);
            return Ok("Employee Details Deleted");
        }
    }
}
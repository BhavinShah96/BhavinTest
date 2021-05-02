using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstWebApplication.Models
{
    public class Employee
    {
        
        public Guid ID { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }
    }
}
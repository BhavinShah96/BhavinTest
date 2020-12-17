using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    class Employee
    {
        private int _id;
        private string _name;
        private double salary;

        public Employee(int id, string name, double salary)
        {
            this._id = id;
            this._name = name;
            this.salary = salary;
        }

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public double Salary { get => salary; set => salary = value; }
    }

}

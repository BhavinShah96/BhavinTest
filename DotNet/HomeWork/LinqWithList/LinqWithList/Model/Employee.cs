using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWithList.Model
{
    class Employee
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public int _salary { get; set; }

        public Employee(int id,string name,int salary)
        {
            this._id = id;
            this._name = name;
            this._salary = salary;
        }
    }
}

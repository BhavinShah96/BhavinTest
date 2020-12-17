using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Model
{
    class Programmer : Employee
    {
        private float _Bonus;

       
        public Programmer(int id, string name, double salary, float bonus) : base(id,name,salary)
        {
            this._Bonus = bonus;
        }
        public float getBonus { get => _Bonus; }

        public double CalculateSalary()
        {
            double total = this.Salary + _Bonus;
            return total;
        }
    }

}

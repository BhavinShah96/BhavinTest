using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDemoApp.Model
{
    class Professor : Person
    {
        private float _basicSalary;
        private const float _HRA = 50;
        private const float _TA = 40;
        private float _grossSalary;

        public float BasicSalary { get => _basicSalary;}
        public float GrossSalary {
            get => _grossSalary = _basicSalary + (_basicSalary * (_HRA / 100) + (_basicSalary * (_TA / 100)));
            
        }

        public Professor(int id , string address , DateTime dateofBirth, float basicSalary) : base(id,address,dateofBirth)
        {
            this._basicSalary = basicSalary;
        }
    }
}

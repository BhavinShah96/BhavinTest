using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDemoApp.Model
{
    class student : Person
    {
        private Branch _branch;

        public student(int id,string address,DateTime dateOfBirth,Branch branch) : base(id,address,dateOfBirth)
        {
            _branch = branch;
        }
        public Branch Branch { get => _branch; set => _branch = value; }
    }
}

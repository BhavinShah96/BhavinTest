using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfessorDemoApp.Model
{
    class Person
    {
        private int _id;
        private string _address;
        private DateTime _dateOfBirth;

        public Person(int id,string address,DateTime dob)
        {
            this._id= id;
            this._address = address;
            this._dateOfBirth = dob;
        }

        public int Id { get => _id; }
        public string Address { get => _address;}
        public DateTime DateOfBirth { get => _dateOfBirth; }
    }
}

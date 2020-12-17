using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonTestApp.Model
{
    class Person
    {
        private string _Name;
        private double _Height;
        private double _Weight;
        private string _Gender;
        private int _Age;

        public string Name { get => _Name; set => _Name = value; }
        public double Height { get => _Height; set => _Height = value; }
        public double Weight { get => _Weight; set => _Weight = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public int Age { get => _Age; set => _Age = value; }

        //public Person()
        //{
        //    Height = 5.5;
        //    Weight = 72;
        //    Name = "Bhavin";
        //    Gender = "Male";
        //    Age = 24;
        //}
        
        public double IsEating()
        {
           return Weight = Weight + ((Weight * 20) / 100);
            
        }

        public double IsDiating()
        {
           return Weight = Weight - ((Weight * 10) / 100);
            
        }
        
    }
}
    
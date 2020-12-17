using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonApp.Model
{
    class Person
    {
        private int _age;
        private string _Name;
        private string _Gender;
        private int _weight;
        private float _height;
        readonly private string _NullName;
        readonly public int Start_Range = 18;
        readonly public int End_Range = 25;

        
        public int Age { get => _age; set => _age = value; }
        public string Name { get => _Name; set => _Name = value; }
        public string Gender { get => _Gender; set => _Gender = value; }
        public int Weight { get => _weight; set => _weight = value; }
        public float Height { get => _height; set => _height = value; }

        public Person(int age, string name, string gender, int weight, float height)
        {
            this.Name = name;
            this.Age = age;
            this.Height = height;
            this.Weight = weight;
            this.Gender = gender;
        }
        
    }
}

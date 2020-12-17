using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentApp.Model
{
   public class Student
    {
        private string _firstName = "null";
        private string _lastName = "null";
        private IQLevel _iqLevel;

        public string FirstName { 
            get => _firstName; 
            set
            {
                if(checkLength(value))
                {
                    _firstName = value;
                }
                else 
                {
                    _firstName = "Default Value";
                }
            }
        }
        public string LastName {
            get => _lastName;
            set
            {
                if(checkLength(value))
                {
                    _lastName = value;
                }
                else 
                {
                    _lastName = "Default Value";
                }
            }
        }
        public string FullName
        {
            get => _firstName + " " + _lastName;
        }
        internal IQLevel IQLevel { get; set; }

        public bool checkLength(string str)
        {
            if (str.Length <= 5)
                return true;
            else
                return false;
        }
        public bool IsLongName()
        {
            if(this.FullName.Length > 12)
            {
                return true;
            }
            else { return false; }
        }
    }
}

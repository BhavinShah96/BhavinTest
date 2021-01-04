using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollegeApp.Model
{
    public class College
    {
        private int CollegeID;
        private string CollegeName;

        public int getCollegeID { get => CollegeID; }
        public string getCollegeName { get => CollegeName; }

        public College(int id, string name)
        {
            CollegeID = id;
            CollegeName = name;
        }
        public override string ToString()
        {
            return "\nCollege Code :" + CollegeID + "\nCollege Name :" + CollegeName + "\n";
        }

    }
}

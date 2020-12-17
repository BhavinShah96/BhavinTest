using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandidateTestApp.Model
{
    public class Candidate
    {
        private int _id;
        private string _name;
        private string _creditPoint;

        public int Id { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public string CreditPoint { get => _creditPoint; set => _creditPoint = value; }
    }
}

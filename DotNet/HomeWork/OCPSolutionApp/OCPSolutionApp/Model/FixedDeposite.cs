using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Model;

namespace OCPSolutionApp.Model
{
    class FixedDeposite
    {
        private int _accNo;
        private string _AccName;
        
        private double _principle;
        private int _years;
        IFestivalRate _ifestivalRate;
        private double _amount;

        public int AccNo { get => _accNo; }
        public string AccName { get => _AccName; }

        public double Principle { get => _principle; }
        public int Years { get => _years; }

        public double Amount { get => _amount; }
        internal IFestivalRate IfestivalRate { get => _ifestivalRate; }
        

        public FixedDeposite(int accNo, string name, double principle, int years,IFestivalRate festivalRate)
        {
            _accNo = accNo;
            _AccName = name;
            _principle = principle;
            _years = years;
            _ifestivalRate = festivalRate;
        }
        public double SimpleInterest()
        {
            _amount = (_principle * _ifestivalRate.GetRate() * _years) / 100;
            return _amount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenClosePrincipleApp.Model;

namespace OpenClosePrincipleApp.Model
{
    class FixedDeposite
    {
        private int _accNo;
        private string _AccName;
        private double _rate;
        private double _principle;
        private int _years;
        private FestivalType _festival;
        private double _amount;

        public int AccNo { get => _accNo;}
        public string AccName { get => _AccName;}
        public double Rate { get => _rate; }
        public double Principle { get => _principle; }
        public int Years { get => _years; }
        internal FestivalType Festival { get => _festival;}
        public double Amount { get => _amount;}

        public FixedDeposite(int accNo, string name, double principle, int years, FestivalType festival)
        {
            _accNo = accNo;
            _AccName = name;
            _principle = principle;
            _years = years;
            _festival = festival;
        }

        public double SimpleInterest()
        {
            

            if(_festival == FestivalType.Diwali)
            {
                _rate = 7;
                _amount = (_principle * _rate * _years) / 100;
                return _amount;
            }
            else if(_festival == FestivalType.Holi)
            {
                _rate = 8;
                _amount = (_principle * _rate * _years) / 100;
                return _amount;
            }
            else
            {
                _rate = 4.5;
                _amount = (_principle * _rate * _years) / 100;
                return _amount;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorephicApp.Model
{
    class CurrentAccount : Account
    {
        public double NewBalance = 0;
        public double NewUpdBalance = 0;
        public CurrentAccount(int acc, string name, double Bal) : base(acc, name, Bal)
        {

        }

        public override double Withdraw(double bal, int amt)
        {
            if (bal > 500)
            {
                return NewBalance = getModifiedBal() - amt;
            }
            else { return 0; }

        }
        public override double Deposite(double bal, int amt)
        {
            if (NewUpdBalance == NewBalance)
            {
                NewBalance = bal + amt;
                return NewBalance;
            }
            else
            {
                NewBalance = getModifiedBal() + amt;
                return NewBalance;
            }
        }
        public override double getModifiedBal()
        {
            NewUpdBalance = NewBalance;
            return NewBalance;
        }




    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorephicApp.Model
{
    class SavingAccount : Account
    {
        public double NewBalance = 0;
        public double NewUpdBalance = 0;
        
        public SavingAccount(int acc, string name, double Bal) : base(acc, name, Bal)
        {

        }
        public override double Withdraw(double bal, int amt)
        {
            if (bal > 500)
            {
                NewBalance = getModifiedBal() - amt;
                WiCount++;
                return NewBalance;
            }
            else { return 0; }

        }
        public override double Deposite(double bal, int amt)
        {
            if (NewUpdBalance == NewBalance)
            {
                NewBalance = bal + amt;
                Decount++;
                return NewBalance;
            }
            else
            {
                NewBalance = getModifiedBal() + amt;
                Decount++;
                return NewBalance;
            }
        }
        public override double getModifiedBal()
        {
            NewUpdBalance = NewBalance;
            return NewUpdBalance;
        }
    }
}

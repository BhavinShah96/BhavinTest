using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorephicApp.Model
{
   abstract class Account
    {
        private int AccNo;
        private string AccName;
        private double Balance;
        public int Decount = 0;
        public int WiCount = 0;

        public Account(int acc, string name, double Bal)
        {
            this.AccName = name;
            this.AccNo = acc;
            this.Balance = Bal;
        }
        public Account(double Balance)
        {
            this.Balance = Balance;
        }
        public int GetAccNo()
        {
            return AccNo;
        }
        public string GetAccName()
        {
            return AccName;
        }
        public double GetBalance()
        {
            return Balance;
        }

        abstract public double Deposite(double bal, int amt);

        abstract public double Withdraw(double Bal,int amt);

        abstract public double getModifiedBal();
    }
}

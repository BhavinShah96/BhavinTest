using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountEventApp.NewFolder1
{
    public delegate void DBankTransection(string accNo, string accName, double balance);
     public class Account
    {
        public event DBankTransection OnBalanceChanged = null;

       private string _AccNo;
       private string _AccName;
       private double _Balance;

        public string GetAccNo { get => _AccNo;}
        public string GetAccName { get => _AccName;}
        public double getBalance { get => _Balance; }

        public Account(string accNo,string accName,double balance)
        {
            _AccNo = accNo;
            _AccName = accName;
            _Balance = balance;
        }

        public void Deposite(string accNo,string accName,double amount)
        {
            if(OnBalanceChanged != null)
            {
                OnBalanceChanged(accNo, accName, this._Balance = getBalance + amount);
            }
        }

        public void WithDraw(string accNo, string accName, double amount)
        {
            if (OnBalanceChanged != null)
            {
                OnBalanceChanged(accNo, accName, this._Balance = getBalance - amount);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
  class Account
    {
        private int _accNo;
        private string _accName;
        private double _balance;
        readonly int minBalance = 500;
        private double amount;

        public Account(int accNo,string accName,double Balance)
        {
            this._accNo = accNo;
            this._accName = accName;
            this._balance = Balance;
        }
        public int GetAccNo()
        {
            return _accNo;
        }
        public string AccName() {
            return _accName;
        }
        public double Balance()
        {
            return _balance;
        }
        public double Amount() 
        {
            return amount;
        }

        public  void deposite(double balance,double Amount)
        {
            double UpdateBalance = balance + Amount;
            this._balance = UpdateBalance;
            Console.WriteLine("After Deposite Updated Balance is : " + this._balance); 
        }
        public  void withdraw(double balance, double Amount)
        {
          
                double UpdateBalance = balance - Amount;
                this._balance = UpdateBalance;
            Console.WriteLine("After Withdraw Updated Balance is : " + this._balance);
        }
    }
    
    class MyException : ApplicationException
    {
        public void MyNewException()
        {
            Console.WriteLine("Exception : You Can not withdraw , Your Account Must have more then Rs.2000");
        }
    }
}

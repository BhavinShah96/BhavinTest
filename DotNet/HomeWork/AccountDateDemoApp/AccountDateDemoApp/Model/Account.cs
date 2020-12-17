using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountDateDemoApp.Model
{
   public class Account
    {
        private int _accno;
        private string _accName;
        private double _balance;
        private string _creationDate;
        private string _DOB;

        public int getAccno { get => _accno;}
        public string getAccName { get => _accName;}
        public double getBalance { get => _balance; }
        public string getCreationDate { get => _creationDate;}
        public string getDOB { get => _DOB; }

        public Account(int accNo, string accName,double balance, string creationDate, string dob)
        {
            this._accno = accNo;
            this._accName = accName;
            this._balance = balance;
            this._creationDate = creationDate;
            this._DOB = dob;
        }
    }
}

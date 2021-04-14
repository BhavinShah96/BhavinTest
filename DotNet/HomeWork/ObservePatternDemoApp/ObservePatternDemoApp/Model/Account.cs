using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservePatternDemoApp.Model;

namespace ObservePatternDemoApp.Model
{
    class Account
    {
        private int _accNo;
        private string _Email;
        private double _Mobile;
        private double _balance;
        private double _amount;
        private String status;
        private List<Litsner> litsners = new List<Litsner>();


        public Account(int accNo, string Email, double Mobile)
        {
            List<Litsner> litsners = new List<Litsner>();
            _accNo = accNo;
            _Email = Email;
            _Mobile = Mobile;
            _balance = 500;
        }

        public List<Litsner> GetLitsners()
        {
            return litsners;
        }

        public int AccNo { get => _accNo; }
        public string Email { get => _Email; }
        public double Mobile { get => _Mobile; }
        public double Amount { get => _amount; }
        public double Balance { get => _balance; }
        public string Status { get => status;}

        public void registerSubscriber(Litsner IListner)
        {
            litsners.Add(IListner);
        }

        public void removeSubScriber(Litsner IListner)
        {
            litsners.Remove(IListner);
        }

        public void withDraw(double amount)
        {
            _amount = amount;
            _balance = _balance - amount;
            status = "Deducted";
            foreach(Litsner Ilitsners in litsners)
            {
                Ilitsners.upDate();
            }
        }
        public void deposite(double amount)
        {
            _amount = amount;
            _balance = _balance + amount;
            status = "Credited";
            foreach (Litsner Ilitsners in litsners)
            {
                Ilitsners.upDate();
            }
        }
        
    }
}

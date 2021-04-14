using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountEventApp.NewFolder1;

namespace AccountEventApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Acc1252", "Bhavin", 25000);
            account.OnBalanceChanged += PrintDetails;
            account.Deposite(account.GetAccNo, account.GetAccName, 200.00);
            account.WithDraw(account.GetAccNo, account.GetAccName, 10000.00);
        }

        public static void PrintDetails(string accNo,string accName,double balance)
        {
            Console.WriteLine("Account No is : " + accNo);
            Console.WriteLine("Account Name is : " + accName);
            Console.WriteLine("Balance is : " + balance);
        }
    }
}

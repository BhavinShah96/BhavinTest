using AccountPolymorephicApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountPolymorephicApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Account Acc = new SavingAccount(1234, "Bhavin", 25000);
            Account Acc1 = new CurrentAccount(4567, "inder", 26000);
            Acc.Deposite(Acc.GetBalance(), 1000);
            Acc.Deposite(Acc.GetBalance(), 1000);
            Acc.Withdraw(Acc.GetBalance(), 5000);
            PrintInfo(Acc,Acc1);
        }
        public static void PrintInfo(Account Acc, Account Acc1)
        {

            Console.WriteLine("Saving Account Holder Name : " + Acc.GetAccName());
            Console.WriteLine("Saving Account No : " + Acc.GetAccNo());
            Console.WriteLine("Balance in Saving Account After Deposite is : " + Acc.getModifiedBal());
            Console.WriteLine("Deposite is done " + Acc.Decount + " times.");
            Console.WriteLine("Balance in Saving Account After Withdraw is : " + Acc.getModifiedBal());
            Console.WriteLine("Withdraw is done " + Acc.WiCount + " times.");
            //Console.WriteLine("Current Account Holder Name : " + curr.GetAccName());
            //Console.WriteLine("Current Account No : " + curr.GetAccNo());
            //Console.WriteLine("Balance in Current Account After Deposite is : " + curr.Deposite(curr.GetBalance(), 2000));
            //Console.WriteLine("Balance in Current Account After Withdraw is : " + curr.Withdraw(curr.getModifiedBal(), 2000));
            //Console.WriteLine("\n");

        }

    }
}

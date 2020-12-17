using AccountApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1234,"Bhavin",25000);

            printInfo(acc);
            acc.deposite(acc.Balance(), 500);
            acc.withdraw(acc.Balance(), 500);



        }
        public static void printInfo(Account acc)
        {
            Console.WriteLine("Account No is :"+ acc.GetAccNo());
            Console.WriteLine("Account Name is :" + acc.AccName());
        }

        
    }
}

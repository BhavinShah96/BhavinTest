using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountDateDemoApp.Model;

namespace AccountDateDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account[] acc = new Account[4];
            acc[0] = new Account(1000, "Bhavin", 2000000, "2020/10/13", "13/03/1996");
            acc[1] = new Account(1001, "Ravin", 1900000, "21/10/2020", "13/03/1997");
            acc[2] = new Account(1002, "kishan", 180000, "22/10/2020", "13/03/1998");
            acc[3] = new Account(1003, "Mishan", 2300000, "23/10/2020", "13/03/1999");
            findRechestAccountHolder(acc);
        }

        static void findRechestAccountHolder(Account[] account)
        {
            double max = account[0].getBalance;
            for (int i = 0; i < account.Length; i++)
            {
                if (account[i].getBalance > max)
                {
                    max = account[i].getBalance;
                    Console.WriteLine("Richhest Account holder is " + account[i].getAccName);
                }
            }
        }
    }
}

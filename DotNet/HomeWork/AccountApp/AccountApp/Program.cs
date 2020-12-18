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

            Account acc = new Account(1234, "Bhavin", 500);
            MyException ex = new MyException();
            printInfo(acc);
            

            try 
            {
                acc.deposite(acc.Balance(), 500);
                

                if(acc.Balance() > 2000)
                {
                    acc.withdraw(acc.Balance(), 500);
                }
                else
                {
                    throw new MyException();
                }
            }
            catch(MyException e)
            {
                e.MyNewException();
            }

        }
        public static void printInfo(Account acc)
        {
            Console.WriteLine("Account No is :" + acc.GetAccNo());
            Console.WriteLine("Account Name is :" + acc.AccName());
        }


    }
}

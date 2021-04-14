using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservePatternDemoApp.Model;

namespace ObservePatternDemoApp.Model
{
    class Email : Litsner
    {
        private Account account;

        public Email(Account account)
        {
            this.account = account;
            this.account.registerSubscriber(this);
        }
        public void upDate()
        {
            Console.WriteLine("------- Email Notification -------");
            Console.WriteLine("Email : " + account.Email);
            Console.WriteLine("Amount : " + account.Status);
            Console.WriteLine("Current Balance : " + account.Balance);
            Console.WriteLine("\n");
        }
    }
}

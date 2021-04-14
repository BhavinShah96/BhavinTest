using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservePatternDemoApp.Model;

namespace ObservePatternDemoApp.Model
{
    class SMS : Litsner
    {
        private Account account;

        public SMS(Account account)
        {
            this.account = account;
            this.account.registerSubscriber(this);
        }
        public void upDate()
        {
            
            Console.WriteLine("------- SMS Notification -------");
            Console.WriteLine("Mobile No : " + account.Mobile);
            Console.WriteLine("Amount : " + account.Status);
            Console.WriteLine("Current Balance : " + account.Balance);
            Console.WriteLine("\n");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObservePatternDemoApp.Model;

namespace ObservePatternDemoApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(123, "bhavinpshah96@gmail.com", 8733803574);
            Account account1 = new Account(456, "sonamsingh@gmail.com", 7016289636);


            Email email = new Email(account1);
            SMS mS = new SMS(account1);

            account1.withDraw(200.0);
            account1.deposite(500.0);
        }

    }
}

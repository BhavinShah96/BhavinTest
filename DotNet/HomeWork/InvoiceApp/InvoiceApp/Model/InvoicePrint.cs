using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceApp.Model;

namespace InvoiceApp.Model
{
    class InvoicePrint
    {
        public void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine(invoice.AccNo);
            Console.WriteLine(invoice.Name);
            Console.WriteLine(invoice.Amount);
            Console.WriteLine(invoice.DiscountPercentage);
            Console.WriteLine(invoice.calculateAmount());

        }
    }
}

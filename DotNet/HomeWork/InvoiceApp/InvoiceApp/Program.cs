using InvoiceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceApp.Model;

namespace InvoiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(20222, "Bhavin", 25000, 10, 5);
            InvoicePrint inv = new InvoicePrint();
            inv.PrintInvoice(invoice);
            
        }
       
    }
}

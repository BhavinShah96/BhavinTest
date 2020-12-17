using InvoiceApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice inv = new Invoice(20220,"Bhavin",100,10,5);
            PrintInfo(inv);
        }
        public static void PrintInfo(Invoice i)
        {
            Console.WriteLine("Accont No is :" + i.AccNo);
            Console.WriteLine("Name is :" + i.Name);
            Console.WriteLine("Amount No is :" + (i.CalculateDiscount()));
            Console.WriteLine("Amount No is :" + (i.CalculateGST()));
            Console.WriteLine("Amount No is :" + (i.calculateAmount()));
        }
    }
}

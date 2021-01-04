using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection_Generic_App.Model;

namespace Collection_Generic_App
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Customer Product Details : \n");
            
            Customer c = new Customer(1, "Bhavin");
            PrintInfo(c);
        }
        public static void PrintInfo(Customer c)
        {
            Console.WriteLine("\nCustomer ID :" + c.Id);
            Console.WriteLine(" Customer Name :" + c.Name);
        }
        
    }
}

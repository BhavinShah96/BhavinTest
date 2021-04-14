using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerShoppingCartApp.Model;

namespace CustomerShoppingCartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer(1001, "Bhavin", "Ahmedabad");

            Product apple = new Product(1, "book", 10, 5);
            Product mango = new Product(2, "glass", 15, 10);
            Product orange = new Product(3, "shoes", 5, 5);

            Order o1 = new Order(101,new DateTime(2020,10,17));
            o1.AddItem(new LineItems(201, 12, apple));
            o1.AddItem(new LineItems(202, 6, mango));
            o1.AddItem(new LineItems(202, 1, mango));

            Order o2 = new Order(102,new DateTime(2020, 10, 17));
            o2.AddItem(new LineItems(204, 10, mango));
            o2.AddItem(new LineItems(203, 5, orange));

            c1.AddOrder(o1);
            c1.AddOrder(o2);

            PrintInfo(c1);
        }
        public static void PrintInfo(Customer c)
        {
            Console.WriteLine("Customer details : " + c.Id + ", " + c.Name + ", " + c.Address);
            c.Order.ForEach(Console.WriteLine);
        }
    }
}

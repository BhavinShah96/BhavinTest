using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDefineCheckedExeptionApp.Model;

namespace UserDefineCheckedExeptionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int acceptorder;
            int stock = 10;
            Console.WriteLine("Welcome to Shopping Site:\nHow many headphone you want to buy (Total 10 in Stock):");
            acceptorder = Convert.ToInt32(Console.ReadLine());
            try
            {
                if (acceptorder == stock || acceptorder < stock)
                {
                    Console.WriteLine("Congratulations! You have bought {0} headphones", acceptorder);
                    Console.ReadLine();
                }
                else
                {
                    throw (new OutofStockException("OutofStockException Generated: The number of item you want to buy is out of stock. Please enter total item number within stock"));
                }
            }
            catch (OutofStockException oex)
            {
                Console.WriteLine(oex.Message.ToString());
                Console.ReadLine();
            }
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Collection_Generic_App.Model;

namespace Collection_Generic_App.Model
{
    class Customer
    {
        
        private int _id;
        private string _name;
        private double _totalCost = 0.0;

        public int Id { get => _id; }
        public string Name { get => _name; }
        public double TotalCost { get => _totalCost; }

        public Customer(int id, string name)
        {
            _id = id;
            _name = name;
            
            List<Product> myList = new List<Product>();
            myList.Add(new Product(1,"orange",25.50,3));
            myList.Add(new Product(2, "Apple", 30.45, 5));
            myList.Add(new Product(3, "Pinaple", 31.45, 6));

            foreach(var i in myList)
            {
                Console.WriteLine(i);
            }

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingCartApp.Model
{
    class Customer
    {
        private int _id;
        private string _name;
        private string _address;
        private List<Order> _order = new List<Order>();

        public void AddOrder(Order order)
        {
            _order.Add(order);
        }
        public int Id { get => _id; }
        public string Name { get => _name;}
        public string Address { get => _address; }
        internal List<Order> Order { get => _order; }

        public Customer(int id,string name,string address)
        {
            _id = id;
            _name = name;
            _address = address;
        }
        

        public override string ToString()
        {
            return "\nCustomer ID :" + _id + " Customer Name :" + _name + " Address : " + _address;
        }
    }
}

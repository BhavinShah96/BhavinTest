using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingApp.Model
{
    class Customer
    {
        private int _id;
        private string _name;
        private string _address;

        public int Id { get => _id; }
        public string Name { get => _name;}
        public string Address { get => _address; }
    }
}

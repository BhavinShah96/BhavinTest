using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerShoppingApp.Model;

namespace CustomerShoppingApp.Model
{
    class ItemList
    {
        private int _id;
        private int _quantity;
        private string _product;

        public ItemList(int id,int quantity,string product) 
        {
            _id = id;
            _quantity = quantity;
            _product = product;
        }

        public double calculateTotalCost()
        {
            return _quantity;
        }

        public int Id { get => _id; }
        public int Quantity { get => _quantity;}
        public string Product { get => _product; }
    }
}

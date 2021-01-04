using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingApp.Model
{
    class Product
    {
        private int _id;
        private string _name;
        private int _price;
        private float _discountPercentage;

        public Product(int id, string name, int price, int discount)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountPercentage = discount;
        }

        public double totalCost()
        {
            double totalcost = (Price - (Price * DiscountAmount)/100));
            return totalcost;
        }

        public int Id { get => _id;  }
        public string Name { get => _name;}
        public int Price { get => _price;}
        public float DiscountAmount { get => _discountAmount;}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingCartApp.Model
{
    class Product
    {
        private int _id;
        private string _name;
        private double _price;
        private float _discountRate;

        public int Id { get => _id;}
        public string Name { get => _name; }
        public double Price { get => _price;}
        public float DiscountRate { get => _discountRate;}

        public Product(int id,string name,double price,float discountRate)
        {
            _id = id;
            _name = name;
            _price = price;
            _discountRate = discountRate;
        }

        public double totalCost { get => Price - (Price * DiscountRate / 100); }
        

        public override string ToString()
        {
            return "\nProduct ID : " + _id + " Product Name : " + _name + "\nDiscount Rate : " + _discountRate + " Unit Price : " + _price + " Final Price : " + totalCost ;
        }
    }
}

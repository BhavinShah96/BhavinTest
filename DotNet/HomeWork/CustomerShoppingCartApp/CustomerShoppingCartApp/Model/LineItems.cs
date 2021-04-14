using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomerShoppingCartApp.Model;

namespace CustomerShoppingCartApp.Model
{
    class LineItems 
    {
        private int _id;
        private int _quantity;
        private Product _products;
        
        

         public int Id { get => _id; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        internal Product Products { get => _products; }

        public LineItems(int id,int quantity , Product products)
        {
            _id = id;
            _quantity = quantity;
            _products = products;
        }
        public double calculateTotalCost()
        {
            return _quantity * _products.totalCost;
        }

        public override string ToString()
        {
            return "\nLine Item ID : " + Id  + " Quantity : " + Quantity + " CheckOut Price : " + calculateTotalCost();
        }
    }
}

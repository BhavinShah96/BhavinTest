using System;
using System.Collections.Generic;

namespace Collection_Generic_App.Model
{
    public class Product
    {
        private int _id;
        private string _name;
        private double _cost;
        private int _quantity;
        private static double _totalCost = 0.0;

        public int Id { get => _id; }
        public string Name { get => _name; }
        public double Cost { get => _cost; }
        public int Quantity { get => _quantity; }
        public double TotalCost { get => _totalCost; }
        

        public Product(int id, string name, double cost, int quantity)
        {
            _id = id;
            _name = name;
            _cost = cost;
            _quantity = quantity;
            //_totalCost += (_cost * quantity);
        }

        public override string ToString()
        {
            return "\nID:" + _id + "\nName :" + _name + "\nCost:" + _cost + "\nQuantity :" + _quantity + "\nProduct Cost :" + (_quantity * _cost); 
        }
    }
}

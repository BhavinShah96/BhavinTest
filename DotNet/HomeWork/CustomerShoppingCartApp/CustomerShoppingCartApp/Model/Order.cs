using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerShoppingCartApp.Model
{
    class Order
    {
        private int _id;
        private DateTime _date;
        private List<LineItems> _item = new List<LineItems>();

        public int Id { get => _id; }
        public DateTime Date { get => _date; }
        internal List<LineItems> Item { get => _item; }

        public Order(int id,DateTime date)
        {
            _id = id;
            _date = date;
        }

        public void AddItem(LineItems item)
        {
            bool isAdded = false;
            if (!_item.Equals(null))
            {
                foreach (LineItems i in _item)
                {
                    if (i.Products.Equals(item.Products))
                    {
                        i.Quantity += item.Quantity;
                        isAdded = true;
                    }
                }
                if (!isAdded)
                    _item.Add(item);
            }
            else
                _item.Add(item);
        }

        public double checkOutCost()
        {
            double checkOutCost = 0;
            foreach(LineItems i in _item)
            {
                checkOutCost += i.calculateTotalCost();
            }
            return checkOutCost;
        }

        public override string ToString()
        {
            return "\nOrder ID :" + _id + " Order Date :" + _date + "\n\tLine Item List : " + string.Join(Environment.NewLine.);
        }
    }
}

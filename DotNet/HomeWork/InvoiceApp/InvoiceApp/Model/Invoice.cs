using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceApp.Model
{
    class Invoice
    {
        private int _AccNo;
        private string _Name;
        private double _Amount;
        private double _DiscountPercentage;
        private float _GST;

        public Invoice()
        {
            _AccNo = 0;
            _Name = "";
            _Amount = 00.00;
            _DiscountPercentage = 0.0;
            _GST = 12.2f;
        }
        public Invoice(int accNo, string name, double amount, double discount, float gst)
        {
            this._AccNo = accNo;
            this._Name = name;
            this._GST = gst;
            this._Amount = amount;
            this._DiscountPercentage = discount;
        }

        public int AccNo { get => _AccNo;}
        public string Name { get => _Name;}
        public double Amount { get => _Amount;}
        public double DiscountPercentage { get => _DiscountPercentage; }
        public float GST { get => _GST;}

        public double CalculateDiscount()
        {
            return (this._Amount - ((this._Amount * 10)/100));
        }
        public double CalculateGST()
        {
            return (CalculateDiscount() * 5)/100;
        }
        public double calculateAmount()
        {
            return (CalculateDiscount()) + (CalculateGST());
             
        }
        

    }
}

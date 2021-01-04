using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuitarAppTest.Model
{
    public class Guitar
    {
        private string _serialNo;
        private string _builder;
        private string _model;
        private double _price;
        private string _type;
        private string _backWood;
        private string _topWood;

        public string SerialNo { get => _serialNo; }
        public double Price { get => Price; }
        public string Model { get => _model; set => _model = value; }
        public string Builder { get => _builder; set => _builder = value; }
        public string Type { get => _type; set => _type = value; }
        public string BackWood { get => _backWood; set => _backWood = value; }
        public string TopWood { get => _topWood; set => _topWood = value; }

        public Guitar(string serialNo, string builder, string model, double price,string type,string backwood,string topwood)
        {
            _serialNo = serialNo;
            _builder = builder;
            _model = model;
            _price = price;
            _type = type;
            _backWood = backwood;
            _topWood = topwood;
        }
        public override string ToString()
        {
            return "\nSerial No :" + _serialNo + "\nPrice :" + _price + "\nModel :" + _model + "\nBuilder :" + _builder + "\nType :" + _type +
                "\nBackWood :" + _backWood + "\nTopWood :" + _topWood;
        }
    }
}

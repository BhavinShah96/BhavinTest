using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarAppTest.Model;

namespace GuitarAppTest.Model
{
    public class Inventory
    {
        public List<Guitar> guitars = new List<Guitar>();

        public void AddGuitar(string SerialNo,double Price,string builder,string model,string type,string backWood,string TopWood)
        {
            Guitar guitar = new Guitar(SerialNo,builder,model,Price,type,backWood,TopWood);
            guitars.Add(guitar);
        }
        
        
    }
}

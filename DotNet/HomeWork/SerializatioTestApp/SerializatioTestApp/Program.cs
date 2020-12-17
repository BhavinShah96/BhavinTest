using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using SerializatioTestApp.Model;
using System.IO;

namespace SerializatioTestApp
{
    class Program
    {
        public int ID;
        public String Name;
        static void Main(string[] args)
        {
            Tutorial obj = new Tutorial();
            obj.id = 1;
            obj.name = ".Net";

            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(@"E:\ExampleNew.txt", FileMode.Create, FileAccess.Write);

            formatter.Serialize(stream, obj);
            stream.Close();

            stream = new FileStream(@"E:\ExampleNew.txt", FileMode.Open, FileAccess.Read);
            Tutorial objnew = (Tutorial)formatter.Deserialize(stream);

            Console.WriteLine(objnew.id);
            Console.WriteLine(objnew.name);

            Console.ReadKey();
        }
    }
}

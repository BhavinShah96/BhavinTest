using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary<int, string> myDic = new Dictionary<int, string>();

            myDic.Add(1, "Bhavin");
            myDic.Add(2, "Inder");
            myDic.Add(3, "Parth");
            myDic.Add(4, "Sahista");
            
            Console.WriteLine("Adding Data in Dictionary");
            foreach(KeyValuePair<int,string> i in myDic)
            {
                Console.WriteLine("Key : {0} , Value : {1}", i.Key,i.Value);
            }

            myDic.Remove(2);
            Console.WriteLine("Remove Data in Dictionary");
            foreach (KeyValuePair<int, string> i in myDic)
            {
                Console.WriteLine("Key : {0} , Value : {1}", i.Key, i.Value);
            }


            myDic[1] = "Haku";
            Console.WriteLine("Update Data in Dictionary");
            foreach (KeyValuePair<int, string> i in myDic)
            {
                Console.WriteLine("Key : {0} , Value : {1}", i.Key, i.Value);
            }
        }
    }
}

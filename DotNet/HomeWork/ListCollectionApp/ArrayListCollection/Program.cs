using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList();
            myList.Add("Bhavin");
            myList.Add("Akash");
            myList.Add("Parth");
            myList.Add("Hardik");
            myList.Add("Inder");


            Console.WriteLine("The initial ArrayList: ");

            foreach (var i in myList)
            {
                Console.WriteLine(i + " ");
            }
            myList.RemoveAt(2);
            Console.WriteLine("The ArrayList after Removing elements: ");
            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }
            myList[2] = "Sahishta";
            Console.WriteLine("The ArrayList after Updating elements: ");
            foreach (var i in myList)
            {
                Console.WriteLine(i);
            }
        }
    }
}

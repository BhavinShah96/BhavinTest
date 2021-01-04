using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>();

            for(int i = 5; i <= 10; i++)
            {
                myList.Add(i * 5);
            }

            myList.RemoveAt(1);

            foreach(int j in myList)
            {
                Console.WriteLine(j);
            }
        }
    }
}

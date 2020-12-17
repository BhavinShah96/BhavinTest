using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstanceOfOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Author a = new Author();
            a.Details("Bhavin",5);
            Work w = new Work();
            w.totalNo(80, 80);
            bool result;
            result = a is Author;
            Console.WriteLine("Is a is Author  :" + result);
            result = w is Author;
            Console.WriteLine("IS w is Author  :" + result);
            a = null;
            result = a is Author;
            Console.WriteLine("IS a is Author  :" + result);


            string str = "Bhavin";
            object obj = str;
            List<string> MyList = obj as List<string>;
            if (MyList != null)
            {
                Console.WriteLine("SuccessFull");
            }
            else { Console.WriteLine("Not"); }
            
        }
    }
    class Author
    {
        public string name;
        public int rank;
        public void Details(string n , int r)
        {
            name = n;
            rank = r;
        }
    }
    class Work
    {
        public int articleNo;
        public int improveNo;
        public void totalNo(int a,int i)
        {
            articleNo = a;
            improveNo = i;
        }
    }
}

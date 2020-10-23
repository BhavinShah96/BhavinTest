using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MutableTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int[] s = {10,20,30};
            //Mutable(a);
            //MutableArray(s);
            Console.WriteLine(Mutable(a));
            //Console.WriteLine(s[i]);
        }
       public static int Mutable(int a)
        {
            a = 20;
            
            return a;
        }
        //public static int MutableArray(int[] s)
        //{
        //    for (int i = 0; i < s.Length; i++)
        //    {
        //        s[i] = 0;
                
        //        return ;
        //    }
        //}
    }
}

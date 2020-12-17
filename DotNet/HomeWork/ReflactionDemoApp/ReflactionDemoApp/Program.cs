using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflactionDemoApp
{
    class Program 
    {
        static void Main(string[] args)
        {
            Type t = typeof(StudentApp.Model.student);
            Console.WriteLine("Class :" + t);

            MethodInfo[] m  = t.GetMethods();
            Console.WriteLine("All member details :-");
            PrintMembersInfo(m);

        }
        public static void PrintMembersInfo(MemberInfo[] m)
        {
            foreach(MemberInfo m in m)
            {
                Console.WriteLine(m);
            }
        }
    }
}

using System;
using System.Reflection;
using CustomeAttribute;

namespace ReflactionTest
{
    class Program
    {
        public static int count = 0;
        static void Main(string[] args)
        {
            Type t = typeof(CustomeAttribute.Foo);
            Attribute arr = new CustomeAttribute.NeedToReflector();

            if (arr.Equals(t.GetCustomAttribute<CustomeAttribute.NeedToReflector>()))
            {
                Console.WriteLine("Class that is NeedTOReflactor is : " + t);
            }
            MethodInfo[] m = t.GetMethods();
            PrintMembers(m, arr);
        }

        public static void PrintMembers(MethodInfo[] ms,Attribute arr)
        {
            
            Console.WriteLine("Methods Which have NeedReflactor Custome Attribute " );
            
            foreach (MemberInfo m in ms)
            {
                if (arr.Equals(m.GetCustomAttribute<CustomeAttribute.NeedToReflector>()))
                {
                    Console.WriteLine(m);
                    count++;
                }

            }
            Console.WriteLine("Total No of Reflactor Counts " + count++);
            Console.WriteLine();
        }
    }
}

using System;
using System.Reflection;
using CustomeAttributeApp2;

namespace ReflactionTestApp
{
    class Program
    {
        public static int count = 0;

        static void Main(string[] args)
        {
            Type t = typeof(Foo);
            Attribute arr = new CustomeAttributeApp2.Test();

            MethodInfo[] m = t.GetMethods();
            PrintInfo(m, arr);
        }

        public static void PrintInfo(MethodInfo[] ms, Attribute arr)
        {
            foreach (MemberInfo m in ms)
            {
                if (arr.Equals(m.GetCustomAttribute<CustomeAttributeApp2.Test>()))
                {
                    count++;
                }
                
            }
            Console.WriteLine("Passed Cases : " + count);
            Console.WriteLine("Failed Cases : " + (count-1));
            
        }
    }
}

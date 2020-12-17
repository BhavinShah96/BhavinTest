using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attributes = info.GetCustomerAttribute(true);
        }
    }
    public class HelpAttribute : System.Attribute
    {
        public readonly string url;
        public string Topic
        { get { return topic; } set { topic = value; } }

        public HelpAttribute(string url)
        { this.url = url; }

        private string topic;
    }
    [HelpAttribute("Information on the class My Class")]
    class MyClass { }
}
